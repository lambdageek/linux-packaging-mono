// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Config
{
    using System.Data.Entity.Internal;
    using System.Data.Entity.Resources;
    using System.Data.Entity.Utilities;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    ///     Internal implementation for the DbConfiguration class that uses instance methods to facilitate testing
    ///     while allowing use static methods on the public API which require less dotting through.
    /// </summary>
    internal class InternalConfiguration
    {
        private CompositeResolver<ResolverChain, ResolverChain> _resolvers;
        private RootDependencyResolver _rootResolver;

        // This does not need to be volatile since it only protects against inappropriate use not
        // thread-unsafe use.
        private bool _isLocked;

        /// <summary>
        ///     Any class derived from <see cref="DbConfiguration" /> must have a public parameterless constructor
        ///     and that constructor should call this constructor.
        /// </summary>
        public InternalConfiguration()
            : this(new ResolverChain(), new ResolverChain(), new RootDependencyResolver())
        {
            _resolvers.First.Add(new AppConfigDependencyResolver(AppConfig.DefaultInstance));
        }

        public InternalConfiguration(ResolverChain appConfigChain, ResolverChain normalResolverChain, RootDependencyResolver rootResolver)
        {
            DebugCheck.NotNull(appConfigChain);
            DebugCheck.NotNull(normalResolverChain);

            _rootResolver = rootResolver;
            _resolvers = new CompositeResolver<ResolverChain, ResolverChain>(appConfigChain, normalResolverChain);
            _resolvers.Second.Add(_rootResolver);
        }

        /// <summary>
        ///     The Singleton instance of <see cref="DbConfiguration" /> for this app domain. This can be
        ///     set at application start before any Entity Framework features have been used and afterwards
        ///     should be treated as read-only.
        /// </summary>
        public static InternalConfiguration Instance
        {
            // Note that GetConfiguration and SetConfiguration on DbConfigurationManager are thread-safe.
            get { return DbConfigurationManager.Instance.GetConfiguration(); }
            set
            {
                DebugCheck.NotNull(value);

                DbConfigurationManager.Instance.SetConfiguration(value);
            }
        }

        public virtual void Lock()
        {
            DbConfigurationManager.Instance.OnLocking(this);
            _isLocked = true;
        }

        public virtual void AddAppConfigResolver(IDbDependencyResolver resolver)
        {
            DebugCheck.NotNull(resolver);

            _resolvers.First.Add(resolver);
        }

        public virtual void AddDependencyResolver(IDbDependencyResolver resolver, bool overrideConfigFile = false)
        {
            DebugCheck.NotNull(resolver);
            Debug.Assert(!_isLocked);

            // New resolvers always run after the config resolvers so that config always wins over code
            // unless the override flag is used, in which case we add the new resolver right at the top.
            (overrideConfigFile ? _resolvers.First : _resolvers.Second).Add(resolver);
        }

        public virtual void RegisterSingleton<TService>(TService instance, object key)
            where TService : class
        {
            DebugCheck.NotNull(instance);
            Debug.Assert(!_isLocked);

            AddDependencyResolver(new SingletonDependencyResolver<TService>(instance, key));
        }

        public virtual TService GetService<TService>(object key)
        {
            return _resolvers.GetService<TService>(key);
        }

        public virtual IDbDependencyResolver DependencyResolver
        {
            get { return _resolvers; }
        }

        public virtual RootDependencyResolver RootResolver
        {
            get { return _rootResolver; }
        }

        /// <summary>
        ///     This method is not thread-safe and should only be used to switch in a different root resolver
        ///     before the configuration is locked and set. It is used for pushing a new configuration by
        ///     DbContextInfo while maintaining legacy settings (such as database initializers) that are
        ///     set on the root resolver.
        /// </summary>
        public virtual void SwitchInRootResolver(RootDependencyResolver value)
        {
            DebugCheck.NotNull(value);

            Debug.Assert(!_isLocked);

            // The following is not thread-safe but this code is only called when pushing a configuration
            // and happens to a new DbConfiguration before it has been set and locked.
            var newChain = new ResolverChain();
            newChain.Add(value);
            _resolvers.Second.Resolvers.Skip(1).Each(newChain.Add);

            _rootResolver = value;
            _resolvers = new CompositeResolver<ResolverChain, ResolverChain>(_resolvers.First, newChain);
        }

        public virtual IDbDependencyResolver ResolverSnapshot
        {
            get
            {
                var newChain = new ResolverChain();
                _resolvers.Second.Resolvers.Each(newChain.Add);
                _resolvers.First.Resolvers.Each(newChain.Add);
                return newChain;
            }
        }

        public virtual DbConfiguration Owner { get; set; }

        public virtual void CheckNotLocked(string memberName)
        {
            if (_isLocked)
            {
                throw new InvalidOperationException(Strings.ConfigurationLocked(memberName));
            }
        }
    }
}

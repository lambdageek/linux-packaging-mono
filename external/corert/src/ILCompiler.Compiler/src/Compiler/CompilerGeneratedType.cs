﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

using Internal.TypeSystem;

using Debug = System.Diagnostics.Debug;
using TypeHashingAlgorithms = Internal.NativeFormat.TypeHashingAlgorithms;

namespace ILCompiler
{
    /// <summary>
    /// A pseudo-type that owns helper methods generated by the compiler.
    /// This type should never be allocated (we should never see an EEType for it).
    /// </summary>
    internal sealed class CompilerGeneratedType : MetadataType
    {
        private int _hashcode;

        public CompilerGeneratedType(ModuleDesc module, string name)
        {
            Module = module;
            Name = name;
        }

        public override TypeSystemContext Context
        {
            get
            {
                return Module.Context;
            }
        }

        public override string Name
        {
            get;
        }

        public override string Namespace
        {
            get
            {
                return "Internal.CompilerGenerated";
            }
        }

        public override int GetHashCode()
        {
            if (_hashcode != 0)
                return _hashcode;
            return InitializeHashCode();
        }

        private int InitializeHashCode()
        {
            string ns = Namespace;
            var hashCodeBuilder = new TypeHashingAlgorithms.HashCodeBuilder(ns);
            if (ns.Length > 0)
                hashCodeBuilder.Append(".");
            hashCodeBuilder.Append(Name);
            _hashcode = hashCodeBuilder.ToHashCode();

            return _hashcode;
        }

        public override bool IsCanonicalSubtype(CanonicalFormKind policy)
        {
            Debug.Assert(!HasInstantiation, "Why is this generic?");
            return false;
        }

        protected override TypeFlags ComputeTypeFlags(TypeFlags mask)
        {
            return TypeFlags.Class |
                TypeFlags.HasGenericVarianceComputed |
                TypeFlags.HasStaticConstructorComputed;
        }

        public override ClassLayoutMetadata GetClassLayout()
        {
            return new ClassLayoutMetadata
            {
                Offsets = null,
                PackingSize = 0,
                Size = 0,
            };
        }

        public override bool HasCustomAttribute(string attributeNamespace, string attributeName)
        {
            return false;
        }

        public override IEnumerable<MetadataType> GetNestedTypes()
        {
            return Array.Empty<MetadataType>();
        }

        public override MetadataType GetNestedType(string name)
        {
            return null;
        }

        protected override MethodImplRecord[] ComputeVirtualMethodImplsForType()
        {
            return Array.Empty<MethodImplRecord>();
        }

        public override MethodImplRecord[] FindMethodsImplWithMatchingDeclName(string name)
        {
            return Array.Empty<MethodImplRecord>();
        }

        public override ModuleDesc Module
        {
            get;
        }

        public override PInvokeStringFormat PInvokeStringFormat
        {
            get
            {
                return PInvokeStringFormat.AutoClass;
            }
        }

        public override bool IsExplicitLayout
        {
            get
            {
                return false;
            }
        }

        public override bool IsSequentialLayout
        {
            get
            {
                return false;
            }
        }

        public override bool IsBeforeFieldInit
        {
            get
            {
                return false;
            }
        }

        public override MetadataType MetadataBaseType
        {
            get
            {
                // Since this type should never be allocated and only serves the purpose of grouping things,
                // it can act like a <Module> type and have no base type.
                return null;
            }
        }

        public override bool IsSealed
        {
            get
            {
                return true;
            }
        }

        public override bool IsAbstract
        {
            get
            {
                return false;
            }
        }

        public override DefType ContainingType
        {
            get
            {
                return null;
            }
        }

        public override DefType[] ExplicitlyImplementedInterfaces
        {
            get
            {
                return Array.Empty<DefType>();
            }
        }
    }
}
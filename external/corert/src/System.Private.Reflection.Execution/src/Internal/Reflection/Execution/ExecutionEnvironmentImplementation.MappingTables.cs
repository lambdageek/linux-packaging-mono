// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using global::System;
using global::System.Reflection;
using global::System.Collections.Generic;

using global::Internal.Runtime.Augments;
using global::Internal.Runtime.CompilerServices;
using global::Internal.Runtime.TypeLoader;

using global::Internal.Reflection.Core;
using global::Internal.Reflection.Core.Execution;
using global::Internal.Reflection.Execution.MethodInvokers;
using global::Internal.Reflection.Execution.FieldAccessors;

using global::Internal.Metadata.NativeFormat;

using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;

using global::Internal.Runtime;
using global::Internal.NativeFormat;

using System.Reflection.Runtime.General;

using CanonicalFormKind = global::Internal.TypeSystem.CanonicalFormKind;


using Debug = System.Diagnostics.Debug;
using TargetException = System.ArgumentException;
using ThunkKind = Internal.Runtime.TypeLoader.CallConverterThunk.ThunkKind;
using Interlocked = System.Threading.Interlocked;

namespace Internal.Reflection.Execution
{
    //==========================================================================================================
    // These ExecutionEnvironment entrypoints provide access to the NUTC-generated blob information that
    // enables Reflection invoke and tie-ins to native Type artifacts.
    //
    // - Except when otherwise noted, ExecutionEnvironment methods use the "TryGet*" pattern rather than throwing exceptions.
    //
    // - All methods on this class must be multi-thread-safe. Reflection can and does invoke them on different threads with no synchronization of its own.
    //
    //==========================================================================================================
    internal sealed partial class ExecutionEnvironmentImplementation : ExecutionEnvironment
    {
        private struct MethodTargetAndDictionary { public IntPtr TargetPointer; public IntPtr DictionaryPointer; }

        private LowLevelDictionary<IntPtr, MethodTargetAndDictionary> _callConverterWrappedMethodEntrypoints = new LowLevelDictionary<IntPtr, MethodTargetAndDictionary>();

        private RuntimeTypeHandle GetOpenTypeDefinition(RuntimeTypeHandle typeHandle, out RuntimeTypeHandle[] typeArgumentsHandles)
        {
            if (RuntimeAugments.IsGenericType(typeHandle))
            {
                return RuntimeAugments.GetGenericInstantiation(typeHandle, out typeArgumentsHandles);
            }

            typeArgumentsHandles = null;
            return typeHandle;
        }

        private RuntimeTypeHandle GetTypeDefinition(RuntimeTypeHandle typeHandle)
        {
            if (RuntimeAugments.IsGenericType(typeHandle))
                return RuntimeAugments.GetGenericDefinition(typeHandle);

            return typeHandle;
        }

        private static bool RuntimeTypeHandleIsNonDefault(RuntimeTypeHandle runtimeTypeHandle)
        {
            return ((IntPtr)RuntimeAugments.GetPointerFromTypeHandle(runtimeTypeHandle)) != IntPtr.Zero;
        }

        private static unsafe NativeReader GetNativeReaderForBlob(NativeFormatModuleInfo module, ReflectionMapBlob blob)
        {
            NativeReader reader;
            if (TryGetNativeReaderForBlob(module, blob, out reader))
            {
                return reader;
            }

            Debug.Assert(false);
            return default(NativeReader);
        }

        private static unsafe bool TryGetNativeReaderForBlob(NativeFormatModuleInfo module, ReflectionMapBlob blob, out NativeReader reader)
        {
            byte* pBlob;
            uint cbBlob;

            if (module.TryFindBlob((int)blob, out pBlob, out cbBlob))
            {
                reader = new NativeReader(pBlob, cbBlob);
                return true;
            }

            reader = default(NativeReader);
            return false;
        }

        /// <summary>
        /// Return the metadata handle for a TypeDef if the pay-for-policy enabled this type as browsable. This is used to obtain name and other information for types
        /// obtained via typeof() or Object.GetType(). This can include generic types (Foo<>) (not to be confused with generic instances of Foo<>).
        ///
        /// Preconditions:
        ///    runtimeTypeHandle is a typedef (not a constructed type such as an array or generic instance.)
        /// </summary>
        /// <param name="runtimeTypeHandle">Runtime handle of the type in question</param>
        /// <param name="metadataReader">Metadata reader located for the type</param>
        /// <param name="typeDefHandle">TypeDef handle for the type</param>
        public unsafe sealed override bool TryGetMetadataForNamedType(RuntimeTypeHandle runtimeTypeHandle, out QTypeDefinition qTypeDefinition)
        {
            Debug.Assert(!RuntimeAugments.IsGenericType(runtimeTypeHandle));
            return TypeLoaderEnvironment.Instance.TryGetMetadataForNamedType(runtimeTypeHandle, out qTypeDefinition);
        }

        //
        // Return true for a TypeDef if the policy has decided this type is blocked from reflection.
        //
        // Preconditions:
        //    runtimeTypeHandle is a typedef or a generic type instance (not a constructed type such as an array)
        //
        public unsafe sealed override bool IsReflectionBlocked(RuntimeTypeHandle runtimeTypeHandle)
        {
            // CORERT-TODO: reflection blocking
#if !CORERT
            // For generic types, use the generic type definition
            runtimeTypeHandle = GetTypeDefinition(runtimeTypeHandle);

            var moduleHandle = RuntimeAugments.GetModuleFromTypeHandle(runtimeTypeHandle);
            NativeFormatModuleInfo module = ModuleList.Instance.GetModuleInfoByHandle(moduleHandle);

            NativeReader blockedReflectionReader = GetNativeReaderForBlob(module, ReflectionMapBlob.BlockReflectionTypeMap);
            NativeParser blockedReflectionParser = new NativeParser(blockedReflectionReader, 0);
            NativeHashtable blockedReflectionHashtable = new NativeHashtable(blockedReflectionParser);
            ExternalReferencesTable externalReferences = default(ExternalReferencesTable);
            externalReferences.InitializeCommonFixupsTable(module);

            int hashcode = runtimeTypeHandle.GetHashCode();
            var lookup = blockedReflectionHashtable.Lookup(hashcode);
            NativeParser entryParser;
            while (!(entryParser = lookup.GetNext()).IsNull)
            {
                RuntimeTypeHandle entryType = externalReferences.GetRuntimeTypeHandleFromIndex(entryParser.GetUnsigned());
                if (!entryType.Equals(runtimeTypeHandle))
                    continue;

                // Entry found, must be blocked
                return true;
            }
            // Entry not found, must not be blocked
#endif
            return false;
        }

        /// <summary>
        /// Return the RuntimeTypeHandle for the named type described in metadata. This is used to implement the Create and Invoke
        /// apis for types.
        ///
        /// Preconditions:
        ///    metadataReader + typeDefHandle  - a valid metadata reader + typeDefinitionHandle where "metadataReader" is one
        ///                                      of the metadata readers returned by ExecutionEnvironment.MetadataReaders.
        ///
        /// Note: Although this method has a "bool" return value like the other mapping table accessors, the Project N pay-for-play design 
        /// guarantees that any type enabled for metadata also has a RuntimeTypeHandle underneath.
        /// </summary>
        /// <param name="metadataReader">Metadata reader for module containing the type</param>
        /// <param name="typeDefHandle">TypeDef handle for the type to look up</param>
        /// <param name="runtimeTypeHandle">Runtime type handle (EEType) for the given type</param>
        public unsafe sealed override bool TryGetNamedTypeForMetadata(QTypeDefinition qTypeDefinition, out RuntimeTypeHandle runtimeTypeHandle)
        {
            return TypeLoaderEnvironment.Instance.TryGetOrCreateNamedTypeForMetadata(qTypeDefinition, out runtimeTypeHandle);
        }

        /// <summary>
        /// Return the metadata handle for a TypeRef if this type was referenced indirectly by other type that pay-for-play has denoted as browsable
        /// (for example, as part of a method signature.)
        ///
        /// This is only used in "debug" builds to provide better MissingMetadataException diagnostics. 
        ///
        /// Preconditions:
        ///    runtimeTypeHandle is a typedef (not a constructed type such as an array or generic instance.)
        /// </summary>
        /// <param name="runtimeTypeHandle">EEType of the type in question</param>
        /// <param name="metadataReader">Metadata reader for the type</param>
        /// <param name="typeRefHandle">Located TypeRef handle</param>
        public unsafe sealed override bool TryGetTypeReferenceForNamedType(RuntimeTypeHandle runtimeTypeHandle, out MetadataReader metadataReader, out TypeReferenceHandle typeRefHandle)
        {
            return TypeLoaderEnvironment.TryGetTypeReferenceForNamedType(runtimeTypeHandle, out metadataReader, out typeRefHandle);
        }

        /// <summary>
        /// Return the RuntimeTypeHandle for the named type referenced by another type that pay-for-play denotes as browsable (for example,
        /// in a member signature.) Typically, the type itself is *not* browsable (or it would have appeared in the TypeDef table.)
        ///
        /// This is used to ensure that we can produce a Type object if requested and that it match up with the analogous
        /// Type obtained via typeof().
        /// 
        ///
        /// Preconditions:
        ///    metadataReader + typeRefHandle  - a valid metadata reader + typeReferenceHandle where "metadataReader" is one
        ///                                      of the metadata readers returned by ExecutionEnvironment.MetadataReaders.
        ///
        /// Note: Although this method has a "bool" return value like the other mapping table accessors, the Project N pay-for-play design 
        /// guarantees that any type that has a metadata TypeReference to it also has a RuntimeTypeHandle underneath.
        /// </summary>
        /// <param name="metadataReader">Metadata reader for module containing the type reference</param>
        /// <param name="typeRefHandle">TypeRef handle to look up</param>
        /// <param name="runtimeTypeHandle">Resolved EEType for the type reference</param>
        public unsafe sealed override bool TryGetNamedTypeForTypeReference(MetadataReader metadataReader, TypeReferenceHandle typeRefHandle, out RuntimeTypeHandle runtimeTypeHandle)
        {
            return TypeLoaderEnvironment.TryGetNamedTypeForTypeReference(metadataReader, typeRefHandle, out runtimeTypeHandle);
        }

        //
        // Given a RuntimeTypeHandle for any type E, return a RuntimeTypeHandle for type E[], if the pay for play policy denotes E[] as browsable. This is used to
        // implement Array.CreateInstance().
        //
        // Preconditions:
        //     elementTypeHandle is a valid RuntimeTypeHandle.
        //
        // This is not equivalent to calling TryGetMultiDimTypeForElementType() with a rank of 1!
        //
        public unsafe sealed override bool TryGetArrayTypeForElementType(RuntimeTypeHandle elementTypeHandle, out RuntimeTypeHandle arrayTypeHandle)
        {
            if (RuntimeAugments.IsGenericTypeDefinition(elementTypeHandle))
            {
                throw new NotSupportedException(SR.NotSupported_OpenType);
            }

            // For non-dynamic arrays try to look up the array type in the ArrayMap blobs;
            // attempt to dynamically create a new one if that doesn't succeeed.
            return TypeLoaderEnvironment.Instance.TryGetArrayTypeForElementType(elementTypeHandle, false, -1, out arrayTypeHandle);
        }

        //
        // Given a RuntimeTypeHandle for any array type E[], return a RuntimeTypeHandle for type E, if the pay for play policy denoted E[] as browsable. 
        //
        // Preconditions:
        //      arrayTypeHandle is a valid RuntimeTypeHandle of type array.
        //
        // This is not equivalent to calling TryGetMultiDimTypeElementType() with a rank of 1!
        //
        public unsafe sealed override bool TryGetArrayTypeElementType(RuntimeTypeHandle arrayTypeHandle, out RuntimeTypeHandle elementTypeHandle)
        {
            elementTypeHandle = RuntimeAugments.GetRelatedParameterTypeHandle(arrayTypeHandle);
            return true;
        }


        //
        // Given a RuntimeTypeHandle for any type E, return a RuntimeTypeHandle for type E[,,], if the pay for policy denotes E[,,] as browsable. This is used to
        // implement Type.MakeArrayType(Type, int).
        //
        // Preconditions:
        //     elementTypeHandle is a valid RuntimeTypeHandle.
        //
        // Calling this with rank 1 is not equivalent to calling TryGetArrayTypeForElementType()! 
        //
        public unsafe sealed override bool TryGetMultiDimArrayTypeForElementType(RuntimeTypeHandle elementTypeHandle, int rank, out RuntimeTypeHandle arrayTypeHandle)
        {
            if (RuntimeAugments.IsGenericTypeDefinition(elementTypeHandle))
            {
                throw new NotSupportedException(SR.NotSupported_OpenType);
            }
            
            if ((rank < MDArray.MinRank) || (rank > MDArray.MaxRank))
            {
                throw new PlatformNotSupportedException(SR.Format(SR.PlatformNotSupported_NoMultiDims, rank));
            }

            return TypeLoaderEnvironment.Instance.TryGetArrayTypeForElementType(elementTypeHandle, true, rank, out arrayTypeHandle);
        }

        //
        // Given a RuntimeTypeHandle for any type E, return a RuntimeTypeHandle for type E*, if the pay-for-play policy denotes E* as browsable. This is used to
        // ensure that "typeof(E*)" and "typeof(E).MakePointerType()" returns the same Type object.
        //
        // Preconditions:
        //     targetTypeHandle is a valid RuntimeTypeHandle.
        //
        public unsafe sealed override bool TryGetPointerTypeForTargetType(RuntimeTypeHandle targetTypeHandle, out RuntimeTypeHandle pointerTypeHandle)
        {
            return TypeLoaderEnvironment.Instance.TryGetPointerTypeForTargetType(targetTypeHandle, out pointerTypeHandle);
        }

        //
        // Given a RuntimeTypeHandle for any pointer type E*, return a RuntimeTypeHandle for type E, if the pay-for-play policy denotes E* as browsable. 
        // This is used to implement Type.GetElementType() for pointers.
        //
        // Preconditions:
        //      pointerTypeHandle is a valid RuntimeTypeHandle of type pointer.
        //
        public unsafe sealed override bool TryGetPointerTypeTargetType(RuntimeTypeHandle pointerTypeHandle, out RuntimeTypeHandle targetTypeHandle)
        {
            targetTypeHandle = RuntimeAugments.GetRelatedParameterTypeHandle(pointerTypeHandle);
            return true;
        }

        //
        // Given a RuntimeTypeHandle for any type E, return a RuntimeTypeHandle for type E&, if the pay-for-play policy denotes E& as browsable. This is used to
        // ensure that "typeof(E&)" and "typeof(E).MakeByRefType()" returns the same Type object.
        //
        // Preconditions:
        //     targetTypeHandle is a valid RuntimeTypeHandle.
        //
        public unsafe sealed override bool TryGetByRefTypeForTargetType(RuntimeTypeHandle targetTypeHandle, out RuntimeTypeHandle byRefTypeHandle)
        {
            return TypeLoaderEnvironment.Instance.TryGetByRefTypeForTargetType(targetTypeHandle, out byRefTypeHandle);
        }

        //
        // Given a RuntimeTypeHandle for any byref type E&, return a RuntimeTypeHandle for type E, if the pay-for-play policy denotes E& as browsable. 
        // This is used to implement Type.GetElementType() for byrefs.
        //
        // Preconditions:
        //      byRefTypeHandle is a valid RuntimeTypeHandle of a byref.
        //
        public unsafe sealed override bool TryGetByRefTypeTargetType(RuntimeTypeHandle byRefTypeHandle, out RuntimeTypeHandle targetTypeHandle)
        {
            targetTypeHandle = RuntimeAugments.GetRelatedParameterTypeHandle(byRefTypeHandle);
            return true;
        }

        //
        // Given a RuntimeTypeHandle for a generic type G and a set of RuntimeTypeHandles T1, T2.., return the RuntimeTypeHandle for the generic
        // instance G<T1,T2...> if the pay-for-play policy denotes G<T1,T2...> as browsable. This is used to implement Type.MakeGenericType().
        //
        // Preconditions:
        //      runtimeTypeDefinitionHandle is a valid RuntimeTypeHandle for a generic type.
        //      genericTypeArgumentHandles is an array of valid RuntimeTypeHandles.
        //
        public unsafe sealed override bool TryGetConstructedGenericTypeForComponents(RuntimeTypeHandle genericTypeDefinitionHandle, RuntimeTypeHandle[] genericTypeArgumentHandles, out RuntimeTypeHandle runtimeTypeHandle)
        {
            if (TypeLoaderEnvironment.Instance.TryLookupConstructedGenericTypeForComponents(genericTypeDefinitionHandle, genericTypeArgumentHandles, out runtimeTypeHandle))
            {
                return true;
            }

            TypeInfo typeDefinition = Type.GetTypeFromHandle(genericTypeDefinitionHandle).GetTypeInfo();

            TypeInfo[] typeArguments = new TypeInfo[genericTypeArgumentHandles.Length];
            for (int i = 0; i < genericTypeArgumentHandles.Length; i++)
                typeArguments[i] = Type.GetTypeFromHandle(genericTypeArgumentHandles[i]).GetTypeInfo();

            ConstraintValidator.EnsureSatisfiesClassConstraints(typeDefinition, typeArguments);

            return TypeLoaderEnvironment.Instance.TryGetConstructedGenericTypeForComponents(genericTypeDefinitionHandle, genericTypeArgumentHandles, out runtimeTypeHandle);
        }

        public sealed override MethodInvoker TryGetMethodInvoker(RuntimeTypeHandle declaringTypeHandle, QMethodDefinition methodHandle, RuntimeTypeHandle[] genericMethodTypeArgumentHandles)
        {
            if (RuntimeAugments.IsNullable(declaringTypeHandle))
                return new NullableInstanceMethodInvoker(methodHandle.NativeFormatReader, methodHandle.NativeFormatHandle, declaringTypeHandle, null);
            else if (declaringTypeHandle.Equals(typeof(String).TypeHandle))
            {
                MetadataReader reader = methodHandle.NativeFormatReader;
                MethodHandle nativeFormatHandle = methodHandle.NativeFormatHandle;

                Method method = nativeFormatHandle.GetMethod(reader);
                MethodAttributes methodAttributes = method.Flags;
                if (((method.Flags & MethodAttributes.MemberAccessMask) == MethodAttributes.Public) &&
                    ((method.Flags & MethodAttributes.SpecialName) == MethodAttributes.SpecialName) &&
                    (method.Name.GetConstantStringValue(reader).Value == ".ctor"))
                {
                    return new StringConstructorMethodInvoker(reader, nativeFormatHandle);
                }
            }
            else if (declaringTypeHandle.Equals(typeof(IntPtr).TypeHandle) || declaringTypeHandle.Equals(typeof(UIntPtr).TypeHandle))
            {
                MetadataReader reader = methodHandle.NativeFormatReader;
                MethodHandle nativeFormatHandle = methodHandle.NativeFormatHandle;

                Method method = nativeFormatHandle.GetMethod(reader);
                MethodAttributes methodAttributes = method.Flags;
                if (((method.Flags & MethodAttributes.MemberAccessMask) == MethodAttributes.Public) &&
                    ((method.Flags & MethodAttributes.SpecialName) == MethodAttributes.SpecialName) &&
                    (method.Name.GetConstantStringValue(reader).Value == ".ctor"))
                {
                    return new IntPtrConstructorMethodInvoker(reader, nativeFormatHandle);
                }
            }

            MethodBase methodInfo = ReflectionCoreExecution.ExecutionDomain.GetMethod(declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles);

            // Validate constraints first. This is potentially useless work if the method already exists, but it prevents bad
            // inputs to reach the type loader (we don't have support to e.g. represent pointer types within the type loader)
            if (genericMethodTypeArgumentHandles != null && genericMethodTypeArgumentHandles.Length > 0)
                ConstraintValidator.EnsureSatisfiesClassConstraints((MethodInfo)methodInfo);

            MethodSignatureComparer methodSignatureComparer = new MethodSignatureComparer(methodHandle);

            MethodInvokeInfo methodInvokeInfo;
#if GENERICS_FORCE_USG
            // Stress mode to force the usage of universal canonical method targets for reflection invokes.
            // It is recommended to use "/SharedGenericsMode GenerateAllUniversalGenerics" NUTC command line argument when
            // compiling the application in order to effectively use the GENERICS_FORCE_USG mode.

            // If we are just trying to invoke a non-generic method on a non-generic type, we won't force the universal lookup
            if (!RuntimeAugments.IsGenericType(declaringTypeHandle) && (genericMethodTypeArgumentHandles == null || genericMethodTypeArgumentHandles.Length == 0))
                methodInvokeInfo = TryGetMethodInvokeInfo(declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles,
                    methodInfo, ref methodSignatureComparer, CanonicalFormKind.Specific);
            else
                methodInvokeInfo = TryGetMethodInvokeInfo(declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles,
                    methodInfo, ref methodSignatureComparer, CanonicalFormKind.Universal);
#else
            methodInvokeInfo = TryGetMethodInvokeInfo(declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles,
                methodInfo, ref methodSignatureComparer, CanonicalFormKind.Specific);

            // If we failed to get a MethodInvokeInfo for an exact method, or a canonically equivalent method, check if there is a universal canonically
            // equivalent entry that could be used (it will be much slower, and require a calling convention converter)
            if (methodInvokeInfo == null)
                methodInvokeInfo = TryGetMethodInvokeInfo(declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles,
                    methodInfo, ref methodSignatureComparer, CanonicalFormKind.Universal);
#endif

            if (methodInvokeInfo == null)
                return null;

            return MethodInvokerWithMethodInvokeInfo.CreateMethodInvoker(declaringTypeHandle, methodHandle, methodInvokeInfo);
        }

        // Get the pointers necessary to call a dynamic method invocation function
        //
        // This is either a function pointer to call, or a function pointer and template token.
        private unsafe void GetDynamicMethodInvokeMethodInfo(NativeFormatModuleInfo module, uint cookie, RuntimeTypeHandle[] argHandles,
            out IntPtr dynamicInvokeMethod, out IntPtr dynamicInvokeMethodGenericDictionary)
        {
            if ((cookie & 1) == 1)
            {
                // If the dynamic invoke method is a generic method, we need to consult the DynamicInvokeTemplateData table to locate
                // the matching template so that we can instantiate it. The DynamicInvokeTemplateData table starts with a single UINT
                // with the RVA of the type that hosts all DynamicInvoke methods. The table then follows with list of [Token, FunctionPointer]
                // pairs. The cookie parameter is an index into this table and points to a single pair.
                byte* pBlobAsBytes;
                uint cbBlob;
                bool success = module.TryFindBlob((int)ReflectionMapBlob.DynamicInvokeTemplateData, out pBlobAsBytes, out cbBlob);
                uint* pBlob = (uint*)pBlobAsBytes;
                Debug.Assert(success && cbBlob > 4);

                byte* pNativeLayoutInfoBlob;
                uint cbNativeLayoutInfoBlob;
                success = module.TryFindBlob((int)ReflectionMapBlob.NativeLayoutInfo, out pNativeLayoutInfoBlob, out cbNativeLayoutInfoBlob);
                Debug.Assert(success);

                RuntimeTypeHandle declaringTypeHandle;
                // All methods referred from this blob are contained in the same type. The first UINT in the blob is a reloc to that EEType
                if (module.Handle.IsTypeManager)
                {
                    // CoreRT uses 32bit relative relocs
                    declaringTypeHandle = RuntimeAugments.CreateRuntimeTypeHandle((IntPtr)((byte*)(&pBlob[1]) + (int)(pBlob[0])));
                }
                else
                {
                    // .NET Native uses RVAs
                    declaringTypeHandle = TypeLoaderEnvironment.RvaToRuntimeTypeHandle(module.Handle, pBlob[0]);
                }

                // The index points to two entries: the token of the dynamic invoke method and the function pointer to the canonical method
                // Now have the type loader build or locate a dictionary for this method
                uint index = cookie >> 1;

                MethodNameAndSignature nameAndSignature;
                RuntimeSignature nameAndSigSignature = RuntimeSignature.CreateFromNativeLayoutSignature(module.Handle, pBlob[index]);
                success = TypeLoaderEnvironment.Instance.TryGetMethodNameAndSignatureFromNativeLayoutSignature(nameAndSigSignature, out nameAndSignature);
                Debug.Assert(success);

                success = TypeLoaderEnvironment.Instance.TryGetGenericMethodDictionaryForComponents(declaringTypeHandle, argHandles, nameAndSignature, out dynamicInvokeMethodGenericDictionary);
                Debug.Assert(success);

                if (module.Handle.IsTypeManager)
                {
                    // CoreRT uses 32bit relative relocs
                    dynamicInvokeMethod = (IntPtr)((byte*)(&pBlob[index + 2]) + (int)(pBlob[index + 1]));
                }
                else
                {
                    // .NET Native uses RVAs
                    dynamicInvokeMethod = TypeLoaderEnvironment.RvaToFunctionPointer(module.Handle, pBlob[index + 1]);
                }
            }
            else
            {
                // Nongeneric DynamicInvoke method. This is used to DynamicInvoke methods that have parameters that
                // cannot be shared (or if there are no parameters to begin with).
                ExternalReferencesTable extRefs = default(ExternalReferencesTable);
                extRefs.InitializeCommonFixupsTable(module);

                dynamicInvokeMethod = extRefs.GetFunctionPointerFromIndex(cookie >> 1);
                dynamicInvokeMethodGenericDictionary = IntPtr.Zero;
            }
        }

        private IntPtr GetDynamicMethodInvokerThunk(RuntimeTypeHandle[] argHandles, MethodBase methodInfo)
        {
            ParameterInfo[] parameters = methodInfo.GetParametersNoCopy();
            // last entry in argHandles is the return type if the type is not typeof(void)
            Debug.Assert(parameters.Length == argHandles.Length || parameters.Length == (argHandles.Length - 1));

            bool[] byRefParameters = new bool[parameters.Length + 1];
            RuntimeTypeHandle[] parameterTypeHandles = new RuntimeTypeHandle[parameters.Length + 1];

            // This is either a constructor ("returns" void) or an instance method
            MethodInfo reflectionMethodInfo = methodInfo as MethodInfo;
            parameterTypeHandles[0] = (reflectionMethodInfo != null ? reflectionMethodInfo.ReturnType.TypeHandle : CommonRuntimeTypes.Void.TypeHandle);
            byRefParameters[0] = false;

            for (int i = 0; i < parameters.Length; i++)
            {
                parameterTypeHandles[i + 1] = argHandles[i];
                byRefParameters[i + 1] = parameters[i].ParameterType.IsByRef;
            }

            return CallConverterThunk.MakeThunk(ThunkKind.ReflectionDynamicInvokeThunk, IntPtr.Zero, IntPtr.Zero, false, parameterTypeHandles, byRefParameters, null);
        }

        private RuntimeTypeHandle[] GetDynamicInvokeInstantiationArguments(MethodBase reflectionMethodBase)
        {
            // The DynamicInvoke method is a generic method with arguments that match the arguments of the target method.
            // Prepare the list of arguments so that we can use it to instantiate the method.

            MethodParametersInfo methodParamsInfo = new MethodParametersInfo(reflectionMethodBase);
            LowLevelList<RuntimeTypeHandle> dynamicInvokeMethodGenArguments = methodParamsInfo.ParameterTypeHandles;

            // This is either a constructor ("returns" void) or an instance method
            MethodInfo reflectionMethodInfo = reflectionMethodBase as MethodInfo;
            Type returnType = reflectionMethodInfo != null ? reflectionMethodInfo.ReturnType : CommonRuntimeTypes.Void;

            // Only use the return type if it's not void
            if (!returnType.Equals(CommonRuntimeTypes.Void))
                dynamicInvokeMethodGenArguments.Add(returnType.TypeHandle);

            return dynamicInvokeMethodGenArguments.ToArray();
        }

        private static RuntimeTypeHandle[] GetTypeSequence(ref ExternalReferencesTable extRefs, ref NativeParser parser)
        {
            uint count = parser.GetUnsigned();
            RuntimeTypeHandle[] result = new RuntimeTypeHandle[count];
            for (uint i = 0; i < count; i++)
            {
                result[i] = extRefs.GetRuntimeTypeHandleFromIndex(parser.GetUnsigned());
            }
            return result;
        }

        private IntPtr TryGetVirtualResolveData(NativeFormatModuleInfo module,
            RuntimeTypeHandle methodHandleDeclaringType, QMethodDefinition methodHandle, RuntimeTypeHandle[] genericArgs,
            ref MethodSignatureComparer methodSignatureComparer)
        {
            TypeLoaderEnvironment.VirtualResolveDataResult lookupResult;
            bool success = TypeLoaderEnvironment.TryGetVirtualResolveData(module, methodHandleDeclaringType, genericArgs, ref methodSignatureComparer, out lookupResult);
            if (!success)
                return IntPtr.Zero;
            else
            {
                GCHandle reader = Internal.TypeSystem.LockFreeObjectInterner.GetInternedObjectHandle(methodHandle.Reader);

                if (lookupResult.IsGVM)
                {
                    return (new OpenMethodResolver(lookupResult.DeclaringInvokeType, lookupResult.GVMHandle, reader, methodHandle.Token)).ToIntPtr();
                }
                else
                {
                    return (new OpenMethodResolver(lookupResult.DeclaringInvokeType, lookupResult.SlotIndex, reader, methodHandle.Token)).ToIntPtr();
                }
            }
        }

        /// <summary>
        /// Try to look up method invoke info in metadata for all registered modules, construct
        /// the calling convention converter as appropriate and fill in MethodInvokeInfo.
        /// </summary>
        /// <param name="metadataReader">Metadata reader for the declaring type</param>
        /// <param name="declaringTypeHandle">Runtime handle of declaring type for the method</param>
        /// <param name="methodHandle">Handle of method to look up</param>
        /// <param name="genericMethodTypeArgumentHandles">Runtime handles of generic method arguments</param>
        /// <param name="methodSignatureComparer">Helper structure used for comparing signatures</param>
        /// <param name="canonFormKind">Requested canon form</param>
        /// <returns>Constructed method invoke info, null on failure</returns>
        private unsafe MethodInvokeInfo TryGetMethodInvokeInfo(
            RuntimeTypeHandle declaringTypeHandle,
            QMethodDefinition methodHandle,
            RuntimeTypeHandle[] genericMethodTypeArgumentHandles,
            MethodBase methodInfo,
            ref MethodSignatureComparer methodSignatureComparer,
            CanonicalFormKind canonFormKind)
        {
            MethodInvokeMetadata methodInvokeMetadata;

            if (!TypeLoaderEnvironment.TryGetMethodInvokeMetadata(
                declaringTypeHandle,
                methodHandle,
                genericMethodTypeArgumentHandles,
                ref methodSignatureComparer,
                canonFormKind,
                out methodInvokeMetadata))
            {
                // Method invoke info not found
                return null;
            }

            if ((methodInvokeMetadata.InvokeTableFlags & InvokeTableFlags.CallingConventionMask) != 0)
            {
                // MethodInvokeInfo found, but it references a method with a native calling convention. 
                return null;
            }

            if ((methodInvokeMetadata.InvokeTableFlags & InvokeTableFlags.IsUniversalCanonicalEntry) != 0)
            {
                // Wrap the method entry point in a calling convention converter thunk if it's a universal canonical implementation
                Debug.Assert(canonFormKind == CanonicalFormKind.Universal);
                methodInvokeMetadata.MethodEntryPoint = GetCallingConventionConverterForMethodEntrypoint(
                    methodHandle.NativeFormatReader,
                    declaringTypeHandle,
                    methodInvokeMetadata.MethodEntryPoint,
                    methodInvokeMetadata.DictionaryComponent,
                    methodInfo,
                    methodHandle.NativeFormatHandle);
            }

            if (methodInvokeMetadata.MethodEntryPoint != methodInvokeMetadata.RawMethodEntryPoint &&
                !FunctionPointerOps.IsGenericMethodPointer(methodInvokeMetadata.MethodEntryPoint))
            {
                // Keep track of the raw method entrypoints for the cases where they get wrapped into a calling convention converter thunk.
                // This is needed for reverse lookups, like in TryGetMethodForOriginalLdFtnResult
                Debug.Assert(canonFormKind == CanonicalFormKind.Universal);
                lock (_callConverterWrappedMethodEntrypoints)
                {
                    _callConverterWrappedMethodEntrypoints.LookupOrAdd(methodInvokeMetadata.MethodEntryPoint, new MethodTargetAndDictionary
                    {
                        TargetPointer = methodInvokeMetadata.RawMethodEntryPoint,
                        DictionaryPointer = methodInvokeMetadata.DictionaryComponent
                    });
                }
            }

            RuntimeTypeHandle[] dynInvokeMethodArgs = GetDynamicInvokeInstantiationArguments(methodInfo);

            IntPtr dynamicInvokeMethod;
            IntPtr dynamicInvokeMethodGenericDictionary;
            if ((methodInvokeMetadata.InvokeTableFlags & InvokeTableFlags.NeedsParameterInterpretation) != 0)
            {
                dynamicInvokeMethod = GetDynamicMethodInvokerThunk(dynInvokeMethodArgs, methodInfo);
                dynamicInvokeMethodGenericDictionary = IntPtr.Zero;
            }
            else
            {
                GetDynamicMethodInvokeMethodInfo(
                    methodInvokeMetadata.MappingTableModule,
                    methodInvokeMetadata.DynamicInvokeCookie,
                    dynInvokeMethodArgs,
                    out dynamicInvokeMethod,
                    out dynamicInvokeMethodGenericDictionary);
            }

            IntPtr resolver = IntPtr.Zero;
            if ((methodInvokeMetadata.InvokeTableFlags & InvokeTableFlags.HasVirtualInvoke) != 0)
            {
                resolver = TryGetVirtualResolveData(ModuleList.Instance.GetModuleInfoForMetadataReader(methodHandle.NativeFormatReader),
                    declaringTypeHandle, methodHandle, genericMethodTypeArgumentHandles,
                    ref methodSignatureComparer);

                // Unable to find virtual resolution information, cannot return valid MethodInvokeInfo
                if (resolver == IntPtr.Zero)
                    return null;
            }

            var methodInvokeInfo = new MethodInvokeInfo
            {
                LdFtnResult = methodInvokeMetadata.MethodEntryPoint,
                DynamicInvokeMethod = dynamicInvokeMethod,
                DynamicInvokeGenericDictionary = dynamicInvokeMethodGenericDictionary,
                MethodInfo = methodInfo,
                VirtualResolveData = resolver,
            };
            return methodInvokeInfo;
        }

        private static IntPtr GetCallingConventionConverterForMethodEntrypoint(MetadataReader metadataReader, RuntimeTypeHandle declaringType, IntPtr methodEntrypoint, IntPtr dictionary, MethodBase methodBase, MethodHandle mdHandle)
        {
            MethodParametersInfo methodParamsInfo = new MethodParametersInfo(metadataReader, methodBase, mdHandle);

            bool[] forcedByRefParameters;
            if (methodParamsInfo.RequiresCallingConventionConverter(out forcedByRefParameters))
            {
                RuntimeTypeHandle[] parameterTypeHandles = methodParamsInfo.ReturnTypeAndParameterTypeHandles.ToArray();
                bool[] byRefParameters = methodParamsInfo.ReturnTypeAndParametersByRefFlags;

                Debug.Assert(parameterTypeHandles.Length == byRefParameters.Length && byRefParameters.Length == forcedByRefParameters.Length);

                bool isMethodOnStructure = RuntimeAugments.IsValueType(declaringType);

                return CallConverterThunk.MakeThunk(
                    (methodBase.IsGenericMethod || isMethodOnStructure ? ThunkKind.StandardToGenericInstantiating : ThunkKind.StandardToGenericInstantiatingIfNotHasThis),
                    methodEntrypoint,
                    dictionary,
                    !methodBase.IsStatic,
                    parameterTypeHandles,
                    byRefParameters,
                    forcedByRefParameters);
            }
            else
            {
                return FunctionPointerOps.GetGenericMethodFunctionPointer(methodEntrypoint, dictionary);
            }
        }

        private RuntimeTypeHandle GetExactDeclaringType(RuntimeTypeHandle dstType, RuntimeTypeHandle srcType)
        {
            // The fact that for generic types we rely solely on the template type in the mapping table causes
            // trouble for lookups from method pointer to the declaring type and method metadata handle.

            // Suppose we have following code:
            // class Base<T> { void Frob() { } }
            // class Derived<T> : Base<T> { }
            // Let's pick Base<object>, Derived<object> as the template.
            // Now if someone calls TryGetMethodForOriginalLdFtnResult with a pointer to the Frob method and a RuntimeTypeHandle
            // of the Derived<string> object instance, we are expected to return the metadata handle for Frob with *Base*<string>
            // as the declaring type. The table obviously only has an entry for Frob with Base<object>.

            // This method needs to return "true" and "Base<string>" for cases like this.

            RuntimeTypeHandle dstTypeDef = GetTypeDefinition(dstType);

            while (!srcType.IsNull())
            {
                if (RuntimeAugments.IsAssignableFrom(dstType, srcType))
                {
                    return dstType;
                }

                if (!dstTypeDef.IsNull() && RuntimeAugments.IsGenericType(srcType))
                {
                    RuntimeTypeHandle srcTypeDef = GetTypeDefinition(srcType);;

                    // Compare TypeDefs. We don't look at the generic components. We already know that the right type
                    // to return must be somewhere in the inheritance chain.
                    if (dstTypeDef.Equals(srcTypeDef))
                    {
                        // Return the *other* type handle since dstType is instantiated over different arguments
                        return srcType;
                    }
                }

                if (!RuntimeAugments.TryGetBaseType(srcType, out srcType))
                {
                    break;
                }
            }

            Debug.Assert(false);
            return default(RuntimeTypeHandle);
        }

        private struct FunctionPointerOffsetPair : IComparable<FunctionPointerOffsetPair>
        {
            public FunctionPointerOffsetPair(IntPtr functionPointer, uint offset)
            {
                FunctionPointer = functionPointer;
                Offset = offset;
            }

            public int CompareTo(FunctionPointerOffsetPair other)
            {
                unsafe
                {
                    void* fptr = FunctionPointer.ToPointer();
                    void* otherFptr = other.FunctionPointer.ToPointer();

                    if (fptr < otherFptr)
                        return -1;
                    else if (fptr == otherFptr)
                        return Offset.CompareTo(other.Offset);
                    else
                        return 1;
                }
            }

            public readonly IntPtr FunctionPointer;
            public readonly uint Offset;
        }

        private struct FunctionPointersToOffsets
        {
            public FunctionPointerOffsetPair[] Data;

            public bool TryGetOffsetsRange(IntPtr functionPointer, out int firstParserOffsetIndex, out int lastParserOffsetIndex)
            {
                firstParserOffsetIndex = -1;
                lastParserOffsetIndex = -1;

                if (Data == null)
                    return false;

                int binarySearchIndex = Array.BinarySearch(Data, new FunctionPointerOffsetPair(functionPointer, 0));

                // Array.BinarySearch will return either a positive number which is the first index in a range
                // or a negative number which is the bitwise complement of the start of the range
                // or a negative number which doesn't correspond to the range at all.
                if (binarySearchIndex < 0)
                    binarySearchIndex = ~binarySearchIndex;

                if (binarySearchIndex >= Data.Length || Data[binarySearchIndex].FunctionPointer != functionPointer)
                    return false;

                // binarySearchIndex now contains the index of the start of a range of matching function pointers and offsets
                firstParserOffsetIndex = binarySearchIndex;
                lastParserOffsetIndex = binarySearchIndex;
                while ((lastParserOffsetIndex < (Data.Length - 1)) && Data[lastParserOffsetIndex + 1].FunctionPointer == functionPointer)
                {
                    lastParserOffsetIndex++;
                }
                return true;
            }
        }

        // ldftn reverse lookup hash. Must be cleared and reset if the module list changes. (All sets to
        // this variable must happen under a lock)
        private volatile KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets>[] _ldftnReverseLookup = null;

        private KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets>[] GetLdFtnReverseLookups()
        {
            KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets>[] ldFtnReverseLookup = _ldftnReverseLookup;

            if (ldFtnReverseLookup != null)
                return ldFtnReverseLookup;
            else
            {
                lock (this)
                {
                    ldFtnReverseLookup = _ldftnReverseLookup;

                    // double checked lock, safe due to use of volatile on s_ldftnReverseHashes
                    if (ldFtnReverseLookup != null)
                        return ldFtnReverseLookup;

                    // FUTURE: add a module load callback to invalidate this cache if a new module is loaded.
                    while (true)
                    {
                        int size = 0;
                        foreach (NativeFormatModuleInfo module in ModuleList.EnumerateModules())
                        {
                            size++;
                        }

                        ldFtnReverseLookup = new KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets>[size];
                        int index = 0;
                        foreach (NativeFormatModuleInfo module in ModuleList.EnumerateModules())
                        {
                            // If the module list changes during execution of this code, rebuild from scratch
                            if (index >= ldFtnReverseLookup.Length)
                                continue;

                            ldFtnReverseLookup[index] = new KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets>(module, ComputeLdftnReverseLookupLookup(module));
                            index++;
                        }

                        // unless we need to repeat the module enumeration, only execute the body of this while loop once.
                        break;
                    }

                    _ldftnReverseLookup = ldFtnReverseLookup;
                    return ldFtnReverseLookup;
                }
            }
        }

        internal unsafe bool TryGetMethodForOriginalLdFtnResult(IntPtr originalLdFtnResult, ref RuntimeTypeHandle declaringTypeHandle, out QMethodDefinition methodHandle, out RuntimeTypeHandle[] genericMethodTypeArgumentHandles)
        {
            IntPtr canonOriginalLdFtnResult;
            IntPtr instantiationArgument;
            if (FunctionPointerOps.IsGenericMethodPointer(originalLdFtnResult))
            {
                GenericMethodDescriptor* realTargetData = FunctionPointerOps.ConvertToGenericDescriptor(originalLdFtnResult);
                canonOriginalLdFtnResult = RuntimeAugments.GetCodeTarget(realTargetData->MethodFunctionPointer);
                instantiationArgument = realTargetData->InstantiationArgument;
            }
            else
            {
                bool isCallConverterWrappedEntrypoint;
                MethodTargetAndDictionary callConverterWrappedEntrypoint;
                lock (_callConverterWrappedMethodEntrypoints)
                {
                    isCallConverterWrappedEntrypoint = _callConverterWrappedMethodEntrypoints.TryGetValue(originalLdFtnResult, out callConverterWrappedEntrypoint);
                }

                if (isCallConverterWrappedEntrypoint)
                {
                    canonOriginalLdFtnResult = callConverterWrappedEntrypoint.TargetPointer;
                    instantiationArgument = callConverterWrappedEntrypoint.DictionaryPointer;
                }
                else
                {
                    canonOriginalLdFtnResult = RuntimeAugments.GetCodeTarget(originalLdFtnResult);
                    instantiationArgument = IntPtr.Zero;
                }
            }

            foreach (KeyValuePair<NativeFormatModuleInfo, FunctionPointersToOffsets> perModuleLookup in GetLdFtnReverseLookups())
            {
                int startIndex;
                int endIndex;

                if (perModuleLookup.Value.TryGetOffsetsRange(canonOriginalLdFtnResult, out startIndex, out endIndex))
                {
                    for (int curIndex = startIndex; curIndex <= endIndex; curIndex++)
                    {
                        uint parserOffset = perModuleLookup.Value.Data[curIndex].Offset;
                        if (TryGetMethodForOriginalLdFtnResult_Inner(perModuleLookup.Key, canonOriginalLdFtnResult, instantiationArgument, parserOffset, ref declaringTypeHandle, out methodHandle, out genericMethodTypeArgumentHandles))
                            return true;
                    }
                }
            }

            methodHandle = default(QMethodDefinition);
            genericMethodTypeArgumentHandles = null;
            return false;
        }

        private FunctionPointersToOffsets ComputeLdftnReverseLookupLookup(NativeFormatModuleInfo mappingTableModule)
        {
            FunctionPointersToOffsets functionPointerToOffsetInInvokeMap = new FunctionPointersToOffsets();

            NativeReader invokeMapReader;
            if (!TryGetNativeReaderForBlob(mappingTableModule, ReflectionMapBlob.InvokeMap, out invokeMapReader))
            {
                return functionPointerToOffsetInInvokeMap;
            }

            ExternalReferencesTable externalReferences = default(ExternalReferencesTable);
            externalReferences.InitializeCommonFixupsTable(mappingTableModule);

            NativeParser invokeMapParser = new NativeParser(invokeMapReader, 0);
            NativeHashtable invokeHashtable = new NativeHashtable(invokeMapParser);

            LowLevelList<FunctionPointerOffsetPair> functionPointers = new LowLevelList<FunctionPointerOffsetPair>();

            var lookup = invokeHashtable.EnumerateAllEntries();
            NativeParser entryParser;
            while (!(entryParser = lookup.GetNext()).IsNull)
            {
                uint parserOffset = entryParser.Offset;
                Debug.Assert(entryParser.Reader == invokeMapParser.Reader);

                InvokeTableFlags entryFlags = (InvokeTableFlags)entryParser.GetUnsigned();

                bool hasEntrypoint = ((entryFlags & InvokeTableFlags.HasEntrypoint) != 0);
                if (!hasEntrypoint)
                    continue;

                uint entryMethodHandleOrNameAndSigRaw = entryParser.GetUnsigned();
                uint entryDeclaringTypeRaw = entryParser.GetUnsigned();

                IntPtr entryMethodEntrypoint = externalReferences.GetFunctionPointerFromIndex(entryParser.GetUnsigned());
                functionPointers.Add(new FunctionPointerOffsetPair(entryMethodEntrypoint, parserOffset));
            }

            functionPointerToOffsetInInvokeMap.Data = functionPointers.ToArray();
            Array.Sort(functionPointerToOffsetInInvokeMap.Data);

            return functionPointerToOffsetInInvokeMap;
        }

        private unsafe bool TryGetMethodForOriginalLdFtnResult_Inner(NativeFormatModuleInfo mappingTableModule, IntPtr canonOriginalLdFtnResult, IntPtr instantiationArgument, uint parserOffset, ref RuntimeTypeHandle declaringTypeHandle, out QMethodDefinition methodHandle, out RuntimeTypeHandle[] genericMethodTypeArgumentHandles)
        {
            methodHandle = default(QMethodDefinition);
            genericMethodTypeArgumentHandles = null;

            NativeReader invokeMapReader;
            if (!TryGetNativeReaderForBlob(mappingTableModule, ReflectionMapBlob.InvokeMap, out invokeMapReader))
            {
                // This should have succeeded otherwise, how did we get a parser offset as an input parameter?
                Debug.Assert(false);
                return false;
            }

            ExternalReferencesTable externalReferences = default(ExternalReferencesTable);
            externalReferences.InitializeCommonFixupsTable(mappingTableModule);

            NativeParser entryParser = new NativeParser(invokeMapReader, parserOffset);

            InvokeTableFlags entryFlags = (InvokeTableFlags)entryParser.GetUnsigned();

            // If the passed in method was a fat function pointer, but the entry in the mapping table doesn't need
            // an instantiation argument (or the other way around), trivially reject it.
            if ((instantiationArgument == IntPtr.Zero) != ((entryFlags & InvokeTableFlags.RequiresInstArg) == 0))
                return false;

            Debug.Assert((entryFlags & InvokeTableFlags.HasEntrypoint) != 0);

            uint entryMethodHandleOrNameAndSigRaw = entryParser.GetUnsigned();
            uint entryDeclaringTypeRaw = entryParser.GetUnsigned();

            IntPtr entryMethodEntrypoint = externalReferences.GetFunctionPointerFromIndex(entryParser.GetUnsigned());

            if ((entryFlags & InvokeTableFlags.NeedsParameterInterpretation) == 0)
                entryParser.GetUnsigned(); // skip dynamic invoke cookie

            Debug.Assert(entryMethodEntrypoint == canonOriginalLdFtnResult);

            if ((entryFlags & InvokeTableFlags.RequiresInstArg) == 0 && declaringTypeHandle.IsNull())
                declaringTypeHandle = externalReferences.GetRuntimeTypeHandleFromIndex(entryDeclaringTypeRaw);

            if ((entryFlags & InvokeTableFlags.IsGenericMethod) != 0)
            {
                if ((entryFlags & InvokeTableFlags.RequiresInstArg) != 0)
                {
                    MethodNameAndSignature dummyNameAndSignature;
                    bool success = TypeLoaderEnvironment.Instance.TryGetGenericMethodComponents(instantiationArgument, out declaringTypeHandle, out dummyNameAndSignature, out genericMethodTypeArgumentHandles);
                    Debug.Assert(success);
                }
                else
                    genericMethodTypeArgumentHandles = GetTypeSequence(ref externalReferences, ref entryParser);
            }
            else
            {
                genericMethodTypeArgumentHandles = null;
                if ((entryFlags & InvokeTableFlags.RequiresInstArg) != 0)
                    declaringTypeHandle = RuntimeAugments.CreateRuntimeTypeHandle(instantiationArgument);
            }

            RuntimeTypeHandle entryType = externalReferences.GetRuntimeTypeHandleFromIndex(entryDeclaringTypeRaw);
            declaringTypeHandle = GetExactDeclaringType(entryType, declaringTypeHandle);

            if ((entryFlags & InvokeTableFlags.HasMetadataHandle) != 0)
            {
                RuntimeTypeHandle declaringTypeHandleDefinition = GetTypeDefinition(declaringTypeHandle);
                QTypeDefinition qTypeDefinition;
                if (!TryGetMetadataForNamedType(declaringTypeHandleDefinition, out qTypeDefinition))
                {
                    RuntimeExceptionHelpers.FailFast("Unable to resolve named type to having a metadata reader");
                }
                
                MethodHandle nativeFormatMethodHandle = 
                    (((int)HandleType.Method << 24) | (int)entryMethodHandleOrNameAndSigRaw).AsMethodHandle();

                methodHandle = new QMethodDefinition(qTypeDefinition.NativeFormatReader, nativeFormatMethodHandle); 
            }
            else
            {
                uint nameAndSigOffset = externalReferences.GetExternalNativeLayoutOffset(entryMethodHandleOrNameAndSigRaw);
                MethodNameAndSignature nameAndSig;
                if (!TypeLoaderEnvironment.Instance.TryGetMethodNameAndSignatureFromNativeLayoutOffset(mappingTableModule.Handle, nameAndSigOffset, out nameAndSig))
                {
                    Debug.Assert(false);
                    return false;
                }

                if (!TypeLoaderEnvironment.Instance.TryGetMetadataForTypeMethodNameAndSignature(declaringTypeHandle, nameAndSig, out methodHandle))
                {
                    Debug.Assert(false);
                    return false;
                }
            }

            return true;
        }

        public sealed override FieldAccessor TryGetFieldAccessor(
            MetadataReader metadataReader,
            RuntimeTypeHandle declaringTypeHandle,
            RuntimeTypeHandle fieldTypeHandle,
            FieldHandle fieldHandle)
        {
            FieldAccessMetadata fieldAccessMetadata;

            if (!TypeLoaderEnvironment.TryGetFieldAccessMetadata(
                metadataReader,
                declaringTypeHandle,
                fieldHandle,
                out fieldAccessMetadata))
            {
                return null;
            }

            switch (fieldAccessMetadata.Flags & FieldTableFlags.StorageClass)
            {
                case FieldTableFlags.Instance:
                    {
                        int fieldOffsetDelta = RuntimeAugments.IsValueType(declaringTypeHandle) ? IntPtr.Size : 0;
            
                        return RuntimeAugments.IsValueType(fieldTypeHandle) ?
                            (FieldAccessor)new ValueTypeFieldAccessorForInstanceFields(
                                fieldAccessMetadata.Offset + fieldOffsetDelta, declaringTypeHandle, fieldTypeHandle) :
                            (FieldAccessor)new ReferenceTypeFieldAccessorForInstanceFields(
                                fieldAccessMetadata.Offset + fieldOffsetDelta, declaringTypeHandle, fieldTypeHandle);
                    }

                case FieldTableFlags.Static:
                    {
                        int fieldOffset;
                        IntPtr staticsBase;
                        bool isGcStatic = ((fieldAccessMetadata.Flags & FieldTableFlags.IsGcSection) != 0);

                        if (RuntimeAugments.IsGenericType(declaringTypeHandle))
                        {
                            unsafe
                            {
                                fieldOffset = fieldAccessMetadata.Offset;
                                staticsBase = isGcStatic ?
                                    *(IntPtr*)TypeLoaderEnvironment.Instance.TryGetGcStaticFieldData(declaringTypeHandle) :
                                    *(IntPtr*)TypeLoaderEnvironment.Instance.TryGetNonGcStaticFieldData(declaringTypeHandle);
                            }
                        }
                        else
                        {
                            Debug.Assert((fieldAccessMetadata.Flags & FieldTableFlags.IsUniversalCanonicalEntry) == 0);
#if CORERT
                            if (isGcStatic)
                            {
                                fieldOffset = fieldAccessMetadata.Offset;
                                staticsBase = fieldAccessMetadata.Cookie;
                            }
                            else
                            {
                                // The fieldAccessMetadata.Cookie value points directly to the field's data. We'll use that as the 'staticsBase'
                                // and just use a field offset of zero.
                                fieldOffset = 0;
                                staticsBase = fieldAccessMetadata.Cookie;
                            }
#else
                            // The fieldAccessMetadata.Offset value is not really a field offset, but a static field RVA. We'll use the
                            // field's address as a 'staticsBase', and just use a field offset of zero.
                            fieldOffset = 0;
                            staticsBase = TypeLoaderEnvironment.RvaToNonGenericStaticFieldAddress(fieldAccessMetadata.MappingTableModule, fieldAccessMetadata.Offset);
#endif
                        }

                        IntPtr cctorContext = TryGetStaticClassConstructionContext(declaringTypeHandle);

                        return RuntimeAugments.IsValueType(fieldTypeHandle) ?
                            (FieldAccessor)new ValueTypeFieldAccessorForStaticFields(cctorContext, staticsBase, fieldOffset, isGcStatic, fieldTypeHandle) :
                            (FieldAccessor)new ReferenceTypeFieldAccessorForStaticFields(cctorContext, staticsBase, fieldOffset, isGcStatic, fieldTypeHandle);
                    }

                case FieldTableFlags.ThreadStatic:
                    if (fieldAccessMetadata.Cookie == IntPtr.Zero)
                    {
                        return RuntimeAugments.IsValueType(fieldTypeHandle) ?
                            (FieldAccessor)new ValueTypeFieldAccessorForUniversalThreadStaticFields(
                                TryGetStaticClassConstructionContext(declaringTypeHandle),
                                declaringTypeHandle,
                                fieldAccessMetadata.Offset,
                                fieldTypeHandle) :
                            (FieldAccessor)new ReferenceTypeFieldAccessorForUniversalThreadStaticFields(
                                TryGetStaticClassConstructionContext(declaringTypeHandle),
                                declaringTypeHandle,
                                fieldAccessMetadata.Offset,
                                fieldTypeHandle);
                    }
                    else
                    {
                        return RuntimeAugments.IsValueType(fieldTypeHandle) ?
                            (FieldAccessor)new ValueTypeFieldAccessorForThreadStaticFields(TryGetStaticClassConstructionContext(declaringTypeHandle), declaringTypeHandle, fieldAccessMetadata.Cookie, fieldTypeHandle) :
                            (FieldAccessor)new ReferenceTypeFieldAccessorForThreadStaticFields(TryGetStaticClassConstructionContext(declaringTypeHandle), declaringTypeHandle, fieldAccessMetadata.Cookie, fieldTypeHandle);
                    }
            }

            return null;
        }

        //
        // This resolves RuntimeMethodHandles for methods declared on non-generic types (declaringTypeHandle is an output of this method.)
        //
        public unsafe sealed override bool TryGetMethodFromHandle(RuntimeMethodHandle runtimeMethodHandle, out RuntimeTypeHandle declaringTypeHandle, out QMethodDefinition methodHandle, out RuntimeTypeHandle[] genericMethodTypeArgumentHandles)
        {
            MethodNameAndSignature nameAndSignature;
            methodHandle = default(QMethodDefinition);
            if (!TypeLoaderEnvironment.Instance.TryGetRuntimeMethodHandleComponents(runtimeMethodHandle, out declaringTypeHandle, out nameAndSignature, out genericMethodTypeArgumentHandles))
                return false;

            return TypeLoaderEnvironment.Instance.TryGetMetadataForTypeMethodNameAndSignature(declaringTypeHandle, nameAndSignature, out methodHandle);
        }

        //
        // This resolves RuntimeMethodHandles for methods declared on generic types (declaringTypeHandle is an input of this method.)
        //
        public sealed override bool TryGetMethodFromHandleAndType(RuntimeMethodHandle runtimeMethodHandle, RuntimeTypeHandle declaringTypeHandle, out QMethodDefinition methodHandle, out RuntimeTypeHandle[] genericMethodTypeArgumentHandles)
        {
            RuntimeTypeHandle dummy;
            return TryGetMethodFromHandle(runtimeMethodHandle, out dummy, out methodHandle, out genericMethodTypeArgumentHandles);
        }

        //
        // This resolves RuntimeFieldHandles for fields declared on non-generic types (declaringTypeHandle is an output of this method.)
        //
        public unsafe sealed override bool TryGetFieldFromHandle(RuntimeFieldHandle runtimeFieldHandle, out RuntimeTypeHandle declaringTypeHandle, out FieldHandle fieldHandle)
        {
            declaringTypeHandle = default(RuntimeTypeHandle);
            fieldHandle = default(FieldHandle);

            string fieldName;
            if (!TypeLoaderEnvironment.Instance.TryGetRuntimeFieldHandleComponents(runtimeFieldHandle, out declaringTypeHandle, out fieldName))
                return false;

            QTypeDefinition qTypeDefinition;
            RuntimeTypeHandle metadataLookupTypeHandle = GetTypeDefinition(declaringTypeHandle);

            if (!TryGetMetadataForNamedType(metadataLookupTypeHandle, out qTypeDefinition))
                return false;

            // TODO! Handle ecma style types
            MetadataReader reader = qTypeDefinition.NativeFormatReader;
            TypeDefinitionHandle typeDefinitionHandle = qTypeDefinition.NativeFormatHandle;

            TypeDefinition typeDefinition = typeDefinitionHandle.GetTypeDefinition(reader);
            foreach (FieldHandle fh in typeDefinition.Fields)
            {
                Field field = fh.GetField(reader);
                if (field.Name.StringEquals(fieldName, reader))
                {
                    fieldHandle = fh;
                    return true;
                }
            }

            return false;
        }

        //
        // This resolves RuntimeFieldHandles for fields declared on generic types (declaringTypeHandle is an input of this method.)
        //
        public sealed override bool TryGetFieldFromHandleAndType(RuntimeFieldHandle runtimeFieldHandle, RuntimeTypeHandle declaringTypeHandle, out FieldHandle fieldHandle)
        {
            RuntimeTypeHandle dummy;
            return TryGetFieldFromHandle(runtimeFieldHandle, out dummy, out fieldHandle);
        }

        /// <summary>
        /// Locate the static constructor context given the runtime type handle (EEType) for the type in question.
        /// </summary>
        /// <param name="typeHandle">EEtype of the type to look up</param>
        internal unsafe IntPtr TryGetStaticClassConstructionContext(RuntimeTypeHandle typeHandle)
        {
            return TypeLoaderEnvironment.TryGetStaticClassConstructionContext(typeHandle);
        }

        private struct MethodParametersInfo
        {
            private MetadataReader _metadataReader;
            private MethodBase _methodBase;
            private MethodHandle _methodHandle;

            private Handle[] _returnTypeAndParametersHandlesCache;
            private Type[] _returnTypeAndParametersTypesCache;

            public MethodParametersInfo(MethodBase methodBase)
            {
                _metadataReader = null;
                _methodBase = methodBase;
                _methodHandle = default(MethodHandle);
                _returnTypeAndParametersHandlesCache = null;
                _returnTypeAndParametersTypesCache = null;
            }

            public MethodParametersInfo(MetadataReader metadataReader, MethodBase methodBase, MethodHandle methodHandle)
            {
                _metadataReader = metadataReader;
                _methodBase = methodBase;
                _methodHandle = methodHandle;
                _returnTypeAndParametersHandlesCache = null;
                _returnTypeAndParametersTypesCache = null;
            }

            public LowLevelList<RuntimeTypeHandle> ParameterTypeHandles
            {
                get
                {
                    ParameterInfo[] parameters = _methodBase.GetParametersNoCopy();
                    LowLevelList<RuntimeTypeHandle> result = new LowLevelList<RuntimeTypeHandle>(parameters.Length);

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Type parameterType = parameters[i].ParameterType;

                        // If the parameter is a pointer type, use IntPtr. Else use the actual parameter type.
                        if (parameterType.IsPointer)
                            result.Add(CommonRuntimeTypes.IntPtr.TypeHandle);
                        else if (parameterType.IsByRef)
                            result.Add(parameterType.GetElementType().TypeHandle);
                        else if (parameterType.GetTypeInfo().IsEnum && !parameters[i].HasDefaultValue)
                            result.Add(Enum.GetUnderlyingType(parameterType).TypeHandle);
                        else
                            result.Add(parameterType.TypeHandle);
                    }

                    return result;
                }
            }

            public LowLevelList<RuntimeTypeHandle> ReturnTypeAndParameterTypeHandles
            {
                get
                {
                    LowLevelList<RuntimeTypeHandle> result = ParameterTypeHandles;

                    MethodInfo reflectionMethodInfo = _methodBase as MethodInfo;
                    Type returnType = reflectionMethodInfo != null ? reflectionMethodInfo.ReturnType : CommonRuntimeTypes.Void;
                    result.Insert(0, returnType.TypeHandle);

                    return result;
                }
            }

            public bool[] ReturnTypeAndParametersByRefFlags
            {
                get
                {
                    ParameterInfo[] parameters = _methodBase.GetParametersNoCopy();
                    bool[] result = new bool[parameters.Length + 1];

                    MethodInfo reflectionMethodInfo = _methodBase as MethodInfo;
                    Type returnType = reflectionMethodInfo != null ? reflectionMethodInfo.ReturnType : CommonRuntimeTypes.Void;
                    result[0] = returnType.IsByRef;

                    for (int i = 0; i < parameters.Length; i++)
                        result[i + 1] = parameters[i].ParameterType.IsByRef;

                    return result;
                }
            }

            public bool RequiresCallingConventionConverter(out bool[] forcedByRefParams)
            {
                Handle[] handles = null;
                Type[] types = null;
                GetReturnTypeAndParameterTypesAndMDHandles(ref handles, ref types);

                // Compute whether any of the parameters have generic vars in their signatures ...
                bool requiresCallingConventionConverter = false;
                forcedByRefParams = new bool[handles.Length];
                for (int i = 0; i < handles.Length; i++)
                    if ((forcedByRefParams[i] = TypeSignatureHasVarsNeedingCallingConventionConverter(handles[i], types[i], isTopLevelParameterType:true)))
                        requiresCallingConventionConverter = true;

                return requiresCallingConventionConverter;
            }

            private void GetReturnTypeAndParameterTypesAndMDHandles(ref Handle[] handles, ref Type[] types)
            {
                if (_returnTypeAndParametersTypesCache == null)
                {
                    Debug.Assert(_metadataReader != null && !_methodHandle.Equals(default(MethodHandle)));

                    _returnTypeAndParametersHandlesCache = new Handle[_methodBase.GetParametersNoCopy().Length + 1];
                    _returnTypeAndParametersTypesCache = new Type[_methodBase.GetParametersNoCopy().Length + 1];

                    MethodSignature signature = _methodHandle.GetMethod(_metadataReader).Signature.GetMethodSignature(_metadataReader);

                    // Check the return type for generic vars
                    MethodInfo reflectionMethodInfo = _methodBase as MethodInfo;
                    _returnTypeAndParametersTypesCache[0] = reflectionMethodInfo != null ? reflectionMethodInfo.ReturnType : CommonRuntimeTypes.Void;
                    _returnTypeAndParametersHandlesCache[0] = signature.ReturnType;

                    // Check the method parameters for generic vars
                    int index = 1;
                    foreach (Handle paramSigHandle in signature.Parameters)
                    {
                        _returnTypeAndParametersHandlesCache[index] = paramSigHandle;
                        _returnTypeAndParametersTypesCache[index] = _methodBase.GetParametersNoCopy()[index - 1].ParameterType;
                        index++;
                    }
                }

                handles = _returnTypeAndParametersHandlesCache;
                types = _returnTypeAndParametersTypesCache;
                Debug.Assert(handles != null && types != null);
            }

            /// <summary>
            /// IF THESE SEMANTICS EVER CHANGE UPDATE THE LOGIC WHICH DEFINES THIS BEHAVIOR IN 
            /// THE DYNAMIC TYPE LOADER AS WELL AS THE COMPILER. 
            ///
            /// Parameter's are considered to have type layout dependent on their generic instantiation
            /// if the type of the parameter in its signature is a type variable, or if the type is a generic 
            /// structure which meets 2 characteristics:
            /// 1. Structure size/layout is affected by the size/layout of one or more of its generic parameters
            /// 2. One or more of the generic parameters is a type variable, or a generic structure which also recursively
            ///    would satisfy constraint 2. (Note, that in the recursion case, whether or not the structure is affected
            ///    by the size/layout of its generic parameters is not investigated.)
            ///    
            /// Examples parameter types, and behavior.
            /// 
            /// T -> true
            /// List<T> -> false
            /// StructNotDependentOnArgsForSize<T> -> false
            /// GenStructDependencyOnArgsForSize<T> -> true
            /// StructNotDependentOnArgsForSize<GenStructDependencyOnArgsForSize<T>> -> true
            /// StructNotDependentOnArgsForSize<GenStructDependencyOnArgsForSize<List<T>>>> -> false
            /// 
            /// Example non-parameter type behavior
            /// T -> true
            /// List<T> -> false
            /// StructNotDependentOnArgsForSize<T> -> *true*
            /// GenStructDependencyOnArgsForSize<T> -> true
            /// StructNotDependentOnArgsForSize<GenStructDependencyOnArgsForSize<T>> -> true
            /// StructNotDependentOnArgsForSize<GenStructDependencyOnArgsForSize<List<T>>>> -> false
            /// </summary>
            private bool TypeSignatureHasVarsNeedingCallingConventionConverter(Handle typeHandle, Type type, bool isTopLevelParameterType)
            {
                if (typeHandle.HandleType == HandleType.TypeSpecification)
                {
                    TypeSpecification typeSpec = typeHandle.ToTypeSpecificationHandle(_metadataReader).GetTypeSpecification(_metadataReader);
                    Handle sigHandle = typeSpec.Signature;
                    HandleType sigHandleType = sigHandle.HandleType;
                    switch (sigHandleType)
                    {
                        case HandleType.TypeVariableSignature:
                        case HandleType.MethodTypeVariableSignature:
                            return true;

                        case HandleType.TypeInstantiationSignature:
                            {
                                Debug.Assert(type.IsConstructedGenericType);
                                TypeInstantiationSignature sig = sigHandle.ToTypeInstantiationSignatureHandle(_metadataReader).GetTypeInstantiationSignature(_metadataReader);

                                if (RuntimeAugments.IsValueType(type.TypeHandle))
                                {
                                    // This generic type is a struct (its base type is System.ValueType)
                                    int genArgIndex = 0;
                                    bool needsCallingConventionConverter = false;
                                    foreach (Handle genericTypeArgumentHandle in sig.GenericTypeArguments)
                                    {
                                        if (TypeSignatureHasVarsNeedingCallingConventionConverter(genericTypeArgumentHandle, type.GenericTypeArguments[genArgIndex++], isTopLevelParameterType:false))
                                        {
                                            needsCallingConventionConverter = true;
                                            break;
                                        }
                                    }

                                    if (needsCallingConventionConverter)
                                    {
                                        if (!isTopLevelParameterType)
                                            return true;

                                        if (!TypeLoaderEnvironment.Instance.TryComputeHasInstantiationDeterminedSize(type.TypeHandle, out needsCallingConventionConverter))
                                            RuntimeExceptionHelpers.FailFast("Unable to setup calling convention converter correctly");
                                        return needsCallingConventionConverter;
                                    }
                                }
                            }
                            return false;
                    }
                }

                return false;
            }
        }
    }
}

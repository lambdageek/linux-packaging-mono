// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Internal.Runtime;
using Internal.Runtime.Augments;
using Internal.Runtime.TypeLoader;

using Internal.Metadata.NativeFormat;

using Internal.Reflection.Core;
using Internal.Reflection.Core.Execution;
using Internal.Reflection.Execution.MethodInvokers;
using Internal.NativeFormat;

namespace Internal.Reflection.Execution
{
    //==========================================================================================================
    // These ExecutionEnvironment entrypoints implement support for manifest resource streams on the Assembly class.
    //==========================================================================================================
    internal sealed partial class ExecutionEnvironmentImplementation : ExecutionEnvironment
    {
        public sealed override ManifestResourceInfo GetManifestResourceInfo(Assembly assembly, String resourceName)
        {
            throw new PlatformNotSupportedException();
        }

        public sealed override String[] GetManifestResourceNames(Assembly assembly)
        {
            LowLevelList<ResourceInfo> resourceInfos = GetExtractedResources(assembly);
            String[] names = new String[resourceInfos.Count];
            for (int i = 0; i < resourceInfos.Count; i++)
            {
                names[i] = resourceInfos[i].Name;
            }
            return names;
        }

        public sealed override Stream GetManifestResourceStream(Assembly assembly, String name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

#if ENABLE_WINRT
            Stream resultFromFile = ReadFileFromAppDirectory(name);
            if (resultFromFile != null)
                return resultFromFile;
#endif // ENABLE_WINRT

            // If that didn't work, this was an embedded resource. The toolchain should have embedded the
            // resource in an assembly. Go retrieve it now.
            LowLevelList<ResourceInfo> resourceInfos = GetExtractedResources(assembly);
            for (int i = 0; i < resourceInfos.Count; i++)
            {
                ResourceInfo resourceInfo = resourceInfos[i];
                if (name == resourceInfo.Name)
                {
                    return ReadResourceFromBlob(resourceInfo);
                }
            }
            return null;
        }

        private unsafe Stream ReadResourceFromBlob(ResourceInfo resourceInfo)
        {
            byte* pBlob;
            uint cbBlob;

            if (!RuntimeAugments.FindBlob(resourceInfo.ModuleHandle, (int)ReflectionMapBlob.BlobIdResourceData, (IntPtr)(&pBlob), (IntPtr)(&cbBlob)))
            {
                throw new BadImageFormatException();
            }

            checked
            {
                if (resourceInfo.Index > cbBlob || resourceInfo.Index + resourceInfo.Length > cbBlob)
                {
                    throw new BadImageFormatException();
                }
            }

            UnmanagedMemoryStream stream = new UnmanagedMemoryStream(pBlob + resourceInfo.Index, resourceInfo.Length);

            return stream;
        }

        private LowLevelList<ResourceInfo> GetExtractedResources(Assembly assembly)
        {
            LowLevelDictionary<String, LowLevelList<ResourceInfo>> extractedResourceDictionary = this.ExtractedResourceDictionary;
            String assemblyName = assembly.GetName().FullName;
            LowLevelList<ResourceInfo> resourceInfos;
            if (!extractedResourceDictionary.TryGetValue(assemblyName, out resourceInfos))
                return new LowLevelList<ResourceInfo>();
            return resourceInfos;
        }

        private LowLevelDictionary<String, LowLevelList<ResourceInfo>> ExtractedResourceDictionary
        {
            get
            {
                if (s_extractedResourceDictionary == null)
                {
                    // Lazily create the extracted resource dictionary. If two threads race here, we may construct two dictionaries
                    // and overwrite one - this is ok since the dictionaries are read-only once constructed and they contain the identical data.

                    LowLevelDictionary<String, LowLevelList<ResourceInfo>> dict = new LowLevelDictionary<String, LowLevelList<ResourceInfo>>();

                    foreach (IntPtr module in ModuleList.Enumerate())
                    {
                        NativeReader reader;
                        if (!TryGetNativeReaderForBlob(module, ReflectionMapBlob.BlobIdResourceIndex, out reader))
                        {
                            continue;
                        }
                        NativeParser indexParser = new NativeParser(reader, 0);
                        NativeHashtable indexHashTable = new NativeHashtable(indexParser);

                        var entryEnumerator = indexHashTable.EnumerateAllEntries();
                        NativeParser entryParser;
                        while (!(entryParser = entryEnumerator.GetNext()).IsNull)
                        {
                            string assemblyName = entryParser.GetString();
                            string resourceName = entryParser.GetString();
                            int resourceOffset = (int)entryParser.GetUnsigned();
                            int resourceLength = (int)entryParser.GetUnsigned();

                            ResourceInfo resourceInfo = new ResourceInfo(resourceName, resourceOffset, resourceLength, module);

                            LowLevelList<ResourceInfo> assemblyResources;
                            if(!dict.TryGetValue(assemblyName, out assemblyResources))
                            {
                                assemblyResources = new LowLevelList<ResourceInfo>();
                                dict[assemblyName] = assemblyResources;
                            }

                            assemblyResources.Add(resourceInfo);                            
                        }
                    }

                    s_extractedResourceDictionary = dict;
                }
                return s_extractedResourceDictionary;
            }
        }

        /// <summary>
        /// Reads linked resources from the app directory
        /// </summary>
        private Stream ReadFileFromAppDirectory(String name)
        {
#if ENABLE_WINRT
            if (WinRTInterop.Callbacks.IsAppxModel())
                return (Stream)WinRTInterop.Callbacks.ReadFileIntoStream(name);
#endif // ENABLE_WINRT

            String pathToRunningExe = RuntimeAugments.TryGetFullPathToMainApplication();
            String directoryContainingRunningExe = Path.GetDirectoryName(pathToRunningExe);
            String fullName = Path.Combine(directoryContainingRunningExe, name);
            return (Stream)RuntimeAugments.OpenFileIfExists(fullName);
        }

        /// <summary>
        /// This dictionary gets us from assembly + resource name to the offset of a resource
        /// inside the resource data blob
        ///
        /// The dictionary's key is a Fusion-style assembly name.
        /// The dictionary's value is a list of <resourcename,index> tuples.
        /// </summary>
        private static volatile LowLevelDictionary<String, LowLevelList<ResourceInfo>> s_extractedResourceDictionary;

        private struct ResourceInfo
        {
            public ResourceInfo(String name, int index, int length, IntPtr moduleHandle)
            {
                Name = name;
                Index = index;
                Length = length;
                ModuleHandle = moduleHandle;
            }

            public String Name { get; }
            public int Index { get; }
            public int Length { get; }
            public IntPtr ModuleHandle { get; }
        }
    }
}

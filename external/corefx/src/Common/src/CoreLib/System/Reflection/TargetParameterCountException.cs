// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.Reflection
{
    [Serializable]
#if !MONO
    [System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public sealed class TargetParameterCountException : ApplicationException
    {
        public TargetParameterCountException()
            : base(SR.Arg_TargetParameterCountException)
        {
            HResult = HResults.COR_E_TARGETPARAMCOUNT;
        }

        public TargetParameterCountException(string message)
            : base(message)
        {
            HResult = HResults.COR_E_TARGETPARAMCOUNT;
        }

        public TargetParameterCountException(string message, Exception inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_TARGETPARAMCOUNT;
        }

        internal TargetParameterCountException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

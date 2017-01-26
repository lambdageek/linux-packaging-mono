// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.ErrorHandling, SetLastError = false, EntryPoint = "SetErrorMode", ExactSpelling = true)]
        internal static extern uint SetErrorMode(uint newMode);

        internal const uint SEM_FAILCRITICALERRORS = 1;
    }
}

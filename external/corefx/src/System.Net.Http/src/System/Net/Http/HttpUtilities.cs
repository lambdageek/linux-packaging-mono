// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http.Headers;

namespace System.Net.Http
{
    internal static class HttpUtilities
    {
        internal static Version DefaultRequestVersion =>
#if uap
            HttpVersionInternal.Version20;
#else
            HttpVersionInternal.Version11;
#endif
        internal static Version DefaultResponseVersion => HttpVersionInternal.Version11;

        internal static bool IsHttpUri(Uri uri)
        {
            Debug.Assert(uri != null);

            string scheme = uri.Scheme;
            return string.Equals("http", scheme, StringComparison.OrdinalIgnoreCase) ||
                string.Equals("https", scheme, StringComparison.OrdinalIgnoreCase);
        }

        // Always specify TaskScheduler.Default to prevent us from using a user defined TaskScheduler.Current.
        //
        // Since we're not doing any CPU and/or I/O intensive operations, continue on the same thread.
        // This results in better performance since the continuation task doesn't get scheduled by the
        // scheduler and there are no context switches required.
        internal static Task ContinueWithStandard<T>(this Task<T> task, object state, Action<Task<T>, object> continuation)
        {
            return task.ContinueWith(continuation, state, CancellationToken.None,
                TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }
    }
}

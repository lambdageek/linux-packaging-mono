// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Threading.Tasks.Dataflow.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Threading.Tasks.Dataflow.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Threading.Tasks.Dataflow.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Threading.Tasks.Dataflow
{
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.ActionBlock<TInput>.DebugView")]
    public sealed partial class ActionBlock<TInput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ITargetBlock<TInput>
    {
        public ActionBlock(System.Action<TInput> action) { }
        public ActionBlock(System.Action<TInput> action, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public ActionBlock(System.Func<TInput, System.Threading.Tasks.Task> action) { }
        public ActionBlock(System.Func<TInput, System.Threading.Tasks.Task> action, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int InputCount { get { throw null; } }
        public void Complete() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public bool Post(TInput item) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.BatchBlock<T>.DebugView")]
    public sealed partial class BatchBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T[]>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T[]>, System.Threading.Tasks.Dataflow.ISourceBlock<T[]>, System.Threading.Tasks.Dataflow.ITargetBlock<T>
    {
        public BatchBlock(int batchSize) { }
        public BatchBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
        public int BatchSize { get { throw null; } }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        T[] System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public void TriggerBatch() { }
        public bool TryReceive(System.Predicate<T[]> filter, out T[] item) { item = default(T[]); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<T[]> items) { items = default(System.Collections.Generic.IList<T[]>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.BatchedJoinBlock<T1, T2>.DebugView")]
    public sealed partial class BatchedJoinBlock<T1, T2> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>>
    {
        public BatchedJoinBlock(int batchSize) { }
        public BatchedJoinBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
        public int BatchSize { get { throw null; } }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> filter, out System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>> item) { item = default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> items) { items = default(System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.BatchedJoinBlock<T1, T2, T3>.DebugView")]
    public sealed partial class BatchedJoinBlock<T1, T2, T3> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>>
    {
        public BatchedJoinBlock(int batchSize) { }
        public BatchedJoinBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
        public int BatchSize { get { throw null; } }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T3> Target3 { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> filter, out System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>> item) { item = default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> items) { items = default(System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.BroadcastBlock<T>.DebugView")]
    public sealed partial class BroadcastBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T>
    {
        public BroadcastBlock(System.Func<T, T> cloningFunction) { }
        public BroadcastBlock(System.Func<T, T> cloningFunction, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); throw null; }
        T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.BufferBlock<T>.DebugView")]
    public sealed partial class BufferBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T>
    {
        public BufferBlock() { }
        public BufferBlock(System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int Count { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); throw null; }
    }
    public static partial class DataflowBlock
    {
        public static System.IObservable<TOutput> AsObservable<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { throw null; }
        public static System.IObserver<TInput> AsObserver<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target) { throw null; }
        public static System.Threading.Tasks.Task<int> Choose<T1, T2>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2) { throw null; }
        public static System.Threading.Tasks.Task<int> Choose<T1, T2>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { throw null; }
        public static System.Threading.Tasks.Task<int> Choose<T1, T2, T3>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.ISourceBlock<T3> source3, System.Action<T3> action3) { throw null; }
        public static System.Threading.Tasks.Task<int> Choose<T1, T2, T3>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.ISourceBlock<T3> source3, System.Action<T3> action3, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { throw null; }
        public static System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput> Encapsulate<TInput, TOutput>(System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { throw null; }
        public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { throw null; }
        public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Predicate<TOutput> predicate) { throw null; }
        public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions, System.Predicate<TOutput> predicate) { throw null; }
        public static System.Threading.Tasks.Dataflow.ITargetBlock<TInput> NullTarget<TInput>() { throw null; }
        public static System.Threading.Tasks.Task<bool> OutputAvailableAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { throw null; }
        public static System.Threading.Tasks.Task<bool> OutputAvailableAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static bool Post<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item) { throw null; }
        public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { throw null; }
        public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout) { throw null; }
        public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { throw null; }
        public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout) { throw null; }
        public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<bool> SendAsync<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item) { throw null; }
        public static System.Threading.Tasks.Task<bool> SendAsync<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static bool TryReceive<TOutput>(this System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput> source, out TOutput item) { item = default(TOutput); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}")]
    public partial class DataflowBlockOptions
    {
        public const int Unbounded = -1;
        public DataflowBlockOptions() { }
        public int BoundedCapacity { get { throw null; } set { } }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } set { } }
        public int MaxMessagesPerTask { get { throw null; } set { } }
        public string NameFormat { get { throw null; } set { } }
        public System.Threading.Tasks.TaskScheduler TaskScheduler { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PropagateCompletion = {PropagateCompletion}, MaxMessages = {MaxMessages}, Append = {Append}")]
    public partial class DataflowLinkOptions
    {
        public DataflowLinkOptions() { }
        public bool Append { get { throw null; } set { } }
        public int MaxMessages { get { throw null; } set { } }
        public bool PropagateCompletion { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Id = {Id}")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DataflowMessageHeader : System.IEquatable<System.Threading.Tasks.Dataflow.DataflowMessageHeader>
    {
        public DataflowMessageHeader(long id) { throw null;}
        public long Id { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Threading.Tasks.Dataflow.DataflowMessageHeader other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.Tasks.Dataflow.DataflowMessageHeader left, System.Threading.Tasks.Dataflow.DataflowMessageHeader right) { throw null; }
        public static bool operator !=(System.Threading.Tasks.Dataflow.DataflowMessageHeader left, System.Threading.Tasks.Dataflow.DataflowMessageHeader right) { throw null; }
    }
    public enum DataflowMessageStatus
    {
        Accepted = 0,
        Declined = 1,
        DecliningPermanently = 4,
        NotAvailable = 3,
        Postponed = 2,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}, MaxDegreeOfParallelism = {MaxDegreeOfParallelism}")]
    public partial class ExecutionDataflowBlockOptions : System.Threading.Tasks.Dataflow.DataflowBlockOptions
    {
        public ExecutionDataflowBlockOptions() { }
        public int MaxDegreeOfParallelism { get { throw null; } set { } }
        public bool SingleProducerConstrained { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}, Greedy = {Greedy}, MaxNumberOfGroups = {MaxNumberOfGroups}")]
    public partial class GroupingDataflowBlockOptions : System.Threading.Tasks.Dataflow.DataflowBlockOptions
    {
        public GroupingDataflowBlockOptions() { }
        public bool Greedy { get { throw null; } set { } }
        public long MaxNumberOfGroups { get { throw null; } set { } }
    }
    public partial interface IDataflowBlock
    {
        System.Threading.Tasks.Task Completion { get; }
        void Complete();
        void Fault(System.Exception exception);
    }
    public partial interface IPropagatorBlock<in TInput, out TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput>
    {
    }
    public partial interface IReceivableSourceBlock<TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>
    {
        bool TryReceive(System.Predicate<TOutput> filter, out TOutput item);
        bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items);
    }
    public partial interface ISourceBlock<out TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock
    {
        TOutput ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed);
        System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions);
        void ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target);
        bool ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target);
    }
    public partial interface ITargetBlock<in TInput> : System.Threading.Tasks.Dataflow.IDataflowBlock
    {
        System.Threading.Tasks.Dataflow.DataflowMessageStatus OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.JoinBlock<T1, T2>.DebugView")]
    public sealed partial class JoinBlock<T1, T2> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<T1, T2>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1, T2>>
    {
        public JoinBlock() { }
        public JoinBlock(System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        System.Tuple<T1, T2> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<System.Tuple<T1, T2>> filter, out System.Tuple<T1, T2> item) { item = default(System.Tuple<T1, T2>); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<T1, T2>> items) { items = default(System.Collections.Generic.IList<System.Tuple<T1, T2>>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.JoinBlock<T1, T2, T3>.DebugView")]
    public sealed partial class JoinBlock<T1, T2, T3> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<T1, T2, T3>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1, T2, T3>>
    {
        public JoinBlock() { }
        public JoinBlock(System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { throw null; } }
        public System.Threading.Tasks.Dataflow.ITargetBlock<T3> Target3 { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        System.Tuple<T1, T2, T3> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<System.Tuple<T1, T2, T3>> filter, out System.Tuple<T1, T2, T3> item) { item = default(System.Tuple<T1, T2, T3>); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<T1, T2, T3>> items) { items = default(System.Collections.Generic.IList<System.Tuple<T1, T2, T3>>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.TransformBlock<TInput, TOutput>.DebugView")]
    public sealed partial class TransformBlock<TInput, TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput>
    {
        public TransformBlock(System.Func<TInput, System.Threading.Tasks.Task<TOutput>> transform) { }
        public TransformBlock(System.Func<TInput, System.Threading.Tasks.Task<TOutput>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public TransformBlock(System.Func<TInput, TOutput> transform) { }
        public TransformBlock(System.Func<TInput, TOutput> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int InputCount { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<TOutput> filter, out TOutput item) { item = default(TOutput); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items) { items = default(System.Collections.Generic.IList<TOutput>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.TransformManyBlock<TInput, TOutput>.DebugView")]
    public sealed partial class TransformManyBlock<TInput, TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput>
    {
        public TransformManyBlock(System.Func<TInput, System.Collections.Generic.IEnumerable<TOutput>> transform) { }
        public TransformManyBlock(System.Func<TInput, System.Collections.Generic.IEnumerable<TOutput>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public TransformManyBlock(System.Func<TInput, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TOutput>>> transform) { }
        public TransformManyBlock(System.Func<TInput, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TOutput>>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public int InputCount { get { throw null; } }
        public int OutputCount { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<TOutput> filter, out TOutput item) { item = default(TOutput); throw null; }
        public bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items) { items = default(System.Collections.Generic.IList<TOutput>); throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayContent,nq}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("System.Threading.Tasks.Dataflow.WriteOnceBlock<T>.DebugView")]
    public sealed partial class WriteOnceBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T>
    {
        public WriteOnceBlock(System.Func<T, T> cloningFunction) { }
        public WriteOnceBlock(System.Func<T, T> cloningFunction, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
        public System.Threading.Tasks.Task Completion { get { throw null; } }
        public void Complete() { }
        public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { throw null; }
        void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
        bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); throw null; }
        T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); throw null; }
        void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
        bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { throw null; }
        System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { throw null; }
        public override string ToString() { throw null; }
        public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); throw null; }
    }
}

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.ConverterArgumentBindingProvider`1+ConverterArgumentBinding.#BindingDataContract")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_cancellationTokenSource", Scope = "member", Target = "Microsoft.Azure.WebJobs.Files.Listeners.FileListener.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Files.Listeners.FileListenerFactory.#CreateAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Converters.FileSystemEventConverter`1.#ConvertAsync(System.IO.FileSystemEventArgs,System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "cancellationToken", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileSystemEventValueProvider.#CreateInvokeStringAsync(System.IO.FileSystemEventArgs,System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "parameterType", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileTriggerBinding.#CreateConverter(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerInfoConverterArgumentBindingProvider`1+TimerConverterArgumentBinding.#BindingDataContract")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "clone", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerInfoValueProvider.#CreateInvokeStringAsync(Microsoft.Azure.WebJobs.Extensions.Timers.TimerInfo,System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "cancellationToken", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerInfoValueProvider.#CreateInvokeStringAsync(Microsoft.Azure.WebJobs.Extensions.Timers.TimerInfo,System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Listeners.TimerListener.#StartAsync(System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_cancellationTokenSource", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Listeners.TimerListener.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.TimerListenerFactory.#CreateAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.TimerTriggerAttribute")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#_parameterName")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#CreateBindingDataContract()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "timerInfo", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#CreateBindingData(Microsoft.Azure.WebJobs.Extensions.Timers.TimerInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#CreateBindingData(Microsoft.Azure.WebJobs.Extensions.Timers.TimerInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "parameterType", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#CreateConverter(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Files.Listeners.FileListener.#CreateFileWatcher()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "disposing", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Listener.FileProcessor.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "state", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Listener.FileProcessor.#CleanupProcessedFiles(System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Scheduling.FileSystemScheduleMonitor+StatusEntry.#Last")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Listener.FileProcessor.#OpenLockStatusFile(System.String,System.IO.WatcherChangeTypes)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "AutoDelete", Scope = "member", Target = "Microsoft.Azure.WebJobs.Files.Listeners.FileListener.#CreateFileWatcher()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Listener.FileProcessor.#AquireStatusFileLock(System.String,System.IO.WatcherChangeTypes)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Listener.FileProcessor.#AquireStatusFileLock(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Converters.FileSystemEventConverter`1.#Convert(System.IO.FileSystemEventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.ConverterArgumentBindingProvider`2+ArgumentBinding.#Convert(System.IO.FileSystemEventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.ConverterArgumentBindingProvider`2+ArgumentBinding.#BindingDataContract")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileTriggerArgumentBindingProvider`2+ArgumentBinding.#BindingDataContract")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileTriggerArgumentBindingProvider`2+ArgumentBinding.#Convert(System.IO.FileSystemEventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Framework.StreamValueBinder.#.ctor(System.Reflection.ParameterInfo,Microsoft.Azure.WebJobs.Host.Bindings.BindStepOrder)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "FileAttribute", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileAttributeBindingProvider.#TryCreateAsync(Microsoft.Azure.WebJobs.Host.Bindings.BindingProviderContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Files.Bindings.FileTriggerBinding.#CreateListenerAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.Timers.Bindings.TimerTriggerBinding.#CreateListenerAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.WebHooks.WebHookTriggerAttributeBindingProvider+WebHookTriggerBinding.#CreateListenerAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.WebHooks.WebHookTriggerAttributeBindingProvider+WebHookTriggerBinding.#GetBindingData(Microsoft.Azure.WebJobs.Extensions.WebHooks.WebHookTriggerValue)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.WebHooks.WebHookTriggerAttributeBindingProvider+WebHookTriggerBinding.#CreateBindingDataContract()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Extensions.WebHooks.WebHookTriggerAttributeBindingProvider+WebHookTriggerBinding+WebHookMessageHandler.#SendAsync(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)")]
<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility

## Contents

- [AnchoredCommandAddedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.AnchoredCommandAddedEventArgs')
  - [#ctor(command,dynamicCommandAnchorIdentifier)](#M-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.AnchoredCommandAddedEventArgs.#ctor(Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand,System.String)')
  - [DynamicCommandAnchorIdentifier](#P-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs-DynamicCommandAnchorIdentifier 'Microsoft.VisualStudio.Extensibility.Commands.AnchoredCommandAddedEventArgs.DynamicCommandAnchorIdentifier')
- [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription')
  - [#ctor(text)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.#ctor(System.String)')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-Text 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.Text')
  - [FromString(choiceText)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-FromString-System-String- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.FromString(System.String)')
  - [FromUserPrompOption(rpcOption)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-FromUserPrompOption-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.FromUserPrompOption(Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption)')
  - [ToUserPromptOption()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-ToUserPromptOption 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.ToUserPromptOption')
  - [op_Implicit(choiceText)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription')
- [ChoiceResultCollection\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.#ctor')
  - [#ctor(choiceResultPairs)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription,`0}}- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.#ctor(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,`0}})')
  - [#ctor(internalMap)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor-System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption,`0}}- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.#ctor(System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption,`0}})')
  - [Count](#P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Count 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.Count')
  - [InternalMap](#P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-InternalMap 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.InternalMap')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Item-System-Int32- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.Item(System.Int32)')
  - [Add(choice,result)](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Add-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription,`0- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.Add(Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,`0)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Equals-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection{`0}- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.Equals(Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection{`0})')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.Equals(System.Object)')
  - [GetEnumerator()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-GetEnumerator 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.GetEnumerator')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-GetHashCode 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.GetHashCode')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-System#Collections#IEnumerable#GetEnumerator 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1.System#Collections#IEnumerable#GetEnumerator')
- [Command](#T-Microsoft-VisualStudio-Extensibility-Commands-Command 'Microsoft.VisualStudio.Extensibility.Commands.Command')
  - [#ctor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.Commands.Command.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [CommandConfiguration](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-CommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.Command.CommandConfiguration')
- [CommandAddedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs')
  - [#ctor(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs.#ctor(Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand)')
  - [Command](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-Command 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs.Command')
- [CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync')
- [CommandRemovedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs')
  - [#ctor(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ICommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ICommand)')
  - [Command](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-Command 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs.Command')
- [CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet')
  - [#ctor(extensibility,container,serviceProvider,commandSetFactory)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.IServiceProvider,Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory)')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Item-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.Item(System.String)')
  - [Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands')
  - [CompleteCommandRegistrationAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-CompleteCommandRegistrationAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.CompleteCommandRegistrationAsync(System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.Dispose(System.Boolean)')
  - [GetDynamicCommandAnchor\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-GetDynamicCommandAnchor``1 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.GetDynamicCommandAnchor``1')
  - [InitializeAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
  - [RegisterAnchoredCommand(command,dynamicCommandAnchorIdentifier)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterAnchoredCommand-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.RegisterAnchoredCommand(Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand,System.String)')
  - [RegisterCommand(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.RegisterCommand(Microsoft.VisualStudio.Extensibility.Commands.ICommand)')
  - [RegisterCommandAsync(commandType)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommandAsync-System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.RegisterCommandAsync(System.Type)')
  - [RegisterCommandAsync\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommandAsync``1 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.RegisterCommandAsync``1')
  - [RegisterDynamicCommandAnchorAsync(dynamicCommandAnchorType)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterDynamicCommandAnchorAsync-System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.RegisterDynamicCommandAnchorAsync(System.Type)')
  - [UnregisterDynamicCommand(commandId)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-UnregisterDynamicCommand-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet.UnregisterDynamicCommand(System.String)')
- [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory')
  - [#ctor(serviceProvider)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.#ctor(System.IServiceProvider)')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.ServiceMoniker')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSet)')
- [CommandSetProvider](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider')
  - [#ctor(updateReceiver,extensibility,container,commandSetCreator)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-#ctor-Microsoft-VisualStudio-RpcContracts-Commands-IUpdateReceiver,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet}- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.#ctor(Microsoft.VisualStudio.RpcContracts.Commands.IUpdateReceiver,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet})')
  - [ActivateCommandSetAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ActivateCommandSetAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.ActivateCommandSetAsync(System.Threading.CancellationToken)')
  - [CreateFactoryAsync(options,extensibility,container,commandSetCreator,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.CreateFactoryAsync(Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet},System.Threading.CancellationToken)')
  - [CreateFactoryAsync\`\`1(options,extensibility,container,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync``1-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.CreateFactoryAsync``1(Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Threading.CancellationToken)')
  - [DeactivateCommandSetAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-DeactivateCommandSetAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.DeactivateCommandSetAsync(System.Threading.CancellationToken)')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.Dispose(System.Boolean)')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-String,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.ExecuteCommandAsync(System.String,System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [ConfigurationExtensibility](#T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [CreateInstance(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-CreateInstance-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility.CreateInstance(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [GetPersistedStateAsync\`\`1(moniker,defaultValue,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-GetPersistedStateAsync``1-System-String,``0,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility.GetPersistedStateAsync``1(System.String,``0,System.Threading.CancellationToken)')
  - [WritePersistedStateAsync\`\`1(moniker,value,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-WritePersistedStateAsync``1-System-String,``0,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility.WritePersistedStateAsync``1(System.String,``0,System.Threading.CancellationToken)')
- [DebuggerVisualizerProvider](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider')
  - [#ctor(container,extensibilityObject)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider.#ctor(Microsoft.VisualStudio.Extensibility.ExtensionCore,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [DebuggerVisualizerProviderConfiguration](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-DebuggerVisualizerProviderConfiguration 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider.DebuggerVisualizerProviderConfiguration')
  - [CreateVisualizerAsync(visualizerTarget,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-CreateVisualizerAsync-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider.CreateVisualizerAsync(Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget,System.Threading.CancellationToken)')
- [DebuggerVisualizerProviderService](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService')
  - [#ctor(debuggerVisualizerProvider)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService.#ctor(Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-Dispose 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService.Dispose')
  - [GetVisualizerAsync()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-GetVisualizerAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService.GetVisualizerAsync(Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget,Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData,System.Threading.CancellationToken)')
- [DiagnosticsExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods')
  - [GetDiagnosticsReporter(extensibilityPoint,generatorId)](#M-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods-GetDiagnosticsReporter-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods.GetDiagnosticsReporter(Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility,System.String)')
- [DiagnosticsReporter](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter')
  - [#ctor(generatorId,extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.#ctor(System.String,Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [GeneratorId](#P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-GeneratorId 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.GeneratorId')
  - [ClearDiagnosticsAsync(textDocument,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ClearDiagnosticsAsync(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,System.Threading.CancellationToken)')
  - [ClearDiagnosticsAsync(documentMoniker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ClearDiagnosticsAsync(System.Uri,System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.Dispose(System.Boolean)')
  - [ReportDiagnosticAsync(diagnostic,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticAsync-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ReportDiagnosticAsync(Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic,System.Threading.CancellationToken)')
  - [ReportDiagnosticsAsync(diagnostics,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticsAsync-System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ReportDiagnosticsAsync(System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic},System.Threading.CancellationToken)')
- [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic')
  - [#ctor(span,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.#ctor(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [#ctor(uri,range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.#ctor(System.Uri,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [DocumentVersion](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-DocumentVersion 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.DocumentVersion')
  - [ErrorCode](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ErrorCode 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.ErrorCode')
  - [HelpLink](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-HelpLink 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.HelpLink')
  - [Message](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Message 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Message')
  - [ProviderName](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ProviderName 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.ProviderName')
  - [Range](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Range 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Range')
  - [Severity](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Severity 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Severity')
  - [Uri](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Uri 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Uri')
  - [CreateDocumentDiagnostic(range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnostic-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.CreateDocumentDiagnostic(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [CreateDocumentDiagnosticForClosedDocument(uri,range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnosticForClosedDocument-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.CreateDocumentDiagnosticForClosedDocument(System.Uri,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
- [DocumentExtensions](#T-Microsoft-VisualStudio-Extensibility-DocumentExtensions 'Microsoft.VisualStudio.Extensibility.DocumentExtensions')
  - [AsTextDocumentAsync(documentSnapshot,extensibility,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-AsTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentExtensions.AsTextDocumentAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.Threading.CancellationToken)')
  - [CloseAsync(document,option,extensibility,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-CloseAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentExtensions.CloseAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.Threading.CancellationToken)')
  - [SaveAsync(document,extensibility,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-SaveAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentExtensions.SaveAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.Threading.CancellationToken)')
- [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [CloseDocumentAsync(moniker,option,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-CloseDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.CloseDocumentAsync(System.Uri,Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption,System.Threading.CancellationToken)')
  - [GetOpenDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetOpenDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.GetOpenDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [GetOpenDocumentsAsync(token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetOpenDocumentsAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.GetOpenDocumentsAsync(System.Threading.CancellationToken)')
  - [GetTextDocumentSnapshotAsync(documentSnapshot,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetTextDocumentSnapshotAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.GetTextDocumentSnapshotAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,System.Threading.CancellationToken)')
  - [InitializeDocumentAsync(documentSnapshot,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-InitializeDocumentAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.InitializeDocumentAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,System.Threading.CancellationToken)')
  - [OpenDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.OpenDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [OpenDocumentAsync(moniker,options,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.OpenDocumentAsync(System.Uri,Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions,System.Threading.CancellationToken)')
  - [OpenTextDocumentAsync(filePath,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenTextDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.OpenTextDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [OpenTextDocumentAsync(filePath,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenTextDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.OpenTextDocumentAsync(System.Uri,Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions,System.Threading.CancellationToken)')
  - [SaveAllAsync(token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SaveAllAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.SaveAllAsync(System.Threading.CancellationToken)')
  - [SaveDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SaveDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.SaveDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [SubscribeAsync(listener,filterRegex,token)](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SubscribeAsync-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.SubscribeAsync(Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener,System.String,System.Threading.CancellationToken)')
- [DynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand')
  - [#ctor(extensibility,metadata,executeCommandCallback)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [IconName](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IconName 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.IconName')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.IsChecked')
  - [RelativeDisplayOrder](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-RelativeDisplayOrder 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.RelativeDisplayOrder')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')
- [DynamicCommandAnchor](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor')
  - [#ctor(commadSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-#ctor-Microsoft-VisualStudio-Extensibility-Commands-CommandSet- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.#ctor(Microsoft.VisualStudio.Extensibility.Commands.CommandSet)')
  - [CommandConfiguration](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-CommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.CommandConfiguration')
  - [AddCommand(metadata,commandHandler)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-AddCommand-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.AddCommand(Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [RemoveCommand(commandId)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-RemoveCommand-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.RemoveCommand(System.String)')
- [ExecutableCommandHandler](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler')
  - [#ctor(extensibility,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.String)')
  - [DisableDuringExecution](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-DisableDuringExecution 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.DisableDuringExecution')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-Extensibility 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.Extensibility')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.IsEnabled')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')
- [ExtensibilityPoints](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints')
  - [Configuration(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Configuration-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Configuration(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Documents(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Documents-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Documents(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Languages(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Languages-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Languages(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Shell(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Shell-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Shell(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Views(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Views-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Views(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Workspaces(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Workspaces-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Workspaces(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
- [Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension')
  - [CommandSet](#P-Microsoft-VisualStudio-Extensibility-Extension-CommandSet 'Microsoft.VisualStudio.Extensibility.Extension.CommandSet')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Extension-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet- 'Microsoft.VisualStudio.Extensibility.Extension.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSet)')
  - [InitializeServices()](#M-Microsoft-VisualStudio-Extensibility-Extension-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Microsoft.VisualStudio.Extensibility.Extension.InitializeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-ExtensionMethods 'Microsoft.VisualStudio.Extensibility.ExtensionMethods')
  - [GetActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')
  - [GetSelectedPathAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetSelectedPathAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetSelectedPathAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')
  - [ShowPromptAsync\`\`1(clientContext,message,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowPromptAsync``1-Microsoft-VisualStudio-Extensibility-IClientContext,System-String,Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.ShowPromptAsync``1(Microsoft.VisualStudio.Extensibility.IClientContext,System.String,Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{``0},System.Threading.CancellationToken)')
  - [ShowUserPromptImplAsync(clientContext,message,options,defaultOptionIndex,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowUserPromptImplAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-String,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption},System-UInt32,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.ShowUserPromptImplAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.String,System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption},System.UInt32,System.Threading.CancellationToken)')
- [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.DisplayName')
  - [Flags](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Flags 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.Flags')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Id 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.Id')
  - [IsVisible](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-IsVisible 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.IsVisible')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.TooltipText')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommand-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.InitializeAsync(System.Threading.CancellationToken)')
- [ICommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet')
  - [Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-Commands 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.Commands')
  - [InitializeAsync(serviceBroker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
- [ICommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.ServiceMoniker')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSet)')
- [IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand')
  - [IconName](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-IconName 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.IconName')
  - [RelativeDisplayOrder](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-RelativeDisplayOrder 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.RelativeDisplayOrder')
- [IExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.IsEnabled')
  - [ExecuteCommandAsync(contextProperties,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [IToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand.IsChecked')
- [IsExternalInit](#T-System-Runtime-CompilerServices-IsExternalInit 'System.Runtime.CompilerServices.IsExternalInit')
- [LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
- [OutputWindow](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindow')
  - [#ctor(outputWindow)](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-#ctor-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindow.#ctor(Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal)')
  - [Writer](#P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-Writer 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindow.Writer')
  - [DisposeNativeResources()](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-DisposeNativeResources 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindow.DisposeNativeResources')
- [OutputWindowExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [outputWindowChannels](#F-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-outputWindowChannels 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility.outputWindowChannels')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility.Dispose(System.Boolean)')
  - [GetChannelAsync(identifier,displayNameResourceId,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-GetChannelAsync-System-String,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility.GetChannelAsync(System.String,System.String,System.Threading.CancellationToken)')
- [OutputWindowInternal](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal')
  - [#ctor(identifier,writer,encoding,outputChannelStore,serviceBroker)](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-#ctor-System-String,System-IO-Pipelines-PipeWriter,System-Text-Encoding,Microsoft-VisualStudio-RpcContracts-OutputChannel-IOutputChannelStore,Microsoft-ServiceHub-Framework-IServiceBroker- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.#ctor(System.String,System.IO.Pipelines.PipeWriter,System.Text.Encoding,Microsoft.VisualStudio.RpcContracts.OutputChannel.IOutputChannelStore,Microsoft.ServiceHub.Framework.IServiceBroker)')
  - [Identifier](#P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-Identifier 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.Identifier')
  - [Writer](#P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-Writer 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.Writer')
  - [CreateChannelAsync(identifier,resourceId,encoding,serviceBroker,stringResourceDictionary,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-CreateChannelAsync-System-String,System-String,System-Text-Encoding,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.CreateChannelAsync(System.String,System.String,System.Text.Encoding,Microsoft.ServiceHub.Framework.IServiceBroker,Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary,System.Threading.CancellationToken)')
  - [DisposeManagedResources()](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-DisposeManagedResources 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.DisposeManagedResources')
  - [ReleaseReference()](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-ReleaseReference 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.ReleaseReference')
  - [TryAddReference()](#M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-TryAddReference 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal.TryAddReference')
- [PlaceholderCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand')
  - [#ctor(id)](#M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.#ctor(System.String)')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.DisplayName')
  - [Flags](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Flags 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.Flags')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Id 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.Id')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-IsDisposed 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.IsDisposed')
  - [IsVisible](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-IsVisible 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.IsVisible')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.TooltipText')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Dispose 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.Dispose(System.Boolean)')
  - [InitializeAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.InitializeAsync(System.Threading.CancellationToken)')
  - [OnPropertyChanged(eventArgs)](#M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs- 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs)')
- [ProgressReporter](#T-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter')
  - [#ctor(workId,workProgressHandler)](#M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-#ctor-System-Guid,Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler- 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.#ctor(System.Guid,Microsoft.VisualStudio.RpcContracts.ProgressReporting.IWorkProgressHandler)')
  - [CancellationToken](#P-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-CancellationToken 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.CancellationToken')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-IsDisposed 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.IsDisposed')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Dispose 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.Dispose')
  - [Dispose(isDisposing)](#M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.Dispose(System.Boolean)')
  - [OnWorkCanceled(sender,args)](#M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-OnWorkCanceled-System-Object,Microsoft-VisualStudio-RpcContracts-ProgressReporting-WorkCanceledEventArgs- 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.OnWorkCanceled(System.Object,Microsoft.VisualStudio.RpcContracts.ProgressReporting.WorkCanceledEventArgs)')
  - [Report(progressStatus)](#M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Report-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressStatus- 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter.Report(Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressStatus)')
- [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor 'Microsoft.VisualStudio.Extensibility.Shell.PromptException.#ctor')
  - [#ctor(message)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Shell.PromptException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-String,System-Exception- 'Microsoft.VisualStudio.Extensibility.Shell.PromptException.#ctor(System.String,System.Exception)')
  - [#ctor(info,context)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Microsoft.VisualStudio.Extensibility.Shell.PromptException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [PromptOptions](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions')
  - [OK](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-OK 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions.OK')
  - [OKCancel](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-OKCancel 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions.OKCancel')
  - [RetryCancel](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-RetryCancel 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions.RetryCancel')
- [PromptOptionsWithCancel\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1')
  - [#ctor(original,cancelReturns)](#M-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0},`0- 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1.#ctor(Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{`0},`0)')
  - [WithCancelAsDefault()](#M-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1-WithCancelAsDefault 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1.WithCancelAsDefault')
- [PromptOptions\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.#ctor')
  - [#ctor(choices,defaultChoiceIndex,dismissedReturns)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection{`0},System-Int32,`0- 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.#ctor(Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection{`0},System.Int32,`0)')
  - [#ctor(original)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0}- 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.#ctor(Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{`0})')
  - [Choices](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-Choices 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.Choices')
  - [DefaultChoiceIndex](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DefaultChoiceIndex 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.DefaultChoiceIndex')
  - [DismissedReturns](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DismissedReturns 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.DismissedReturns')
  - [GetResult(promptResult)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-GetResult-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptResult- 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.GetResult(Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptResult)')
  - [WithCancel(cancelReturns,cancelIsDefault)](#M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-WithCancel-`0,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.WithCancel(`0,System.Boolean)')
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Resources 'Microsoft.VisualStudio.Extensibility.Resources')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Resources.CommandIdAlreadyRegistered')
  - [CommandSetNotInitializedYet](#P-Microsoft-VisualStudio-Extensibility-Resources-CommandSetNotInitializedYet 'Microsoft.VisualStudio.Extensibility.Resources.CommandSetNotInitializedYet')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Resources.Culture')
  - [DynamicCommandAnchorNotFound](#P-Microsoft-VisualStudio-Extensibility-Resources-DynamicCommandAnchorNotFound 'Microsoft.VisualStudio.Extensibility.Resources.DynamicCommandAnchorNotFound')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Resources.InvalidVersionString')
  - [Prompt_Choice_Cancel](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Cancel 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Cancel')
  - [Prompt_Choice_No](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_No 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_No')
  - [Prompt_Choice_OK](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_OK 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_OK')
  - [Prompt_Choice_Retry](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Retry 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Retry')
  - [Prompt_Choice_Yes](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Yes 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Yes')
  - [Prompt_Exception_NoNegativeValues](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Exception_NoNegativeValues 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Exception_NoNegativeValues')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Resources.ResourceManager')
  - [TraceExtensionStateJsonParseError](#P-Microsoft-VisualStudio-Extensibility-Resources-TraceExtensionStateJsonParseError 'Microsoft.VisualStudio.Extensibility.Resources.TraceExtensionStateJsonParseError')
  - [TraceExtensionStateNotFound](#P-Microsoft-VisualStudio-Extensibility-Resources-TraceExtensionStateNotFound 'Microsoft.VisualStudio.Extensibility.Resources.TraceExtensionStateNotFound')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Resources.UnsupportedDocumentMoniker')
- [ShellExtensibility](#T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.Dispose(System.Boolean)')
  - [GetToolWindow\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-GetToolWindow``1 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.GetToolWindow``1')
  - [HideToolWindowAsync(toolWindowType,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-HideToolWindowAsync-System-Type,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.HideToolWindowAsync(System.Type,System.Threading.CancellationToken)')
  - [HideToolWindowAsync\`\`1(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-HideToolWindowAsync``1-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.HideToolWindowAsync``1(System.Threading.CancellationToken)')
  - [ServiceAvailabilityChanged(sender,args)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ServiceAvailabilityChanged-System-Object,Microsoft-ServiceHub-Framework-BrokeredServicesChangedEventArgs- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ServiceAvailabilityChanged(System.Object,Microsoft.ServiceHub.Framework.BrokeredServicesChangedEventArgs)')
  - [ShowDialogAsync(content,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl,System.Threading.CancellationToken)')
  - [ShowDialogAsync(content,title,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl,System.String,System.Threading.CancellationToken)')
  - [ShowDialogAsync(content,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl,Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption,System.Threading.CancellationToken)')
  - [ShowDialogAsync(content,title,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl,System.String,Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption,System.Threading.CancellationToken)')
  - [ShowToolWindowAsync(toolWindowType,activate,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync-System-Type,System-Boolean,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowToolWindowAsync(System.Type,System.Boolean,System.Threading.CancellationToken)')
  - [ShowToolWindowAsync\`\`1(activate,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync``1-System-Boolean,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowToolWindowAsync``1(System.Boolean,System.Threading.CancellationToken)')
  - [StartProgressReportingAsync(workDisplayName,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-StartProgressReportingAsync-System-String,Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressReporterOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.StartProgressReportingAsync(System.String,Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressReporterOptions,System.Threading.CancellationToken)')
  - [StartProgressReportingAsync(workDisplayName,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-StartProgressReportingAsync-System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.StartProgressReportingAsync(System.String,System.Threading.CancellationToken)')
- [SynchronizedBufferTextWriter](#T-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter')
  - [#ctor(pipeWriter,encoding)](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-#ctor-System-IO-Pipelines-PipeWriter,System-Text-Encoding- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.#ctor(System.IO.Pipelines.PipeWriter,System.Text.Encoding)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.Dispose(System.Boolean)')
  - [Write()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Write-System-ReadOnlySpan{System-Char}- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.Write(System.ReadOnlySpan{System.Char})')
  - [WriteLine()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-WriteLine-System-ReadOnlySpan{System-Char}- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.WriteLine(System.ReadOnlySpan{System.Char})')
- [ToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand')
  - [#ctor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.IsChecked')
- [ToolWindow](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow')
  - [#ctor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Extensibility 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Extensibility')
  - [Title](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Title 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Title')
  - [ToolWindowConfiguration](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ToolWindowConfiguration 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.ToolWindowConfiguration')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Dispose 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Dispose(System.Boolean)')
  - [GetContentAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-GetContentAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.GetContentAsync(System.Threading.CancellationToken)')
  - [HideAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-HideAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.HideAsync(System.Threading.CancellationToken)')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.InitializeAsync(System.Threading.CancellationToken)')
  - [OnHideAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnHideAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.OnHideAsync(System.Threading.CancellationToken)')
  - [OnShowAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnShowAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.OnShowAsync(System.Threading.CancellationToken)')
  - [ShowAsync(activate,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ShowAsync-System-Boolean,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.ShowAsync(System.Boolean,System.Threading.CancellationToken)')
- [ToolWindowContainer](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer')
  - [#ctor(traceSource)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-#ctor-System-Diagnostics-TraceSource- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer.#ctor(System.Diagnostics.TraceSource)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-Dispose 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer.Dispose(System.Boolean)')
  - [GetToolWindow(serviceProvider,toolWindowType)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-GetToolWindow-System-IServiceProvider,System-Type- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer.GetToolWindow(System.IServiceProvider,System.Type)')
- [ToolWindowProvider](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider')
  - [#ctor(container,extensibilityObject,serviceProvider,traceSource)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-IServiceProvider,System-Diagnostics-TraceSource- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.#ctor(Microsoft.VisualStudio.Extensibility.ExtensionCore,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.IServiceProvider,System.Diagnostics.TraceSource)')
  - [CreateToolWindowAsync()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-CreateToolWindowAsync-System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.CreateToolWindowAsync(System.String,System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.Dispose(System.Boolean)')
  - [GetTitleAsync()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-GetTitleAsync-System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.GetTitleAsync(System.String,System.Threading.CancellationToken)')
  - [GetToolWindow(identifier)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-GetToolWindow-System-String- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.GetToolWindow(System.String)')
  - [OnHideAsync()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-OnHideAsync-System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.OnHideAsync(System.String,System.Threading.CancellationToken)')
  - [OnShowAsync()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-OnShowAsync-System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.OnShowAsync(System.String,System.Threading.CancellationToken)')
  - [RegisterToolWindow(toolWindowType)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-RegisterToolWindow-System-Type- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.RegisterToolWindow(System.Type)')
  - [SubscribeAsync()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-SubscribeAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-ToolWindows-ToolWindowPropertyChangedArgs},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider.SubscribeAsync(System.IObserver{Microsoft.VisualStudio.RpcContracts.ToolWindows.ToolWindowPropertyChangedArgs},System.Threading.CancellationToken)')
- [ViewsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [Output](#P-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-Output 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility.Output')
- [VisualizerObjectSourceClient](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient')
  - [ReplaceTargetObjectAsync(message,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync-System-Buffers-ReadOnlySequence{System-Byte},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.ReplaceTargetObjectAsync(System.Buffers.ReadOnlySequence{System.Byte},System.Threading.CancellationToken)')
  - [ReplaceTargetObjectAsync(message,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync-Newtonsoft-Json-Linq-JToken,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.ReplaceTargetObjectAsync(Newtonsoft.Json.Linq.JToken,System.Threading.CancellationToken)')
  - [ReplaceTargetObjectAsync\`\`1(message,jsonSerializer,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync``1-``0,Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.ReplaceTargetObjectAsync``1(``0,Newtonsoft.Json.JsonSerializer,System.Threading.CancellationToken)')
  - [RequestDataAsync(message,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-System-Nullable{System-Buffers-ReadOnlySequence{System-Byte}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.RequestDataAsync(System.Nullable{System.Buffers.ReadOnlySequence{System.Byte}},System.Threading.CancellationToken)')
  - [RequestDataAsync(message,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-Newtonsoft-Json-Linq-JToken,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.RequestDataAsync(Newtonsoft.Json.Linq.JToken,System.Threading.CancellationToken)')
  - [RequestDataAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.RequestDataAsync(System.Threading.CancellationToken)')
  - [RequestDataAsync\`\`1(jsonSerializer,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync``1-Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.RequestDataAsync``1(Newtonsoft.Json.JsonSerializer,System.Threading.CancellationToken)')
  - [RequestDataAsync\`\`2(message,jsonSerializer,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync``2-``0,Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient.RequestDataAsync``2(``0,Newtonsoft.Json.JsonSerializer,System.Threading.CancellationToken)')
- [VisualizerObjectSourceClientImplementation](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClientImplementation')
  - [#ctor(visualizerTargetProxy)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-#ctor-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClientImplementation.#ctor(Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget)')
  - [ReplaceTargetObjectAsync()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-ReplaceTargetObjectAsync-System-Buffers-ReadOnlySequence{System-Byte},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClientImplementation.ReplaceTargetObjectAsync(System.Buffers.ReadOnlySequence{System.Byte},System.Threading.CancellationToken)')
  - [RequestDataAsync()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-RequestDataAsync-System-Nullable{System-Buffers-ReadOnlySequence{System-Byte}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClientImplementation.RequestDataAsync(System.Nullable{System.Buffers.ReadOnlySequence{System.Byte}},System.Threading.CancellationToken)')
- [VisualizerTarget](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget')
  - [#ctor(objectSource,visualizerTargetData)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.#ctor(Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient,Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData)')
  - [IsTargetReplaceable](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-IsTargetReplaceable 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.IsTargetReplaceable')
  - [ObjectSource](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-ObjectSource 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.ObjectSource')
  - [TargetTypeFullName](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeFullName 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.TargetTypeFullName')
  - [TargetTypeModuleName](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeModuleName 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.TargetTypeModuleName')
  - [TargetTypeModuleVersion](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeModuleVersion 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.TargetTypeModuleVersion')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-Dispose 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.Dispose')
  - [RaiseStateChangedAsync(notification)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-RaiseStateChangedAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetStateNotification- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.RaiseStateChangedAsync(Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetStateNotification)')
- [VisualizerTargetImplementation](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetImplementation')
  - [#ctor(visualizerTargetProxy,visualizerTargetData)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-#ctor-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetImplementation.#ctor(Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget,Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-Dispose 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetImplementation.Dispose')
  - [Microsoft#VisualStudio#RpcContracts#DebuggerVisualizers#IVisualizerTargetClient#NotifyStateChangeAsync()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-Microsoft#VisualStudio#RpcContracts#DebuggerVisualizers#IVisualizerTargetClient#NotifyStateChangeAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetStateNotification,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetImplementation.Microsoft#VisualStudio#RpcContracts#DebuggerVisualizers#IVisualizerTargetClient#NotifyStateChangeAsync(Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetStateNotification,System.Threading.CancellationToken)')
- [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [QueryProjectsAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-QueryProjectsAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility.QueryProjectsAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [QuerySolutionAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-QuerySolutionAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ISolutionSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility.QuerySolutionAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [UpdateProjectsAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-UpdateProjectsAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility.UpdateProjectsAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')
  - [UpdateSolutionAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-UpdateSolutionAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ISolutionSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility.UpdateSolutionAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')
- [WorkspacesExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensionMethods')
  - [AddExistingFileAsync(projectSnapshot,fileToAdd,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-AddExistingFileAsync-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot,System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensionMethods.AddExistingFileAsync(Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot,System.Uri,System.Threading.CancellationToken)')
  - [GetActiveProjectAsync(clientContext,withModifier,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-GetActiveProjectAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensionMethods.GetActiveProjectAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot}},System.Threading.CancellationToken)')
  - [GetActiveProjectAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-GetActiveProjectAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensionMethods.GetActiveProjectAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs'></a>
## AnchoredCommandAddedEventArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Event arguments for when a dynamic command is added to a command set and anchored to a dynamic command anchor.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String-'></a>
### #ctor(command,dynamicCommandAnchorIdentifier) `constructor`

##### Summary

Initializes a new instance of the [AnchoredCommandAddedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.AnchoredCommandAddedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand') | The command that is being added. |
| dynamicCommandAnchorIdentifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The name of the dynamic command anchor that the command should be anchored to. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-AnchoredCommandAddedEventArgs-DynamicCommandAnchorIdentifier'></a>
### DynamicCommandAnchorIdentifier `property`

##### Summary

Gets the name of the dynamic command anchor that this command should be anchored to.

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription'></a>
## ChoiceDescription `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

Describes a choice for a prompt.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-#ctor-System-String-'></a>
### #ctor(text) `constructor`

##### Summary

Initializes a new instance of the [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The text to present to the user. |

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-Text'></a>
### Text `property`

##### Summary

Gets the text of the option.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-FromString-System-String-'></a>
### FromString(choiceText) `method`

##### Summary

Wraps `choiceText` in an [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription').

##### Returns

The option description.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| choiceText | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The option text. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-FromUserPrompOption-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption-'></a>
### FromUserPrompOption(rpcOption) `method`

##### Summary

Gets an equivalent [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription').

##### Returns

The option description.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rpcOption | [Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption') | The rpc prompt option to convert. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-ToUserPromptOption'></a>
### ToUserPromptOption() `method`

##### Summary

Gets an equivalent [UserPromptOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption').

##### Returns

The rpc prompt option.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription'></a>
### op_Implicit(choiceText) `method`

##### Summary

Wraps `choiceText` in an [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| choiceText | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The option text. |

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1'></a>
## ChoiceResultCollection\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

A specialized collection that maps [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') to result types, ordered by index.
Equality for this collection is defined as sequence equality.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ChoiceResultCollection\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1') class.

##### Parameters

This constructor has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription,`0}}-'></a>
### #ctor(choiceResultPairs) `constructor`

##### Summary

Initializes a new instance of the [ChoiceResultCollection\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| choiceResultPairs | [System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,\`0}}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,`0}}') | A collection of pairs mapping [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') to `TResult` values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor-System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption,`0}}-'></a>
### #ctor(internalMap) `constructor`

##### Summary

Initializes a new instance of the [ChoiceResultCollection\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| internalMap | [System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption,\`0}}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption,`0}}') | The mappings from result to [UserPromptOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption'). |

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Count'></a>
### Count `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-InternalMap'></a>
### InternalMap `property`

##### Summary

Gets the internal mapping of [UserPromptOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption') to result value.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Item-System-Int32-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Add-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription,`0-'></a>
### Add(choice,result) `method`

##### Summary

Adds a mapping from result value to choice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| choice | [Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') | The choice description. |
| result | [\`0](#T-`0 '`0') | The result value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.Extensibility.Shell.PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') | Thrown when the `choice` is already mapped. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Equals-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection{`0}-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-Command'></a>
## Command `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(extensibility) `constructor`

##### Summary

Initializes a new instance of the [Command](#T-Microsoft-VisualStudio-Extensibility-Commands-Command 'Microsoft.VisualStudio.Extensibility.Commands.Command') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-CommandConfiguration'></a>
### CommandConfiguration `property`

##### Summary

Gets the configuration for this command. The value of this property is evaluated at compile time
when building the Visual Studio extension.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs'></a>
## CommandAddedEventArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Event arguments for when a dynamic command is added to a command set.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-'></a>
### #ctor(command) `constructor`

##### Summary

Initializes a new instance of the [CommandAddedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand') | The command that is being added. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-Command'></a>
### Command `property`

##### Summary

Gets the command that is being added.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync'></a>
## CommandCallbackAsync `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Async command execution callback.

##### Returns

a Task indicating completion of the task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [T:Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'T:Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Command instance being executed. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs'></a>
## CommandRemovedEventArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Event arguments for when a dynamic command is removed from a command set.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ICommand-'></a>
### #ctor(command) `constructor`

##### Summary

Initializes a new instance of the [CommandRemovedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') | The command that is being added. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-Command'></a>
### Command `property`

##### Summary

Gets the command that is being added.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet'></a>
## CommandSet `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-'></a>
### #ctor(extensibility,container,serviceProvider,commandSetFactory) `constructor`

##### Summary

Initializes a new instance of the [CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance. |
| container | [Microsoft.VisualStudio.Extensibility.Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension') | Extension instance that can be used for sharing state across parts. |
| serviceProvider | [System.IServiceProvider](https://learn.microsoft.com/dotnet/api/System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| commandSetFactory | [Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory') | Factory instance that is used to create the command set (could be same as container instance). |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Item-System-String-'></a>
### Item `property`

##### Summary

Gets a registered command instance on this command set.

##### Returns

an instance of [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') to help with setting command state.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique ID of the command in scope of the command set. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands'></a>
### Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-CompleteCommandRegistrationAsync-System-Threading-CancellationToken-'></a>
### CompleteCommandRegistrationAsync(cancellationToken) `method`

##### Summary

This method is called when all commands have been registered.
This indicates that the command set can now be interacted with.
It also calls initialize on all registered commands and command anchors.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A token to signal cancellation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-GetDynamicCommandAnchor``1'></a>
### GetDynamicCommandAnchor\`\`1() `method`

##### Summary

Gets a registered command instance on this command set.

##### Returns

an instance of [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') to help with setting command state.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type defining the command anchor. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken-'></a>
### InitializeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterAnchoredCommand-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String-'></a>
### RegisterAnchoredCommand(command,dynamicCommandAnchorIdentifier) `method`

##### Summary

Register an existing command implementation that is to be parented to a dynamic command anchor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand') | Command instance to register. |
| dynamicCommandAnchorIdentifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The identifier of the dynamic command anchor that the command should be anchored to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand-'></a>
### RegisterCommand(command) `method`

##### Summary

Register an existing command implementation. This is only for commands that are also registered in extension.json.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') | Command instance to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommandAsync-System-Type-'></a>
### RegisterCommandAsync(commandType) `method`

##### Summary

Registers a command defined by the provided type. This is only for commands that are also registered in extension.json.

##### Returns

Created command instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterCommandAsync``1'></a>
### RegisterCommandAsync\`\`1() `method`

##### Summary

Registers a command from a given type. This is only for commands that are also registered in extension.json.

##### Returns

Created command instance.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-RegisterDynamicCommandAnchorAsync-System-Type-'></a>
### RegisterDynamicCommandAnchorAsync(dynamicCommandAnchorType) `method`

##### Summary

Registers a command anchor defined by the provided type. This is only for command anchors that are also registered in extension.json.

##### Returns

Created command anchor instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dynamicCommandAnchorType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-UnregisterDynamicCommand-System-String-'></a>
### UnregisterDynamicCommand(commandId) `method`

##### Summary

Unregister a command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The ID of the command to unregister. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](https://learn.microsoft.com/dotnet/api/System.ArgumentException 'System.ArgumentException') | Thrown if the command to unregister does not exist. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory'></a>
## CommandSetFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a base class to create factories for command sets. This class is intented to be used by source generators.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider-'></a>
### #ctor(serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](https://learn.microsoft.com/dotnet/api/System.IServiceProvider 'System.IServiceProvider') | Local service provider for extension host services. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-ServiceMoniker'></a>
### ServiceMoniker `property`

##### Summary

Gets the ServiceMoniker for the [ICommandSetProvider](#T-Microsoft-VisualStudio-RpcContracts-Commands-ICommandSetProvider 'Microsoft.VisualStudio.RpcContracts.Commands.ICommandSetProvider') that this provides.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet') | Command set instance that is being initialized. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider'></a>
## CommandSetProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Allows command sets information to be sent over process boundary.
Turns change events into serializable update events.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-#ctor-Microsoft-VisualStudio-RpcContracts-Commands-IUpdateReceiver,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet}-'></a>
### #ctor(updateReceiver,extensibility,container,commandSetCreator) `constructor`

##### Summary

Initializes a new instance of the [CommandSetProvider](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| updateReceiver | [Microsoft.VisualStudio.RpcContracts.Commands.IUpdateReceiver](#T-Microsoft-VisualStudio-RpcContracts-Commands-IUpdateReceiver 'Microsoft.VisualStudio.RpcContracts.Commands.IUpdateReceiver') | The callback to the client to send updates. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Visual Studio extensibility object. |
| container | [Microsoft.VisualStudio.Extensibility.Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension') | Extension instance that can be used for sharing state across parts. |
| commandSetCreator | [System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}') | A delegate to create the command set on demand. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ActivateCommandSetAsync-System-Threading-CancellationToken-'></a>
### ActivateCommandSetAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet},System-Threading-CancellationToken-'></a>
### CreateFactoryAsync(options,extensibility,container,commandSetCreator,cancellationToken) `method`

##### Summary

Create a service broker factory for a CommandSetProvider.

##### Returns

ValueTask returning the ICommandSetProvider service.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.ServiceHub.Framework.ServiceActivationOptions](#T-Microsoft-ServiceHub-Framework-ServiceActivationOptions 'Microsoft.ServiceHub.Framework.ServiceActivationOptions') | Additional options that alter how the service may be activated or provide additional data to the service constructor. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| container | [Microsoft.VisualStudio.Extensibility.Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension') | Extension instance that can be used for sharing state across parts. |
| commandSetCreator | [System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}') | Delegate to create the command set. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync``1-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Threading-CancellationToken-'></a>
### CreateFactoryAsync\`\`1(options,extensibility,container,cancellationToken) `method`

##### Summary

Create a service broker factory for a CommandSetProvider.

##### Returns

ValueTask returning the ICommandSetProvider service.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.ServiceHub.Framework.ServiceActivationOptions](#T-Microsoft-ServiceHub-Framework-ServiceActivationOptions 'Microsoft.ServiceHub.Framework.ServiceActivationOptions') | Additional options that alter how the service may be activated or provide additional data to the service constructor. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| container | [Microsoft.VisualStudio.Extensibility.Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension') | Extension instance that can be used for sharing state across parts. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The command set to be created. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-DeactivateCommandSetAsync-System-Threading-CancellationToken-'></a>
### DeactivateCommandSetAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Disposes managed and native resources held by this instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | `true` if being disposed; `false` if being finalized. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-String,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility'></a>
## ConfigurationExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides the surface area for configuration and extension state management.

<a name='M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [ConfigurationExtensibility](#T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-CreateInstance-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### CreateInstance(extensibilityPoint) `method`

##### Summary

Factory method to create internal instances of [ConfigurationExtensibility](#T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility').

##### Returns

a new instance of [ConfigurationExtensibility](#T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-GetPersistedStateAsync``1-System-String,``0,System-Threading-CancellationToken-'></a>
### GetPersistedStateAsync\`\`1(moniker,defaultValue,cancellationToken) `method`

##### Summary

Gets the persisted value for an extension scoped runtime state.

##### Returns

Value of the moniker if found in persisted state or default value if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Moniker for the entry to get. |
| defaultValue | [\`\`0](#T-``0 '``0') | Default value to return if moniker is not found. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the value. The value is serialized/deserialized using [](#N-System-Text-Json 'System.Text.Json') library. |

##### Remarks

Persisted state monikers are meant for values that persists across sessions but are not user configurable and only
written/retrieved by the extension at runtime.

<a name='M-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility-WritePersistedStateAsync``1-System-String,``0,System-Threading-CancellationToken-'></a>
### WritePersistedStateAsync\`\`1(moniker,value,cancellationToken) `method`

##### Summary

Write a persisted value for an extension scoped runtime state.

##### Returns

A task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Moniker for the entry to write. |
| value | [\`\`0](#T-``0 '``0') | Value to write. The value is serialized/deserialized using [](#N-System-Text-Json 'System.Text.Json') library. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the value. The value is serialized/deserialized using [](#N-System-Text-Json 'System.Text.Json') library. |

##### Remarks

Persisted state monikers are meant for values that persists across sessions but are not user configurable and only
written/retrieved by the extension at runtime.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider'></a>
## DebuggerVisualizerProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Defines a provider of .NET debugger visualizers.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(container,extensibilityObject) `constructor`

##### Summary

Initializes a new instance of the [DebuggerVisualizerProvider](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [Microsoft.VisualStudio.Extensibility.ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') | Extension instance that can be used for sharing state across parts. |
| extensibilityObject | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance to be used by the service implementation. |

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-DebuggerVisualizerProviderConfiguration'></a>
### DebuggerVisualizerProviderConfiguration `property`

##### Summary

Gets the configuration for this debugger visualizer provicer. The value of this property is evaluated at
compile time when building the Visual Studio extension.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-CreateVisualizerAsync-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget,System-Threading-CancellationToken-'></a>
### CreateVisualizerAsync(visualizerTarget,cancellationToken) `method`

##### Summary

Requests the provider to initiate the visualization of a new target object.

##### Returns

An [IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') that will show the representation of the target object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerTarget | [Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget') | The [VisualizerTarget](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget') provides information about the target process
 and object, and can be used to request the data of the target object or replace it. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Remarks

Before returning from this call, the extender should subscribe to
 [](#E-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-StateChanged 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.StateChanged').

 When the user dismisses the visualizer UI, the [IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') will be disposed. The
 extension can dispose `visualizerTarget` to remove the visualizer from the Visual Studio UI.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService'></a>
## DebuggerVisualizerProviderService `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Wrapper object for [DebuggerVisualizerProvider](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider').

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider-'></a>
### #ctor(debuggerVisualizerProvider) `constructor`

##### Summary

Initializes a new instance of the [DebuggerVisualizerProviderService](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| debuggerVisualizerProvider | [Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProvider') | The [DebuggerVisualizerProviderService](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderService') object to wrap. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderService-GetVisualizerAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData,System-Threading-CancellationToken-'></a>
### GetVisualizerAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods'></a>
## DiagnosticsExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services for Langauge Services.

<a name='M-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods-GetDiagnosticsReporter-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility,System-String-'></a>
### GetDiagnosticsReporter(extensibilityPoint,generatorId) `method`

##### Summary

Creates a new diagnostic reporter or gets the previously registered reporter to utilize error list functionality.

##### Returns

an instance of [DiagnosticsReporter](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter') that can be utilized to report/clear diagnostics.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility') | Extensibility object instance. |
| generatorId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique identifier for the component that owns the reporter to be created. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter'></a>
## DiagnosticsReporter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality for extending Visual Studio through brokered services for Langauge Services.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(generatorId,extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [DiagnosticsReporter](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| generatorId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique identifier associated with the owner of this reporter. |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-GeneratorId'></a>
### GeneratorId `property`

##### Summary

Gets the unique identifier associated with the owner of this reporter.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(textDocument,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given open document.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | Text document to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(documentMoniker,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given closed document.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentMoniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | Document URI to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticAsync-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic,System-Threading-CancellationToken-'></a>
### ReportDiagnosticAsync(diagnostic,cancellationToken) `method`

##### Summary

Reports a single diagnostic with `diagnostic` by adding them to the previously reported list.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| diagnostic | [Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') | New diagnostic to report. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticsAsync-System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic},System-Threading-CancellationToken-'></a>
### ReportDiagnosticsAsync(diagnostics,cancellationToken) `method`

##### Summary

Reports diagnostics with `diagnostics` by adding them to the previously reported list.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| diagnostics | [System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic}') | New diagnostics to report. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic'></a>
## DocumentDiagnostic `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Languages

##### Summary

Class that represents a document diagnostic. Contains information about a span of text in a document
that holds an error, warning, information, or hint.

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### #ctor(span,message,errorCode,severity,providerName,helpLink) `constructor`

##### Summary

Initializes a new instance of the [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| span | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | Span that the diagnostic is located on in a specific ITextDocument. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### #ctor(uri,range,message,errorCode,severity,providerName,helpLink) `constructor`

##### Summary

Initializes a new instance of the [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | Uri of the document the diagnostic belongs on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | Location of the document that contains the diagnostic. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-DocumentVersion'></a>
### DocumentVersion `property`

##### Summary

Gets the version of the document this diagnostic is intended for.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ErrorCode'></a>
### ErrorCode `property`

##### Summary

Gets the diagnostic code for the diagnostic.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-HelpLink'></a>
### HelpLink `property`

##### Summary

Gets the uri linked to the diagnostic code for extra information.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Message'></a>
### Message `property`

##### Summary

Gets a localized description of the diagnostic.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ProviderName'></a>
### ProviderName `property`

##### Summary

Gets the localized string describing the tool that generated the diagnostic.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Range'></a>
### Range `property`

##### Summary

Gets the range of the diagnostic in the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Severity'></a>
### Severity `property`

##### Summary

Gets the severity of the diagnostic.

<a name='P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Uri'></a>
### Uri `property`

##### Summary

Gets the document location in the form of a URI path.

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnostic-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### CreateDocumentDiagnostic(range,message,errorCode,severity,providerName,helpLink) `method`

##### Summary

Creates and returns a new instance of a [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') that belongs on an open document.

##### Returns

Newly created [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | Range that the diagnostic is located on in a specific ITextDocumentSnapshot. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

##### Remarks

Passing in a TextRange associated with the diagnostic ensures document versioning in a way that is maintained despite any further edits to the document.

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnosticForClosedDocument-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### CreateDocumentDiagnosticForClosedDocument(uri,range,message,errorCode,severity,providerName,helpLink) `method`

##### Summary

Creates and returns a new instance of a [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') that belongs on a closed document.

##### Returns

Newly created [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | Uri of the document the diagnostic belongs on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | Location of the document that contains the diagnostic. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

##### Remarks

Uri's should exclusively used with closed documnents since the lack of versioning is only safe on documents that are assured to not change.

<a name='T-Microsoft-VisualStudio-Extensibility-DocumentExtensions'></a>
## DocumentExtensions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Extension methods for [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') objects.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-AsTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken-'></a>
### AsTextDocumentAsync(documentSnapshot,extensibility,cancellationToken) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentSnapshot | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document snapshot to operate on. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-CloseAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken-'></a>
### CloseAsync(document,option,extensibility,token) `method`

##### Summary

Closes the view(s) for a [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot').

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document to close. |
| option | [Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption](#T-Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption 'Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption') | An option controlling if and how the document will be saved, if it has unsaved changes. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentExtensions-SaveAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken-'></a>
### SaveAsync(document,extensibility,token) `method`

##### Summary

Saves the contents of a [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot').

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document to save. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility'></a>
## DocumentsExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides the surface area for document management.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-CloseDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,System-Threading-CancellationToken-'></a>
### CloseDocumentAsync(moniker,option,token) `method`

##### Summary

Closes the tab(s) for the document specified by `moniker`.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The moniker of the document to search for. |
| option | [Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption](#T-Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption 'Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption') | An option controlling if and how the document will be saved, if it has unsaved changes. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetOpenDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### GetOpenDocumentAsync(moniker,token) `method`

##### Summary

Returns the open document corresponding to `moniker`.

##### Returns

The matching document, or `null` if a matching document isn't found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetOpenDocumentsAsync-System-Threading-CancellationToken-'></a>
### GetOpenDocumentsAsync(token) `method`

##### Summary

Returns a collection of the documents that are currently open.

##### Returns

A collection of open documents.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-GetTextDocumentSnapshotAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,System-Threading-CancellationToken-'></a>
### GetTextDocumentSnapshotAsync(documentSnapshot,cancellationToken) `method`

##### Summary

Gets a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') from an open document snapshot.

##### Returns

A text document snapshot matching the version of the document snapshot.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentSnapshot | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document to operate on. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.Extensibility.SnapshotVersionNotAvailableException](#T-Microsoft-VisualStudio-Extensibility-SnapshotVersionNotAvailableException 'Microsoft.VisualStudio.Extensibility.SnapshotVersionNotAvailableException') | Thrown when snapshot version is no longer available. |

##### Remarks

This method will either:
  - Get a text document that matches the version of the snapshot.
  - For document snapshots that were not initialized yet, it will force initialize the document and get the initial version.
  - For documents without a version, it will return null as they are not supported.
  - For document snapshots that are no longer open in IDE, it will return null.
  - Will throw [SnapshotVersionNotAvailableException](#T-Microsoft-VisualStudio-Extensibility-SnapshotVersionNotAvailableException 'Microsoft.VisualStudio.Extensibility.SnapshotVersionNotAvailableException') if document is old and is not available anymore, in this case another call to [InitializeDocumentAsync](#M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-InitializeDocumentAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility.InitializeDocumentAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,System.Threading.CancellationToken)') should return a newer version.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-InitializeDocumentAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,System-Threading-CancellationToken-'></a>
### InitializeDocumentAsync(documentSnapshot,token) `method`

##### Summary

Ensures that an uninitialized document snapshot is initialized and gets the most recent snapshot.

##### Returns

Most recent initialized snapshot for the document moniker in the snapshot. May return null if document is no longer opened in IDE.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentSnapshot | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | Document snapshot to initialize that was retrieved from one of the Open methods. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### OpenDocumentAsync(moniker,token) `method`

##### Summary

Opens the document identified by `moniker`.

##### Returns

The document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Remarks

If the document identified by `moniker` is already open,
its [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') is returned.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken-'></a>
### OpenDocumentAsync(moniker,options,token) `method`

##### Summary

Opens the document identified by `moniker`.

##### Returns

The document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The moniker of the document to search for. |
| options | [Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions](#T-Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions 'Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions') | Options defining how to open the document. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Remarks

If the document identified by `moniker` is already open,
its [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') is returned.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenTextDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### OpenTextDocumentAsync(filePath,cancellationToken) `method`

##### Summary

Opens a new text document in IDE for an existing file.

##### Returns

an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') instance representing the new file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The file path to open. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-OpenTextDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken-'></a>
### OpenTextDocumentAsync(filePath,options,cancellationToken) `method`

##### Summary

Opens a new text document in IDE for an existing file.

##### Returns

an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') instance representing the new file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | File path to open. |
| options | [Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions](#T-Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions 'Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions') | Options defining how to open the document. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SaveAllAsync-System-Threading-CancellationToken-'></a>
### SaveAllAsync(token) `method`

##### Summary

Saves all open documents that have unsaved changes.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SaveDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### SaveDocumentAsync(moniker,token) `method`

##### Summary

Saves the document specified by `moniker`.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility-SubscribeAsync-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener,System-String,System-Threading-CancellationToken-'></a>
### SubscribeAsync(listener,filterRegex,token) `method`

##### Summary

Adds a listener for document events.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.  The result of the
task is an object which, when disposed, will remove the event listener.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| listener | [Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener](#T-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener 'Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener') | The event listener. |
| filterRegex | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | An optional regular expression string used to filter events.  If this string is not `null` and
not empty, then events will only be raised for documents whose monikers match the regular expression. |
| token | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Remarks

Before the asynchronous operation completes, the listener will receive an
[OpenedAsync](#M-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener-OpenedAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentEventArgs,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener.OpenedAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentEventArgs,System.Threading.CancellationToken)') event for each open document
whose moniker matches `filterRegex`.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand'></a>
## DynamicCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Class representing a command that is created at runtime without static metadata associated with it.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync-'></a>
### #ctor(extensibility,metadata,executeCommandCallback) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| metadata | [Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata](#T-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata 'Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata') | Metadata defining to the command. |
| executeCommandCallback | [Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Callback invoked when the command is executed. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IconName'></a>
### IconName `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IsChecked'></a>
### IsChecked `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-RelativeDisplayOrder'></a>
### RelativeDisplayOrder `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor'></a>
## DynamicCommandAnchor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of an anchor that commands can be dynamically added to and removed from.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-#ctor-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-'></a>
### #ctor(commadSet) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommandAnchor](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commadSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet') | The command set that the anchor belongs to. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-CommandConfiguration'></a>
### CommandConfiguration `property`

##### Summary

Gets the configuration for this command anchor. The value of this property is evaluated at compile time
when building the Visual Studio extension.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-AddCommand-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync-'></a>
### AddCommand(metadata,commandHandler) `method`

##### Summary

Register a command instance using command name and handler and anchor it to this group.

##### Returns

Returns the registers command instance to set command state if required.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| metadata | [Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata](#T-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata 'Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata') | Metadata related to the command that is being registered. |
| commandHandler | [Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Command handler. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-RemoveCommand-System-String-'></a>
### RemoveCommand(commandId) `method`

##### Summary

Unregister a command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The ID of the command to unregister. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](https://learn.microsoft.com/dotnet/api/System.ArgumentException 'System.ArgumentException') | Thrown if the command to unregister does not exist. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler'></a>
## ExecutableCommandHandler `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of a command that can be executed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String-'></a>
### #ctor(extensibility,id) `constructor`

##### Summary

Initializes a new instance of the [ExecutableCommandHandler](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| id | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The unique ID of the command or `null` to use the full name of the command class. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-DisableDuringExecution'></a>
### DisableDuringExecution `property`

##### Summary

Gets or sets a value indicating whether command should be disabled when it is executing to avoid multiple invocations at the same time.

##### Remarks

By default, this is set to false so command state will not be modified during execution.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the Visual Studio extensibility point.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-IsEnabled'></a>
### IsEnabled `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommandHandler-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync(context,cancellationToken) `method`

##### Summary

Raised when command is executed on the client.

##### Returns

a Task indication completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context at the time of command execution. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints'></a>
## ExtensibilityPoints `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Helper extension methods.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Configuration-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Configuration(extensibility) `method`

##### Summary

Gets the surface for Configuration related features including extension state and user configuration.

##### Returns

An instance of [ConfigurationExtensibility](#T-Microsoft-VisualStudio-Extensibility-ConfigurationExtensibility 'Microsoft.VisualStudio.Extensibility.ConfigurationExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Documents-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Documents(extensibility) `method`

##### Summary

Gets the surface area for document management.

##### Returns

an instance of [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.DocumentsExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Languages-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Languages(extensibility) `method`

##### Summary

Gets the surface for Language service features such as diagnostics management.

##### Returns

an instance of [LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Shell-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Shell(extensibility) `method`

##### Summary

Gets the surface for Shell service features such as progress reporting and notifications.

##### Returns

An instance of [ShellExtensibility](#T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Views-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Views(extensibility) `method`

##### Summary

Gets the surface area for View management such as output windows, tool windows.

##### Returns

an instance of [ViewsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Workspaces-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Workspaces(extensibility) `method`

##### Summary

Gets the surface for Workspace management such as querying items in projects.

##### Returns

an instance of [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='T-Microsoft-VisualStudio-Extensibility-Extension'></a>
## Extension `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Base class for an extension that can host multiple service instances.

##### Remarks

The instance act as the shared instance similar to previous VSPackage concept.

<a name='P-Microsoft-VisualStudio-Extensibility-Extension-CommandSet'></a>
### CommandSet `property`

##### Summary

Gets the extension's CommandSet.

<a name='M-Microsoft-VisualStudio-Extensibility-Extension-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet') | Command set instance that is being initialized. |

<a name='M-Microsoft-VisualStudio-Extensibility-Extension-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### InitializeServices() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionMethods'></a>
## ExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Container for client context at the time of a command invocation.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### GetActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the active text view on the IDE at the time context was created.

##### Returns

an instance of [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') if there is an active text view, otherwise null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetSelectedPathAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### GetSelectedPathAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the selected item path on the local machine from the current workspace tree.

##### Returns

A collection of workspace item monikers that can be used across workspace queries.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor,. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowPromptAsync``1-Microsoft-VisualStudio-Extensibility-IClientContext,System-String,Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0},System-Threading-CancellationToken-'></a>
### ShowPromptAsync\`\`1(clientContext,message,options,cancellationToken) `method`

##### Summary

Prompts the user with specified `message` and `options`,
waiting for the user to make a choice or dismiss the prompt without a selection.

##### Returns

The mapped result value of the choice defined in `options`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The prompt message to show the user. |
| options | [Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0} 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{``0}') | The options to configure the prompt. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result value. |

##### Remarks

If `cancellationToken` is triggered, a visible prompt will be force closed.
In this case the return value is undefined and should be discarded.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowUserPromptImplAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-String,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption},System-UInt32,System-Threading-CancellationToken-'></a>
### ShowUserPromptImplAsync(clientContext,message,options,defaultOptionIndex,cancellationToken) `method`

##### Summary

Prompts the user with the specific text and options,
and waits for the user to select an option or dismiss the prompt.

##### Returns

The result of the prompt.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The prompt to show to the user. |
| options | [System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption}') | The options. |
| defaultOptionIndex | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The index of the default option. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ICommand'></a>
## ICommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command implementation.
A command can implement multiple interfaces to define what capabilities it has.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets the display name for the command, or `null`
if the display name comes from registered metadata.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Flags'></a>
### Flags `property`

##### Summary

Gets the flags associated with the command.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Id'></a>
### Id `property`

##### Summary

Gets a unique id for this command within its command set.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-IsVisible'></a>
### IsVisible `property`

##### Summary

Gets a value indicating whether this command is visible, or `null`
to determine the enabled state from registered metadata. Setting this value to null will fall back to using the
registered metadata context rule if one was provided.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-TooltipText'></a>
### TooltipText `property`

##### Summary

Gets the tooltip text for the command, or the display name
if no tooltip text was provided.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ICommand-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Completes async initialization of command instance.

##### Returns

Task indication completion of initialization.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Remarks

This method can be used to initialize values that can be retrieved asynchronously in addition to the constructor.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet'></a>
## ICommandSet `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a set of commands.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-Commands'></a>
### Commands `property`

##### Summary

Gets the list of commands for this command set.
Each command must have a unique Id within this collection.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken-'></a>
### InitializeAsync(serviceBroker,cancellationToken) `method`

##### Summary

Allows the command set to initialize asyncronously.

##### Returns

Task to track the asyncronous call status.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | A service broker that can be used to load external servies. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory'></a>
## ICommandSetFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-ServiceMoniker'></a>
### ServiceMoniker `property`

##### Summary

Gets the ServiceMoniker for the [ICommandSetProvider](#T-Microsoft-VisualStudio-RpcContracts-Commands-ICommandSetProvider 'Microsoft.VisualStudio.RpcContracts.Commands.ICommandSetProvider') that this provides.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSet-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSet 'Microsoft.VisualStudio.Extensibility.Commands.CommandSet') | Command set instance that is being initialized. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand'></a>
## IDynamicCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command that can be dynamically created.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-IconName'></a>
### IconName `property`

##### Summary

Gets the name of the icon that should be associated with this command.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-RelativeDisplayOrder'></a>
### RelativeDisplayOrder `property`

##### Summary

Gets the relative display order of the command. Used when determining its specific placement.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand'></a>
## IExecutableCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command that can be invoked.
Enabled status can be set by changing IsEnabled and invoking a [](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged') event.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-IsEnabled'></a>
### IsEnabled `property`

##### Summary

Gets a value indicating whether this command is enabled, or `null`
to determine the enabled state from registered metadata. Setting this value to null will fall back to using the
registered metadata context rule if one was provided.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync(contextProperties,cancellationToken) `method`

##### Summary

Called to invoke the command.

##### Returns

Task to track the asynchronous call status.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextProperties | [System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}') | Captured context properties for this command. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand'></a>
## IToggleCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command that implements a togglable pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand-IsChecked'></a>
### IsChecked `property`

##### Summary

Gets a value indicating whether this command is toggled, or `null`
to determine the toggled state from registered metadata.

<a name='T-System-Runtime-CompilerServices-IsExternalInit'></a>
## IsExternalInit `type`

##### Namespace

System.Runtime.CompilerServices

##### Summary

Used by C# 9 for property `init` accessors.

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility'></a>
## LanguagesExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality for extending Visual Studio through brokered services for Langauge Services.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow'></a>
## OutputWindow `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality to manage an output window channel.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-#ctor-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-'></a>
### #ctor(outputWindow) `constructor`

##### Summary

Initializes a new instance of the [OutputWindow](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindow') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| outputWindow | [Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal') | Output window instance to wrap. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-Writer'></a>
### Writer `property`

##### Summary

Gets the text writer instance to write to the output channel.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindow-DisposeNativeResources'></a>
### DisposeNativeResources() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility'></a>
## OutputWindowExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [OutputWindowExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='F-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-outputWindowChannels'></a>
### outputWindowChannels `constants`

##### Summary

Output window channel can only have a single owner but we have cases in extensions where they may want to get the same channel
from different classes with in the extension so we will cache the instances.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowExtensibility-GetChannelAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### GetChannelAsync(identifier,displayNameResourceId,cancellationToken) `method`

##### Summary

Creates a new output window channel. If a channel exists on the system with the identifier this call will fail.

##### Returns

an instance of [OutputWindowInternal](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique channel identifiers. |
| displayNameResourceId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Resource id to be used as display name for the output window channel. Consider using a pattern like nameof(Resources.MyChannelName). |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](https://learn.microsoft.com/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') | Thrown when output channel is already created in the environment by another component. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal'></a>
## OutputWindowInternal `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality to manage an output window channel.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-#ctor-System-String,System-IO-Pipelines-PipeWriter,System-Text-Encoding,Microsoft-VisualStudio-RpcContracts-OutputChannel-IOutputChannelStore,Microsoft-ServiceHub-Framework-IServiceBroker-'></a>
### #ctor(identifier,writer,encoding,outputChannelStore,serviceBroker) `constructor`

##### Summary

Initializes a new instance of the [OutputWindowInternal](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Service broker instance to utilize. |
| writer | [System.IO.Pipelines.PipeWriter](https://learn.microsoft.com/dotnet/api/System.IO.Pipelines.PipeWriter 'System.IO.Pipelines.PipeWriter') | Pipe writer instance to use for writing. |
| encoding | [System.Text.Encoding](https://learn.microsoft.com/dotnet/api/System.Text.Encoding 'System.Text.Encoding') | Text encoding of the channel. |
| outputChannelStore | [Microsoft.VisualStudio.RpcContracts.OutputChannel.IOutputChannelStore](#T-Microsoft-VisualStudio-RpcContracts-OutputChannel-IOutputChannelStore 'Microsoft.VisualStudio.RpcContracts.OutputChannel.IOutputChannelStore') | Output channel store service instance assigned to this channel. |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Service broker that was used to create the channel store. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-Identifier'></a>
### Identifier `property`

##### Summary

Gets the output window channel identifier.

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-Writer'></a>
### Writer `property`

##### Summary

Gets the text writer instance to write to the output channel.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-CreateChannelAsync-System-String,System-String,System-Text-Encoding,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary,System-Threading-CancellationToken-'></a>
### CreateChannelAsync(identifier,resourceId,encoding,serviceBroker,stringResourceDictionary,cancellationToken) `method`

##### Summary

Creates and initializes an output window channel instance.

##### Returns

an instance of [OutputWindowInternal](#T-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal 'Microsoft.VisualStudio.Extensibility.Documents.OutputWindowInternal').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique channel identifiers. |
| resourceId | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Resource id to be used as display name for the output window channel. |
| encoding | [System.Text.Encoding](https://learn.microsoft.com/dotnet/api/System.Text.Encoding 'System.Text.Encoding') | Text encoding. |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to utilize. |
| stringResourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resoruce dictionary instance to use. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](https://learn.microsoft.com/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') | Thrown when output channel is already created in the environment. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-DisposeManagedResources'></a>
### DisposeManagedResources() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-ReleaseReference'></a>
### ReleaseReference() `method`

##### Summary

Decrement the reference count and dispose the object if ref count is 0 or lower.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-OutputWindowInternal-TryAddReference'></a>
### TryAddReference() `method`

##### Summary

Increment the reference count before returning a wrapper to a new request.

##### Returns

If reft count increment was successful.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand'></a>
## PlaceholderCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of a command that cannot be executed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-#ctor-System-String-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [PlaceholderCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The unique ID of the command or `null` to use the full name of the command class. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-DisplayName'></a>
### DisplayName `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Flags'></a>
### Flags `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-IsDisposed'></a>
### IsDisposed `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-IsVisible'></a>
### IsVisible `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-TooltipText'></a>
### TooltipText `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Disposes the command instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | If true, managed instances should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs-'></a>
### OnPropertyChanged(eventArgs) `method`

##### Summary

Fires [](#E-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-PropertyChanged 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.PropertyChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventArgs | [System.ComponentModel.PropertyChangedEventArgs](https://learn.microsoft.com/dotnet/api/System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs') | The arg to pass to the event. |

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter'></a>
## ProgressReporter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

An entity that inherits [IProgress\`1](https://learn.microsoft.com/dotnet/api/System.IProgress`1 'System.IProgress`1') used by background work running on an extension to report progress.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-#ctor-System-Guid,Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler-'></a>
### #ctor(workId,workProgressHandler) `constructor`

##### Summary

Initializes a new instance of the [ProgressReporter](#T-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| workId | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | Work Id. |
| workProgressHandler | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.IWorkProgressHandler](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.IWorkProgressHandler') | WorkProgressHandler service. |

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-CancellationToken'></a>
### CancellationToken `property`

##### Summary

Gets the cancellation token that provides to the extension for cancelling an ongoing background work.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object is disposed.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Dispose-System-Boolean-'></a>
### Dispose(isDisposing) `method`

##### Summary

Disposes the instance and underlying proxies.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDisposing | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-OnWorkCanceled-System-Object,Microsoft-VisualStudio-RpcContracts-ProgressReporting-WorkCanceledEventArgs-'></a>
### OnWorkCanceled(sender,args) `method`

##### Summary

Cancel the ongoing background work in the extension after [](#E-Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler-WorkCanceled 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.IWorkProgressHandler.WorkCanceled') event has been triggered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](https://learn.microsoft.com/dotnet/api/System.Object 'System.Object') | Sender. |
| args | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.WorkCanceledEventArgs](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-WorkCanceledEventArgs 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.WorkCanceledEventArgs') | WorkCancelledEventArgs. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Report-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressStatus-'></a>
### Report(progressStatus) `method`

##### Summary

Inherited from [IProgress\`1](https://learn.microsoft.com/dotnet/api/System.IProgress`1 'System.IProgress`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| progressStatus | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressStatus](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressStatus 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressStatus') | Progress status of the background work on the extension. |

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-PromptException'></a>
## PromptException `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

Represents errors that occur during use of the User Prompt feature.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

This constructor has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | An error message. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | An error message. |
| innerException | [System.Exception](https://learn.microsoft.com/dotnet/api/System.Exception 'System.Exception') | An inner exception that is the cause of the exception. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](https://learn.microsoft.com/dotnet/api/System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The serialization info. |
| context | [System.Runtime.Serialization.StreamingContext](https://learn.microsoft.com/dotnet/api/System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The streaming context. |

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions'></a>
## PromptOptions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

[PromptOptions\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1') for common user prompt scenarios.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-OK'></a>
### OK `property`

##### Summary

Gets options defining a prompt with an "OK" choice. The prompt returns
`true` when the user selects "OK" or `false` if the user dismisses
the prompt.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-OKCancel'></a>
### OKCancel `property`

##### Summary

Gets options defining a prompt with "OK" and "Cancel" choices.
The default option is "OK". The prompt returns `true` if the
user selects "OK", or `false` if the user either selects "Cancel"
or dissmisses the prompt.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions-RetryCancel'></a>
### RetryCancel `property`

##### Summary

Gets options defining a prompt with "Retry" and "Cancel" choices.
The default option is "Retry". The prompt returns `true` if the
user selects "Retyr", or `false` if the user either selects "Cancel"
or dissmisses the prompt.

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1'></a>
## PromptOptionsWithCancel\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell.Prompt

##### Summary

Describes the options for a prompt which presents choices
to the user and returns the user's selection as a mapped result value.
A "Cancel" choice is automatically added.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0},`0-'></a>
### #ctor(original,cancelReturns) `constructor`

##### Summary

Initializes a new instance of the [PromptOptionsWithCancel\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| original | [Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{\`0}](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0} 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{`0}') | The original options. |
| cancelReturns | [\`0](#T-`0 '`0') | The result value to return when the user selects "Cancel". |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1-WithCancelAsDefault'></a>
### WithCancelAsDefault() `method`

##### Summary

Returns an instance of [PromptOptionsWithCancel\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1') with the [DefaultChoiceIndex](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DefaultChoiceIndex 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.DefaultChoiceIndex')
set to the index of the automatically added "Cancel" choice.

##### Returns

A new instance of [PromptOptionsWithCancel\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1').

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1'></a>
## PromptOptions\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

Describes the options for a prompt which presents choices
to the user and returns the user's selection as a mapped result value.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Describes the options for a prompt which presents choices
to the user and returns the user's selection as a mapped result value.

##### Parameters

This constructor has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection{`0},System-Int32,`0-'></a>
### #ctor(choices,defaultChoiceIndex,dismissedReturns) `constructor`

##### Summary

Initializes a new instance of the [PromptOptions\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| choices | [Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection{\`0}](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection{`0} 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection{`0}') | The choices to present to the user. |
| defaultChoiceIndex | [System.Int32](https://learn.microsoft.com/dotnet/api/System.Int32 'System.Int32') | The index in `choices` of the choice to present as the default. |
| dismissedReturns | [\`0](#T-`0 '`0') | The result value to return when the user dismisses the prompt without making a selection. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-#ctor-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0}-'></a>
### #ctor(original) `constructor`

##### Summary

Initializes a new instance of the [PromptOptions\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| original | [Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{\`0}](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{`0} 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{`0}') | The instance to copy. |

##### Remarks

Overrides the default record copy constructor to make a deep clone of [Choices](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-Choices 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.Choices').

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-Choices'></a>
### Choices `property`

##### Summary

Gets the mappings from result value to option.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DefaultChoiceIndex'></a>
### DefaultChoiceIndex `property`

##### Summary

Gets the index of the choice to present as the default selection.

<a name='P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DismissedReturns'></a>
### DismissedReturns `property`

##### Summary

Gets the result value that should be returned when the user dissmisses the prompt without a selection.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-GetResult-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptResult-'></a>
### GetResult(promptResult) `method`

##### Summary

Gets the mapped result value based on `promptResult`.

##### Returns

[DismissedReturns](#P-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-DismissedReturns 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions`1.DismissedReturns') if the user dismissed the prompt, the mapped result value otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| promptResult | [Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptResult](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptResult 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptResult') | The RPC prompt result. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.Extensibility.Shell.PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') | Thrown when the user selection is not mapped to a result value. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions`1-WithCancel-`0,System-Boolean-'></a>
### WithCancel(cancelReturns,cancelIsDefault) `method`

##### Summary

Adds a new "Cancel" choice to the existing choices.

##### Returns

A new instance of [PromptOptionsWithCancel\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-Prompt-PromptOptionsWithCancel`1 'Microsoft.VisualStudio.Extensibility.Shell.Prompt.PromptOptionsWithCancel`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancelReturns | [\`0](#T-`0 '`0') | The result value to return when selects the "Cancel" choice. |
| cancelIsDefault | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether the "Cancel" choice should be presented as the default choice. |

<a name='T-Microsoft-VisualStudio-Extensibility-Resources'></a>
## Resources `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-CommandIdAlreadyRegistered'></a>
### CommandIdAlreadyRegistered `property`

##### Summary

Looks up a localized string similar to Command ID is already registered..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-CommandSetNotInitializedYet'></a>
### CommandSetNotInitializedYet `property`

##### Summary

Looks up a localized string similar to Cannot interact with the {0} until it has been completely initialized. Do not interact with {1} inside of a command's constructor..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-DynamicCommandAnchorNotFound'></a>
### DynamicCommandAnchorNotFound `property`

##### Summary

Looks up a localized string similar to Dynamic command anchor '{0}' has not been registered with this CommandSet..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString'></a>
### InvalidVersionString `property`

##### Summary

Looks up a localized string similar to Invalid version identifier..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Cancel'></a>
### Prompt_Choice_Cancel `property`

##### Summary

Looks up a localized string similar to Cancel.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_No'></a>
### Prompt_Choice_No `property`

##### Summary

Looks up a localized string similar to No.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_OK'></a>
### Prompt_Choice_OK `property`

##### Summary

Looks up a localized string similar to OK.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Retry'></a>
### Prompt_Choice_Retry `property`

##### Summary

Looks up a localized string similar to Retry.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Yes'></a>
### Prompt_Choice_Yes `property`

##### Summary

Looks up a localized string similar to Yes.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Exception_NoNegativeValues'></a>
### Prompt_Exception_NoNegativeValues `property`

##### Summary

Looks up a localized string similar to Negative values are not supported..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-TraceExtensionStateJsonParseError'></a>
### TraceExtensionStateJsonParseError `property`

##### Summary

Looks up a localized string similar to JSON deserialization failed for moniker {0}, returning default value..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-TraceExtensionStateNotFound'></a>
### TraceExtensionStateNotFound `property`

##### Summary

Looks up a localized string similar to Extension state moniker {0} is not found, returning default value..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-UnsupportedDocumentMoniker'></a>
### UnsupportedDocumentMoniker `property`

##### Summary

Looks up a localized string similar to Unsupported document moniker..

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility'></a>
## ShellExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

Provides functionality to interact with Visual Studio shell services such as progress reporting, notifications, etc.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [ShellExtensibility](#T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility 'Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-GetToolWindow``1'></a>
### GetToolWindow\`\`1() `method`

##### Summary

Gets the tool window of the given type.

##### Returns

The tool window matching the given type or null if not found.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the tool window. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-HideToolWindowAsync-System-Type,System-Threading-CancellationToken-'></a>
### HideToolWindowAsync(toolWindowType,cancellationToken) `method`

##### Summary

Hides the tool window of the given type.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toolWindowType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the tool window. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-HideToolWindowAsync``1-System-Threading-CancellationToken-'></a>
### HideToolWindowAsync\`\`1(cancellationToken) `method`

##### Summary

Hides the tool window of the given type.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the tool window. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ServiceAvailabilityChanged-System-Object,Microsoft-ServiceHub-Framework-BrokeredServicesChangedEventArgs-'></a>
### ServiceAvailabilityChanged(sender,args) `method`

##### Summary

Handles the service instance when availability of brokered services has changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](https://learn.microsoft.com/dotnet/api/System.Object 'System.Object') | Sender. |
| args | [Microsoft.ServiceHub.Framework.BrokeredServicesChangedEventArgs](#T-Microsoft-ServiceHub-Framework-BrokeredServicesChangedEventArgs 'Microsoft.ServiceHub.Framework.BrokeredServicesChangedEventArgs') | BrokeredServicesChangedEventArgs. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-Threading-CancellationToken-'></a>
### ShowDialogAsync(content,cancellationToken) `method`

##### Summary

Shows a modal dialog.

##### Returns

The [DialogResult](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogResult 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult') that represents the button or action invoked by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,System-Threading-CancellationToken-'></a>
### ShowDialogAsync(content,title,cancellationToken) `method`

##### Summary

Shows a modal dialog.

##### Returns

The [DialogResult](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogResult 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult') that represents the button or action invoked by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| title | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The title of the dialog. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-'></a>
### ShowDialogAsync(content,options,cancellationToken) `method`

##### Summary

Shows a modal dialog.

##### Returns

The [DialogResult](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogResult 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult') that represents the button or action invoked by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| options | [Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption') | The options for displaying the dialog. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-'></a>
### ShowDialogAsync(content,title,options,cancellationToken) `method`

##### Summary

Shows a modal dialog.

##### Returns

The [DialogResult](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogResult 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult') that represents the button or action invoked by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| title | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The title of the dialog. |
| options | [Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption') | The options for displaying the dialog. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync-System-Type,System-Boolean,System-Threading-CancellationToken-'></a>
### ShowToolWindowAsync(toolWindowType,activate,cancellationToken) `method`

##### Summary

Shows the tool window of the given type.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toolWindowType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the tool window. |
| activate | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync``1-System-Boolean,System-Threading-CancellationToken-'></a>
### ShowToolWindowAsync\`\`1(activate,cancellationToken) `method`

##### Summary

Shows the tool window of the given type.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activate | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the tool window. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-StartProgressReportingAsync-System-String,Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressReporterOptions,System-Threading-CancellationToken-'></a>
### StartProgressReportingAsync(workDisplayName,options,cancellationToken) `method`

##### Summary

Start progress reporting for background work.

##### Returns

Progress reporter used to report progress for the background work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| workDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Name of the background work. |
| options | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressReporterOptions](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressReporterOptions 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressReporterOptions') | Options for customizing progress reporting behaviors. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-StartProgressReportingAsync-System-String,System-Threading-CancellationToken-'></a>
### StartProgressReportingAsync(workDisplayName,cancellationToken) `method`

##### Summary

Simple overload for starting progress reporting for background work. Work progress is not cancellable by user by default.

##### Returns

Progress reporter used to report progress for the background work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| workDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Name of the background work. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter'></a>
## SynchronizedBufferTextWriter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality to manage an output window channel.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-#ctor-System-IO-Pipelines-PipeWriter,System-Text-Encoding-'></a>
### #ctor(pipeWriter,encoding) `constructor`

##### Summary

Initializes a new instance of the [SynchronizedBufferTextWriter](#T-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pipeWriter | [System.IO.Pipelines.PipeWriter](https://learn.microsoft.com/dotnet/api/System.IO.Pipelines.PipeWriter 'System.IO.Pipelines.PipeWriter') | Pipe writer instance. |
| encoding | [System.Text.Encoding](https://learn.microsoft.com/dotnet/api/System.Text.Encoding 'System.Text.Encoding') | Encoding for strings. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Write-System-ReadOnlySpan{System-Char}-'></a>
### Write() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-WriteLine-System-ReadOnlySpan{System-Char}-'></a>
### WriteLine() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand'></a>
## ToggleCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(extensibility) `constructor`

##### Summary

Initializes a new instance of the [ToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-IsChecked'></a>
### IsChecked `property`

##### Summary

*Inherit from parent.*

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow'></a>
## ToolWindow `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Provides functionality for defining and interacting with a tool window.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(extensibility) `constructor`

##### Summary

Initializes a new instance of the [ToolWindow](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the Visual Studio extensibility point.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Title'></a>
### Title `property`

##### Summary

Gets or sets the title of the tool window.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ToolWindowConfiguration'></a>
### ToolWindowConfiguration `property`

##### Summary

Gets the configuration for this tool window.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether managed resources should be disposed. This should be `false` when
[Dispose](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Dispose(System.Boolean)') is called from a finalizer, `true` otherwise. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-GetContentAsync-System-Threading-CancellationToken-'></a>
### GetContentAsync(cancellationToken) `method`

##### Summary

Gets the tool window's UI content.

##### Returns

An [IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') which represents the tool window's UI content.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress content creation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-HideAsync-System-Threading-CancellationToken-'></a>
### HideAsync(cancellationToken) `method`

##### Summary

Hides the tool window.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Initializes the tool window.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress initialization. |

##### Remarks

This method is called prior to calling [GetContentAsync](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-GetContentAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.GetContentAsync(System.Threading.CancellationToken)') and can be used
for any work that needs to be done prior to creating the tool window's UI content.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnHideAsync-System-Threading-CancellationToken-'></a>
### OnHideAsync(cancellationToken) `method`

##### Summary

Notifies that the tool window is being hidden.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnShowAsync-System-Threading-CancellationToken-'></a>
### OnShowAsync(cancellationToken) `method`

##### Summary

Notifies that the tool window is being shown.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress show. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ShowAsync-System-Boolean,System-Threading-CancellationToken-'></a>
### ShowAsync(activate,cancellationToken) `method`

##### Summary

Shows the tool window.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activate | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer'></a>
## ToolWindowContainer `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

A class for creating and finding tool windows.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-#ctor-System-Diagnostics-TraceSource-'></a>
### #ctor(traceSource) `constructor`

##### Summary

Initializes a new instance of the [ToolWindowContainer](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowContainer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| traceSource | [System.Diagnostics.TraceSource](https://learn.microsoft.com/dotnet/api/System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') | Logger instance that can be used to trace extension actions. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Disposes managed and native resources held by this instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | True if the container is being disposed, false if it's being finalized. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-GetToolWindow-System-IServiceProvider,System-Type-'></a>
### GetToolWindow(serviceProvider,toolWindowType) `method`

##### Summary

Gets the tool window of the given type.

##### Returns

The tool window matching the given type or null if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](https://learn.microsoft.com/dotnet/api/System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| toolWindowType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the tool window. |

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider'></a>
## ToolWindowProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation

##### Summary

A class for managing and interacting with tool windows.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-IServiceProvider,System-Diagnostics-TraceSource-'></a>
### #ctor(container,extensibilityObject,serviceProvider,traceSource) `constructor`

##### Summary

Initializes a new instance of the [ToolWindowProvider](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider 'Microsoft.VisualStudio.Extensibility.ToolWindows.Implementation.ToolWindowProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [Microsoft.VisualStudio.Extensibility.ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') | Extension instance that can be used for sharing state across parts. |
| extensibilityObject | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance to be used by the service implementation. |
| serviceProvider | [System.IServiceProvider](https://learn.microsoft.com/dotnet/api/System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| traceSource | [System.Diagnostics.TraceSource](https://learn.microsoft.com/dotnet/api/System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') | Logger instance that can be used to trace extension actions. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-CreateToolWindowAsync-System-String,System-Threading-CancellationToken-'></a>
### CreateToolWindowAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-GetTitleAsync-System-String,System-Threading-CancellationToken-'></a>
### GetTitleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-GetToolWindow-System-String-'></a>
### GetToolWindow(identifier) `method`

##### Summary

Gets the tool window for the given identifier.

##### Returns

The tool window matching the identifier.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The tool window identifier. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](https://learn.microsoft.com/dotnet/api/System.ArgumentException 'System.ArgumentException') | Thrown if the identifier doesn't match a registered tool window. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-OnHideAsync-System-String,System-Threading-CancellationToken-'></a>
### OnHideAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-OnShowAsync-System-String,System-Threading-CancellationToken-'></a>
### OnShowAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-RegisterToolWindow-System-Type-'></a>
### RegisterToolWindow(toolWindowType) `method`

##### Summary

Registers a tool window with the tool window provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toolWindowType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the tool window. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-Implementation-ToolWindowProvider-SubscribeAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-ToolWindows-ToolWindowPropertyChangedArgs},System-Threading-CancellationToken-'></a>
### SubscribeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility'></a>
## ViewsExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality to interact with Visual Studio view management such as output windows, tool windows.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [ViewsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-Output'></a>
### Output `property`

##### Summary

Gets the output window extensibility point.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient'></a>
## VisualizerObjectSourceClient `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Allows requesting the Visual Studio debugger for the value of a target object.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync-System-Buffers-ReadOnlySequence{System-Byte},System-Threading-CancellationToken-'></a>
### ReplaceTargetObjectAsync(message,cancellationToken) `method`

##### Summary

Requests the visualizer object source in the debug target process to replace the object being visualized.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') tracking the completion of the async call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Buffers.ReadOnlySequence{System.Byte}](https://learn.microsoft.com/dotnet/api/System.Buffers.ReadOnlySequence 'System.Buffers.ReadOnlySequence{System.Byte}') | The content of the message sent to the visualizer object source. The format of
`message` is defined by the chosen visualizer object source. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync-Newtonsoft-Json-Linq-JToken,System-Threading-CancellationToken-'></a>
### ReplaceTargetObjectAsync(message,cancellationToken) `method`

##### Summary

Requests the visualizer object source in the debug target process to replace the object being visualized.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') tracking the completion of the async call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') | The content of the message sent to the visualizer object source. The format of
`message` is defined by the chosen visualizer object source. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-ReplaceTargetObjectAsync``1-``0,Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken-'></a>
### ReplaceTargetObjectAsync\`\`1(message,jsonSerializer,cancellationToken) `method`

##### Summary

Requests the visualizer object source in the debug target process to replace the object being visualized.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') tracking the completion of the async call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The object to be encoded into JSON and sent to the visualizer object source. |
| jsonSerializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | Optional json serializer used to convert `message` to JSON and
convert the returned object from JSON. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMessage | The type of the message encoded into JSON and sent to the visualizer object source. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-System-Nullable{System-Buffers-ReadOnlySequence{System-Byte}},System-Threading-CancellationToken-'></a>
### RequestDataAsync(message,cancellationToken) `method`

##### Summary

Sends a message to the visualizer object source in the debug target process and returns the corresponding
 response.

##### Returns

The optional response to the message. The format of the returned data is defined by the chosen
 visualizer object source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Nullable{System.Buffers.ReadOnlySequence{System.Byte}}](https://learn.microsoft.com/dotnet/api/System.Nullable 'System.Nullable{System.Buffers.ReadOnlySequence{System.Byte}}') | The optional content of the message. The format of `message` is defined
 by the chosen visualizer object source. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetUnavailableException 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException') | When the visualizer target is unavailable or becomes
 unavailable before the call can be completed.

 When this exception is thrown, the attempt to retrieve the value of the object to be visualized should be
 aborted since the visualizer target is now unavailable. When the visualizer target becomes available again, the
 value of the object to be visualized may have changed, so a new value retrieval should be started. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-Newtonsoft-Json-Linq-JToken,System-Threading-CancellationToken-'></a>
### RequestDataAsync(message,cancellationToken) `method`

##### Summary

Sends a message to the visualizer object source in the debug target process and returns the corresponding
 response.

##### Returns

The optional response to the message. The format of the returned data is defined by the chosen
 visualizer object source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') | The content of the message. The format of `message` is defined by the
 chosen visualizer object source. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetUnavailableException 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException') | When the visualizer target is unavailable or becomes
 unavailable before the call can be completed.

 When this exception is thrown, the attempt to retrieve the value of the object to be visualized should be
 aborted since the visualizer target is now unavailable. When the visualizer target becomes available
 again, the value of the object to be visualized may have changed, so a new value retrieval should be started. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync-System-Threading-CancellationToken-'></a>
### RequestDataAsync(cancellationToken) `method`

##### Summary

Sends an empty message to the visualizer object source in the debug target process and returns the corresponding
 response.

##### Returns

The optional response to the message. The format of the returned data is defined by the chosen
 visualizer object source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetUnavailableException 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException') | When the visualizer target is unavailable or becomes
 unavailable before the call can be completed.

 When this exception is thrown, the attempt to retrieve the value of the object to be visualized should be
 aborted since the visualizer target is now unavailable. When the visualizer target becomes available
 again, the value of the object to be visualized may have changed, so a new value retrieval should be started. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync``1-Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken-'></a>
### RequestDataAsync\`\`1(jsonSerializer,cancellationToken) `method`

##### Summary

Sends an empty message to the visualizer object source in the debug target process and returns the corresponding
 response.

##### Returns

The optional response to the message. If `TResponse` is a reference type, this
 method can return `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonSerializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | Optional json serializer used to convert the returned object from JSON. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | The type of the response to be decoded from JSON. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetUnavailableException 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException') | When the visualizer target is unavailable or becomes
 unavailable before the call can be completed.

 When this exception is thrown, the attempt to retrieve the value of the object to be visualized should be
 aborted since the visualizer target is now unavailable. When the visualizer target becomes available
 again, the value of the object to be visualized may have changed, so a new value retrieval should be started. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient-RequestDataAsync``2-``0,Newtonsoft-Json-JsonSerializer,System-Threading-CancellationToken-'></a>
### RequestDataAsync\`\`2(message,jsonSerializer,cancellationToken) `method`

##### Summary

Sends a message to the visualizer object source in the debug target process and returns the corresponding
 response.

##### Returns

The optional response to the message. If `TResponse` is a reference type, this
 method can return `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The object to be encoded into JSON and sent to the visualizer object source. |
| jsonSerializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | Optional json serializer used to convert `message` to JSON and
 convert the returned object from JSON. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMessage | The type of the message encoded into JSON and sent to the visualizer object source. |
| TResponse | The type of the response to be decoded from JSON. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetUnavailableException 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetUnavailableException') | When the visualizer target is unavailable or becomes
 unavailable before the call can be completed.

 When this exception is thrown, the attempt to retrieve the value of the object to be visualized should be
 aborted since the visualizer target is now unavailable. When the visualizer target becomes available
 again, the value of the object to be visualized may have changed, so a new value retrieval should be started. |

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation'></a>
## VisualizerObjectSourceClientImplementation `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Allows requesting the Visual Studio debugger for the value of a target object.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-#ctor-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget-'></a>
### #ctor(visualizerTargetProxy) `constructor`

##### Summary

Initializes a new instance of the [VisualizerObjectSourceClientImplementation](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClientImplementation') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerTargetProxy | [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget') | The visualizer target proxy that is used to communicate with the debugger. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-ReplaceTargetObjectAsync-System-Buffers-ReadOnlySequence{System-Byte},System-Threading-CancellationToken-'></a>
### ReplaceTargetObjectAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClientImplementation-RequestDataAsync-System-Nullable{System-Buffers-ReadOnlySequence{System-Byte}},System-Threading-CancellationToken-'></a>
### RequestDataAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget'></a>
## VisualizerTarget `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Contains information regarding the target process and boject and allows requesting the Visual Studio debugger for
the value of a target object, or to replace the target object.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData-'></a>
### #ctor(objectSource,visualizerTargetData) `constructor`

##### Summary

Initializes a new instance of the [VisualizerTarget](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectSource | [Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceClient 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceClient') | The object source client which can be used to query the object source for the value of
the target object or request the target object to be replaced. |
| visualizerTargetData | [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData') | The metadata associated with this instance of the visualizer target. |

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-IsTargetReplaceable'></a>
### IsTargetReplaceable `property`

##### Summary

Gets a value indicating whether the target value can be replaced by the visualizer.

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-ObjectSource'></a>
### ObjectSource `property`

##### Summary

Gets the object source client which can be used to query the object source for the value of the target object or
request the target object to be replaced.

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeFullName'></a>
### TargetTypeFullName `property`

##### Summary

Gets the [FullName](https://learn.microsoft.com/dotnet/api/System.Type.FullName 'System.Type.FullName') of the target type of the debugger visualizer.

 This is always one of the types for which the debugger visualizer provider declares support: it may not be the
 actual type of the target object but one of its base types or implemented interfaces.

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeModuleName'></a>
### TargetTypeModuleName `property`

##### Summary

Gets the name of the assembly that defines the [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type')[TargetTypeFullName](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeFullName 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.TargetTypeFullName').

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeModuleVersion'></a>
### TargetTypeModuleVersion `property`

##### Summary

Gets the version of the assembly that defines the [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type')[TargetTypeFullName](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-TargetTypeFullName 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.TargetTypeFullName').

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-RaiseStateChangedAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetStateNotification-'></a>
### RaiseStateChangedAsync(notification) `method`

##### Summary

Raises the [](#E-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTarget-StateChanged 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTarget.StateChanged') event.

##### Returns

A [Task](https://learn.microsoft.com/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') tracking the async operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| notification | [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetStateNotification](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetStateNotification 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetStateNotification') | The type of notification. |

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation'></a>
## VisualizerTargetImplementation `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Contains information regarding the target process and boject and allows requesting the Visual Studio debugger for
the value of a target object, or to replace the target object.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-#ctor-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget,Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData-'></a>
### #ctor(visualizerTargetProxy,visualizerTargetData) `constructor`

##### Summary

Initializes a new instance of the [VisualizerTargetImplementation](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetImplementation') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerTargetProxy | [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-IVisualizerTarget 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.IVisualizerTarget') | The visualizer target proxy that is used to communicate with the debugger. |
| visualizerTargetData | [Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData](#T-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetData 'Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers.VisualizerTargetData') | The metadata associated with this instance of the visualizer target. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetImplementation-Microsoft#VisualStudio#RpcContracts#DebuggerVisualizers#IVisualizerTargetClient#NotifyStateChangeAsync-Microsoft-VisualStudio-RpcContracts-DebuggerVisualizers-VisualizerTargetStateNotification,System-Threading-CancellationToken-'></a>
### Microsoft#VisualStudio#RpcContracts#DebuggerVisualizers#IVisualizerTargetClient#NotifyStateChangeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility'></a>
## WorkspacesExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio workspaces.

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.WorkspacesExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-QueryProjectsAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken-'></a>
### QueryProjectsAsync\`\`1(queryFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous query on project items.

##### Returns

Results of the project query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to prepare query. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object being queried. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-QuerySolutionAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ISolutionSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken-'></a>
### QuerySolutionAsync\`\`1(queryFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous query on solution items.

##### Returns

Results of the solution query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to prepare query. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object being queried. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-UpdateProjectsAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken-'></a>
### UpdateProjectsAsync\`\`2(queryFunc,updateFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous update on projects hierarchy.

##### Returns

Results of the solution update actions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to select items to update. |
| updateFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`1}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}}') | Function to update selected items. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TUpdatable | Type of the object being returned as a result of the query selector. |
| TResult | Type of the object being returned as a result of the update actions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensibility-UpdateSolutionAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ISolutionSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken-'></a>
### UpdateSolutionAsync\`\`2(queryFunc,updateFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous update on solutions hierarchy.

##### Returns

Results of the solution update actions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ISolutionSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to select items to update. |
| updateFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`1}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}}') | Function to update selected items. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TUpdatable | Type of the object being returned as a result of the query selector. |
| TResult | Type of the object being returned as a result of the update actions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='T-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods'></a>
## WorkspacesExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Container for client context at the time of a command invocation.

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-AddExistingFileAsync-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot,System-Uri,System-Threading-CancellationToken-'></a>
### AddExistingFileAsync(projectSnapshot,fileToAdd,cancellationToken) `method`

##### Summary

Adds an existing file on disk to the project.

##### Returns

A new [IProjectSnapshot](#T-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot') instance with the file added.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectSnapshot | [Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot](#T-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot') | Project snapshot to add file to. |
| fileToAdd | [System.Uri](https://learn.microsoft.com/dotnet/api/System.Uri 'System.Uri') | an URI representing a local path on disk. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-GetActiveProjectAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot}},System-Threading-CancellationToken-'></a>
### GetActiveProjectAsync(clientContext,withModifier,cancellationToken) `method`

##### Summary

Gets the active project snapshot with [Path](#P-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot-Path 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot.Path') and [Files](#P-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot-Files 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot.Files') information and additional properties added in withModifier callback.
This snapshot can be used to update the project starting with AsUpdatable extension method.

##### Returns

An instance of [IProjectSnapshot](#T-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot') or null if there is no active project or active project no longer exists.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| withModifier | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot}}](https://learn.microsoft.com/dotnet/api/System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot}}') | An additional callback to add more properties to returned project snapshot. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-WorkspacesExtensionMethods-GetActiveProjectAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### GetActiveProjectAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the active project snapshot with [Path](#P-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot-Path 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot.Path') information by default.
This snapshot can be used to update the project starting with AsUpdatable extension method.

##### Returns

An instance of [IProjectSnapshot](#T-Microsoft-VisualStudio-ProjectSystem-Query-IProjectSnapshot 'Microsoft.VisualStudio.ProjectSystem.Query.IProjectSnapshot') or null if there is no active project or active project no longer exists.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

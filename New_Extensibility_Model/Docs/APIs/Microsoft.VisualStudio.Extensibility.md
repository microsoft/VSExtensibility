<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility

## Contents

- [AllowNullAttribute](#T-System-Diagnostics-CodeAnalysis-AllowNullAttribute 'System.Diagnostics.CodeAnalysis.AllowNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-AllowNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.AllowNullAttribute.#ctor')
- [Command](#T-Microsoft-VisualStudio-Extensibility-Commands-Command 'Microsoft.VisualStudio.Extensibility.Commands.Command')
  - [#ctor(extensibility,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16- 'Microsoft.VisualStudio.Extensibility.Commands.Command.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.UInt16)')
  - [BaseDefinitionId](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-BaseDefinitionId 'Microsoft.VisualStudio.Extensibility.Commands.Command.BaseDefinitionId')
  - [DisableDuringExecution](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisableDuringExecution 'Microsoft.VisualStudio.Extensibility.Commands.Command.DisableDuringExecution')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.Command.DisplayName')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-Extensibility 'Microsoft.VisualStudio.Extensibility.Commands.Command.Extensibility')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.InitializeAsync(System.Threading.CancellationToken)')
- [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute')
  - [#ctor(name,id,displayName,containerType,placement,clientContexts)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-#ctor-System-String,System-UInt16,System-String,System-Type,Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.#ctor(System.String,System.UInt16,System.String,System.Type,Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement,System.String)')
  - [ClientContexts](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ClientContexts 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.ClientContexts')
  - [ContainerType](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ContainerType 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.ContainerType')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.DisplayName')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Id 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Id')
  - [Name](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Name 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Name')
  - [Placement](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Placement 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Placement')
- [CommandEnabledWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute.#ctor(System.String,System.String[],System.String[])')
- [CommandHandlerAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync')
- [CommandIconAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute')
  - [#ctor(imageMoniker,iconSettings)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-#ctor-System-String,Microsoft-VisualStudio-Extensibility-Commands-IconSettings- 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.#ctor(System.String,Microsoft.VisualStudio.Extensibility.Commands.IconSettings)')
  - [Icon](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-Icon 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.Icon')
  - [IconSettings](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.IconSettings')
- [CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase')
  - [#ctor(extensibility,container,serviceProvider,commandSetFactory)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.IServiceProvider,Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory)')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Item-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Item(System.String)')
  - [Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Dispose(System.Boolean)')
  - [InitializeAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
  - [RegisterCommand(commandName,commandId,commandHandler)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-System-String,System-UInt16,Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommand(System.String,System.UInt16,Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync)')
  - [RegisterCommand(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommand(Microsoft.VisualStudio.Extensibility.Commands.ICommand)')
  - [RegisterCommandAsync(commandType)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync-System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommandAsync(System.Type)')
  - [RegisterCommandAsync\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync``1 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommandAsync``1')
- [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory')
  - [#ctor(serviceProvider)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.#ctor(System.IServiceProvider)')
  - [#ctor(serviceProvider,container)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.#ctor(System.IServiceProvider,Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands)')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.ServiceMoniker')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
- [CommandSetProvider](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider')
  - [#ctor(updateReceiver,extensibility,container,commandSetCreator)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-#ctor-Microsoft-VisualStudio-RpcContracts-Commands-IUpdateReceiver,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet}- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.#ctor(Microsoft.VisualStudio.RpcContracts.Commands.IUpdateReceiver,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet})')
  - [ActivateCommandSetAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ActivateCommandSetAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.ActivateCommandSetAsync(System.Threading.CancellationToken)')
  - [CreateFactoryAsync(options,extensibility,container,commandSetCreator,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Func{Microsoft-VisualStudio-Extensibility-Commands-ICommandSet},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.CreateFactoryAsync(Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet},System.Threading.CancellationToken)')
  - [CreateFactoryAsync\`\`1(options,extensibility,container,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-CreateFactoryAsync``1-Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.CreateFactoryAsync``1(Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.Threading.CancellationToken)')
  - [DeactivateCommandSetAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-DeactivateCommandSetAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.DeactivateCommandSetAsync(System.Threading.CancellationToken)')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.Dispose(System.Boolean)')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-UInt16,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.ExecuteCommandAsync(System.UInt16,System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [CommandVisibleWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute.#ctor(System.String,System.String[],System.String[])')
- [CommandWithHandler](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithHandler')
  - [#ctor(extensibility,id,handler)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16,Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync- 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithHandler.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.UInt16,Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithHandler.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
- [CommandsPackageAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute')
  - [#ctor(serviceName,versionString)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute.#ctor(System.String,System.String)')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute.ServiceMoniker')
- [CommandsPackageLoadAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageLoadAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageLoadAttribute.#ctor(System.String,System.String[],System.String[])')
- [DiagnosticsExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods')
  - [GetDiagnosticsProvider(extensibilityPoint,generatorId)](#M-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods-GetDiagnosticsProvider-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods.GetDiagnosticsProvider(Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility,System.String)')
- [DiagnosticsProvider](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider')
  - [#ctor(generatorId,extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.#ctor(System.String,Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [GeneratorId](#P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-GeneratorId 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.GeneratorId')
  - [AppendDiagnosticsAsync(textDocument,diagnostics,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.AppendDiagnosticsAsync(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic},System.Threading.CancellationToken)')
  - [AppendDiagnosticsAsync(documentMoniker,diagnostics,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-System-Uri,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.AppendDiagnosticsAsync(System.Uri,System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic},System.Threading.CancellationToken)')
  - [AppendDiagnosticsAsync(documentMoniker,documentVersion,diagnostics,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-System-Uri,System-Int32,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.AppendDiagnosticsAsync(System.Uri,System.Int32,System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic},System.Threading.CancellationToken)')
  - [ClearDiagnosticsAsync(textDocument,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.ClearDiagnosticsAsync(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,System.Threading.CancellationToken)')
  - [ClearDiagnosticsAsync(documentMoniker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.ClearDiagnosticsAsync(System.Uri,System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider.Dispose(System.Boolean)')
- [DisallowNullAttribute](#T-System-Diagnostics-CodeAnalysis-DisallowNullAttribute 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-DisallowNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute.#ctor')
- [DoesNotReturnAttribute](#T-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute-#ctor 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute.#ctor')
- [DoesNotReturnIfAttribute](#T-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')
  - [#ctor(parameterValue)](#M-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.#ctor(System.Boolean)')
  - [ParameterValue](#P-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-ParameterValue 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue')
- [ExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand')
  - [#ctor(id)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-#ctor-System-UInt16- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.#ctor(System.UInt16)')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Id 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.Id')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsDisposed 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.IsDisposed')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.IsEnabled')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Dispose 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.Dispose(System.Boolean)')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
  - [IsValidId(id)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsValidId-System-UInt16- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.IsValidId(System.UInt16)')
  - [OnPropertyChanged(eventArgs)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs)')
- [ExtensibilityPoints](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints')
  - [Languages(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Languages-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Languages(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Views(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Views-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Views(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Workspaces(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Workspaces-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Workspaces(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
- [Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension')
  - [InitializeServices()](#M-Microsoft-VisualStudio-Extensibility-Extension-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Microsoft.VisualStudio.Extensibility.Extension.InitializeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-ExtensionMethods 'Microsoft.VisualStudio.Extensibility.ExtensionMethods')
  - [GetActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [GetSelectedPathAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetSelectedPathAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetSelectedPathAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
- [ExtensionWithCommands](#T-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-#ctor 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands.#ctor')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands.ServiceMoniker')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
- [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Id 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.Id')
- [ICommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet')
  - [Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-Commands 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.Commands')
  - [InitializeAsync(serviceBroker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
- [ICommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.ServiceMoniker')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
- [IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand')
  - [BaseDefinitionId](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-BaseDefinitionId 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.BaseDefinitionId')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.DisplayName')
- [IExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.IsEnabled')
  - [ExecuteCommandAsync(contextProperties,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [IToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand.IsChecked')
- [IconSettings](#T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings')
  - [IconAndText](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconAndText 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconAndText')
  - [IconOnly](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconOnly 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconOnly')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-None 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.None')
- [KnownCommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement')
  - [ExtensionsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ExtensionsMenu 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement.ExtensionsMenu')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-None 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement.None')
  - [ToolsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ToolsMenu 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement.ToolsMenu')
  - [ViewOtherWindowsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ViewOtherWindowsMenu 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement.ViewOtherWindowsMenu')
- [LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
- [MaybeNullAttribute](#T-System-Diagnostics-CodeAnalysis-MaybeNullAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-MaybeNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute.#ctor')
- [MaybeNullWhenAttribute](#T-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute')
  - [#ctor(returnValue)](#M-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.#ctor(System.Boolean)')
  - [ReturnValue](#P-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue')
- [NotNullAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-NotNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.NotNullAttribute.#ctor')
- [NotNullIfNotNullAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute')
  - [#ctor(parameterName)](#M-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-#ctor-System-String- 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.#ctor(System.String)')
  - [ParameterName](#P-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-ParameterName 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName')
- [NotNullWhenAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute')
  - [#ctor(returnValue)](#M-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.#ctor(System.Boolean)')
  - [ReturnValue](#P-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue')
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
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Resources 'Microsoft.VisualStudio.Extensibility.Resources')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Resources.CommandIdAlreadyRegistered')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Resources.Culture')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Resources.InvalidVersionString')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Resources.ResourceManager')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Resources.UnsupportedDocumentMoniker')
- [SynchronizedBufferTextWriter](#T-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter')
  - [#ctor(pipeWriter,encoding)](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-#ctor-System-IO-Pipelines-PipeWriter,System-Text-Encoding- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.#ctor(System.IO.Pipelines.PipeWriter,System.Text.Encoding)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.Dispose(System.Boolean)')
  - [Write()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-Write-System-ReadOnlySpan{System-Char}- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.Write(System.ReadOnlySpan{System.Char})')
  - [WriteLine()](#M-Microsoft-VisualStudio-Extensibility-Documents-SynchronizedBufferTextWriter-WriteLine-System-ReadOnlySpan{System-Char}- 'Microsoft.VisualStudio.Extensibility.Documents.SynchronizedBufferTextWriter.WriteLine(System.ReadOnlySpan{System.Char})')
- [ToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand')
  - [#ctor(extensibility,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16- 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.UInt16)')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.IsChecked')
- [ViewsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [Output](#P-Microsoft-VisualStudio-Extensibility-Documents-ViewsExtensibility-Output 'Microsoft.VisualStudio.Extensibility.Documents.ViewsExtensibility.Output')
- [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [QueryProjectsAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QueryProjectsAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.QueryProjectsAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [QuerySolutionAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QuerySolutionAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.QuerySolutionAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [UpdateProjectsAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateProjectsAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.UpdateProjectsAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')
  - [UpdateSolutionAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateSolutionAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.UpdateSolutionAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')

<a name='T-System-Diagnostics-CodeAnalysis-AllowNullAttribute'></a>
## AllowNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that `null` is allowed as an input even if the
    corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-AllowNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AllowNullAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.AllowNullAttribute 'System.Diagnostics.CodeAnalysis.AllowNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-Command'></a>
## Command `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16-'></a>
### #ctor(extensibility,id) `constructor`

##### Summary

Initializes a new instance of the [Command](#T-Microsoft-VisualStudio-Extensibility-Commands-Command 'Microsoft.VisualStudio.Extensibility.Commands.Command') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Command identifier. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-BaseDefinitionId'></a>
### BaseDefinitionId `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisableDuringExecution'></a>
### DisableDuringExecution `property`

##### Summary

Gets or sets a value indicating whether command should be disabled when it is executing to avoid multiple invocations at the same time.

##### Remarks

By default, this is set to false so command state will not be modified during execution.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisplayName'></a>
### DisplayName `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the Visual Studio extensibility point.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync(context,cancellationToken) `method`

##### Summary

Raised when command is executed on the client.

##### Returns

a Task indication completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context at the time of command execution. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Completes async initialization of command instance.

##### Returns

Task indication completion of initialization.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Remarks

This method can be used to initialize values that can be retrieved asynchronously in addition to the constructor.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute'></a>
## CommandAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the command id (or name in future).

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-#ctor-System-String,System-UInt16,System-String,System-Type,Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement,System-String-'></a>
### #ctor(name,id,displayName,containerType,placement,clientContexts) `constructor`

##### Summary

Initializes a new instance of the [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command name. |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Command identifier. |
| displayName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The default display name for the command. |
| containerType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional container type that should contain the command, this is used for automatic registration of commands. If left null command will be registered to default command set generated during compilation. |
| placement | [Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.KnownCommandPlacement') | Where the command should be parented to in the IDE. |
| clientContexts | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client contexts requested by the command, separated by ','. By default only Shell context is returned. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ClientContexts'></a>
### ClientContexts `property`

##### Summary

Gets the client context categories requested by the command, separated by ','.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ContainerType'></a>
### ContainerType `property`

##### Summary

Gets the command container type if one is specified.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets the initial command display name.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Id'></a>
### Id `property`

##### Summary

Gets the command identifier.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Name'></a>
### Name `property`

##### Summary

Gets the command name.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Placement'></a>
### Placement `property`

##### Summary

Gets where the command should be placed in the IDE.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute'></a>
## CommandEnabledWhenAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify when the command should be enabled.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [CommandEnabledWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Values of each term in the same order as term names array. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync'></a>
## CommandHandlerAsync `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Async command execution handler.

##### Returns

a Task indicating completion of the task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [T:Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync](#T-T-Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync 'T:Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync') | Command instance being executed. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute'></a>
## CommandIconAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the icon to be diplayed with the command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-#ctor-System-String,Microsoft-VisualStudio-Extensibility-Commands-IconSettings-'></a>
### #ctor(imageMoniker,iconSettings) `constructor`

##### Summary

Initializes a new instance of the [CommandIconAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageMoniker | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of a KnownMoniker to be used as the icon for a command. |
| iconSettings | [Microsoft.VisualStudio.Extensibility.Commands.IconSettings](#T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings') | The settings for how to display the icon. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-Icon'></a>
### Icon `property`

##### Summary

Gets the name of the icon.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-IconSettings'></a>
### IconSettings `property`

##### Summary

Gets the settings related to how the command should be displayed.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase'></a>
## CommandSetBase `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-'></a>
### #ctor(extensibility,container,serviceProvider,commandSetFactory) `constructor`

##### Summary

Initializes a new instance of the [CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance. |
| container | [Microsoft.VisualStudio.Extensibility.Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension') | Extension instance that can be used for sharing state across parts. |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| commandSetFactory | [Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory') | Factory instance that is used to create the command set (could be same as container instance). |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Item-System-String-'></a>
### Item `property`

##### Summary

Gets a registered command instance on this command set.

##### Returns

an instance of [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') to help with setting command state.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the command in scope of the command set. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands'></a>
### Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken-'></a>
### InitializeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-System-String,System-UInt16,Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync-'></a>
### RegisterCommand(commandName,commandId,commandHandler) `method`

##### Summary

Register a command instance using command name and handler.

##### Returns

Returns the registeres command instance to set command state if required.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command name to register. |
| commandId | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Command identifier. |
| commandHandler | [Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync') | Command handler. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand-'></a>
### RegisterCommand(command) `method`

##### Summary

Register an existing command implementation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') | Command instance to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync-System-Type-'></a>
### RegisterCommandAsync(commandType) `method`

##### Summary

Registers a command defined by the provided type.

##### Returns

Created command instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync``1'></a>
### RegisterCommandAsync\`\`1() `method`

##### Summary

Registers a command from a given type.
The class provided must have [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute') attribute on the class.

##### Returns

Created command instance.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the command to register. |

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
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Local service provider for extension host services. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-'></a>
### #ctor(serviceProvider,container) `constructor`

##### Summary

Initializes a new instance of the [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Local service provider for extension host services. |
| container | [Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands](#T-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands') | Container that hosts this command set factory. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') | Command set instance that is being initialized. |

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
| commandSetCreator | [System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}') | A delegate to create the command set on demand. |

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
| commandSetCreator | [System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.Extensibility.Commands.ICommandSet}') | Delegate to create the command set. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

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
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if being disposed; `false` if being finalized. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-UInt16,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute'></a>
## CommandVisibleWhenAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify when the command should be visible.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [CommandVisibleWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Values of each term in the same order as term names array. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler'></a>
## CommandWithHandler `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An internal command implementation that executes a handler to support dynamic registration scenarios.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16,Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync-'></a>
### #ctor(extensibility,id,handler) `constructor`

##### Summary

Initializes a new instance of the [CommandWithHandler](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Command identifier in context of the command set. |
| handler | [Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandHandlerAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandHandlerAsync') | Command handler to execute. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithHandler-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync(context,cancellationToken) `method`

##### Summary

Raised when command is executed on the client.

##### Returns

a Task indication completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context at the time of command execution. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute'></a>
## CommandsPackageAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the command id (or name in future).

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-#ctor-System-String,System-String-'></a>
### #ctor(serviceName,versionString) `constructor`

##### Summary

Initializes a new instance of the [CommandsPackageAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Service moniker name. |
| versionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Service moniker version. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-ServiceMoniker'></a>
### ServiceMoniker `property`

##### Summary

Gets the service moniker.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute'></a>
## CommandsPackageLoadAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on commandset classes to specify when the commandset should be loaded.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [CommandsPackageLoadAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageLoadAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Values of each term in the same order as term names array. |

<a name='T-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods'></a>
## DiagnosticsExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services for Langauge Services.

<a name='M-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods-GetDiagnosticsProvider-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility,System-String-'></a>
### GetDiagnosticsProvider(extensibilityPoint,generatorId) `method`

##### Summary

Creates a new diagnostics or gets the previously registered provider to utilize error list functionality.

##### Returns

an instance of [DiagnosticsProvider](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider') that can be utilized to add/append/reset diagnostics.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility') | Extensibility object instance. |
| generatorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique identifier for the component that owns the provider to be created. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider'></a>
## DiagnosticsProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides functionality for extending Visual Studio through brokered services for Langauge Services.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(generatorId,extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [DiagnosticsProvider](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| generatorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique identifier associated with the owner of this provider. |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-GeneratorId'></a>
### GeneratorId `property`

##### Summary

Gets the unique identifier associated with the owner of this provider.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken-'></a>
### AppendDiagnosticsAsync(textDocument,diagnostics,cancellationToken) `method`

##### Summary

Append the diagnostics with `diagnostics` to the previously reported list.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | Text document instance that diagnostic entries are intended for. |
| diagnostics | [System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}') | New diagnostics to append. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-System-Uri,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken-'></a>
### AppendDiagnosticsAsync(documentMoniker,diagnostics,cancellationToken) `method`

##### Summary

Append the diagnostics with `diagnostics` to the previously reported list.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentMoniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Document moniker that diagnostic entries are intended for. |
| diagnostics | [System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}') | New diagnostics to append. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-AppendDiagnosticsAsync-System-Uri,System-Int32,System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-Diagnostic},System-Threading-CancellationToken-'></a>
### AppendDiagnosticsAsync(documentMoniker,documentVersion,diagnostics,cancellationToken) `method`

##### Summary

Append the diagnostics with `diagnostics` to the previously reported list.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentMoniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Document moniker that diagnostic entries are intended for. |
| documentVersion | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Version of the document that diagnostic entries are intended for. |
| diagnostics | [System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.Diagnostic}') | New diagnostics to append. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(textDocument,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given document.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | Text document to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(documentMoniker,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given document.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentMoniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Document moniker to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsProvider-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DisallowNullAttribute'></a>
## DisallowNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that `null` is disallowed as an input even if the
    corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-DisallowNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DisallowNullAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.DisallowNullAttribute 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute'></a>
## DoesNotReturnAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that a method that will never return under any circumstance.

<a name='M-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DoesNotReturnAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute'></a>
## DoesNotReturnIfAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the method will not return if the associated [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')
    parameter is passed the specified value.

<a name='M-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-#ctor-System-Boolean-'></a>
### #ctor(parameterValue) `constructor`

##### Summary

Initializes a new instance of the [DoesNotReturnIfAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')
    class with the specified parameter value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition parameter value.
    Code after the method is considered unreachable by diagnostics if the argument
    to the associated parameter matches this value. |

<a name='P-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-ParameterValue'></a>
### ParameterValue `property`

##### Summary

Gets the condition parameter value.
    Code after the method is considered unreachable by diagnostics if the argument
    to the associated parameter matches this value.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand'></a>
## ExecutableCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of a command that can be executed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-#ctor-System-UInt16-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [ExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The id of the command. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsDisposed'></a>
### IsDisposed `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsEnabled'></a>
### IsEnabled `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Disposes the command instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, managed instances should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsValidId-System-UInt16-'></a>
### IsValidId(id) `method`

##### Summary

Determins if a command id is valid.

##### Returns

Returns `true` if the id is valid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The id to test. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs-'></a>
### OnPropertyChanged(eventArgs) `method`

##### Summary

Fires [](#E-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-PropertyChanged 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.PropertyChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventArgs | [System.ComponentModel.PropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs') | The arg to pass to the event. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints'></a>
## ExtensibilityPoints `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Helper extension methods.

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

an instance of [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility').

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

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### GetActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the active text view on the IDE at the time context was created.

##### Returns

an instance of [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') if there is an active text view, otherwise null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor,. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetSelectedPathAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### GetSelectedPathAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the selected item path on the local machine from the current workspace tree.

##### Returns

A collection of workspace item monikers that can be used across workspace queries.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor,. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands'></a>
## ExtensionWithCommands `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a base class to create extensions that contains a command set.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ExtensionWithCommands](#T-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands 'Microsoft.VisualStudio.Extensibility.Commands.ExtensionWithCommands') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-ServiceMoniker'></a>
### ServiceMoniker `property`

##### Summary

Gets the ServiceMoniker for the [ICommandSetProvider](#T-Microsoft-VisualStudio-RpcContracts-Commands-ICommandSetProvider 'Microsoft.VisualStudio.RpcContracts.Commands.ICommandSetProvider') that this provides.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExtensionWithCommands-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') | Command set instance that is being initialized. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ICommand'></a>
## ICommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command implementation.
A command can implement multiple interfaces to define what capabilities it has.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Id'></a>
### Id `property`

##### Summary

Gets a unique id for this command within its command set.

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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') | Command set instance that is being initialized. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand'></a>
## IDynamicCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command that can be dynamically created and renamed.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-BaseDefinitionId'></a>
### BaseDefinitionId `property`

##### Summary

Gets the id of the registered metadata this command is based on.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets the display name for the command, or `null`
if the display name comes from registered metadata.

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

Gets a value indicating wheather this command is enabled, or `null`
to determine the enabled state from registered metadata.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync(contextProperties,cancellationToken) `method`

##### Summary

Called to invoke the command.

##### Returns

Task to track the asyncronous call status.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextProperties | [System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}') | Captured context properties for this command. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand'></a>
## IToggleCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Represents a command that implements a togglable pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand-IsChecked'></a>
### IsChecked `property`

##### Summary

Gets a value indicating wheather this command is toggled, or `null`
to determine the toggled state from registered metadata.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings'></a>
## IconSettings `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Settings for command icons.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconAndText'></a>
### IconAndText `constants`

##### Summary

In a toolbar, an icon and the display name of the command should be shown to represent in the command.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconOnly'></a>
### IconOnly `constants`

##### Summary

In a toolbar, only the icon should be shown to represent the command. In a menu, only the text will be shown.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-None'></a>
### None `constants`

##### Summary

None.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement'></a>
## KnownCommandPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Known locations that a command can be parented to.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ExtensionsMenu'></a>
### ExtensionsMenu `constants`

##### Summary

A group inside of the Extensions top level menu.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-None'></a>
### None `constants`

##### Summary

The command should not be placed anywhere. It only exists in the command well.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ToolsMenu'></a>
### ToolsMenu `constants`

##### Summary

A group inside of the Tools top level menu.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownCommandPlacement-ViewOtherWindowsMenu'></a>
### ViewOtherWindowsMenu `constants`

##### Summary

A group inside of the View -> Other Windows menu.

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

<a name='T-System-Diagnostics-CodeAnalysis-MaybeNullAttribute'></a>
## MaybeNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that an output may be `null` even if the
    corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-MaybeNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [MaybeNullAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.MaybeNullAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute'></a>
## MaybeNullWhenAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that when a method returns [ReturnValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'), 
    the parameter may be `null` even if the corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-#ctor-System-Boolean-'></a>
### #ctor(returnValue) `constructor`

##### Summary

Initializes the attribute with the specified return value condition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The return value condition.
    If the method returns this value, the associated parameter may be `null`. |

<a name='P-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-ReturnValue'></a>
### ReturnValue `property`

##### Summary

Gets the return value condition.
    If the method returns this value, the associated parameter may be `null`.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullAttribute'></a>
## NotNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that an output is not `null` even if the
    corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [NotNullAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.NotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute'></a>
## NotNullIfNotNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the output will be non-`null` if the
    named parameter is non-`null`.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-#ctor-System-String-'></a>
### #ctor(parameterName) `constructor`

##### Summary

Initializes the attribute with the associated parameter name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The associated parameter name.
    The output will be non-`null` if the argument to the
    parameter specified is non-`null`. |

<a name='P-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-ParameterName'></a>
### ParameterName `property`

##### Summary

Gets the associated parameter name.
    The output will be non-`null` if the argument to the
    parameter specified is non-`null`.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute'></a>
## NotNullWhenAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that when a method returns [ReturnValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'),
    the parameter will not be `null` even if the corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-#ctor-System-Boolean-'></a>
### #ctor(returnValue) `constructor`

##### Summary

Initializes the attribute with the specified return value condition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The return value condition.
    If the method returns this value, the associated parameter will not be `null`. |

<a name='P-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-ReturnValue'></a>
### ReturnValue `property`

##### Summary

Gets the return value condition.
    If the method returns this value, the associated parameter will not be `null`.

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
| identifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique channel identifiers. |
| displayNameResourceId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource id to be used as display name for the output window channel. Consider using a pattern like nameof(Resources.MyChannelName). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when output channel is already created in the environment by another component. |

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
| identifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Service broker instance to utilize. |
| writer | [System.IO.Pipelines.PipeWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Pipelines.PipeWriter 'System.IO.Pipelines.PipeWriter') | Pipe writer instance to use for writing. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | Text encoding of the channel. |
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
| identifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique channel identifiers. |
| resourceId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource id to be used as display name for the output window channel. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | Text encoding. |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to utilize. |
| stringResourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resoruce dictionary instance to use. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when output channel is already created in the environment. |

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

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString'></a>
### InvalidVersionString `property`

##### Summary

Looks up a localized string similar to Invalid version identifier..

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Microsoft-VisualStudio-Extensibility-Resources-UnsupportedDocumentMoniker'></a>
### UnsupportedDocumentMoniker `property`

##### Summary

Looks up a localized string similar to Unsupported document moniker..

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
| pipeWriter | [System.IO.Pipelines.PipeWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Pipelines.PipeWriter 'System.IO.Pipelines.PipeWriter') | Pipe writer instance. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | Encoding for strings. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-UInt16-'></a>
### #ctor(extensibility,id) `constructor`

##### Summary

Initializes a new instance of the [ToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| id | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Command identifier. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-IsChecked'></a>
### IsChecked `property`

##### Summary

*Inherit from parent.*

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

<a name='T-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility'></a>
## WorkspacesExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Workspaces

##### Summary

Provides functionality for extending Visual Studio workspaces.

<a name='M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QueryProjectsAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken-'></a>
### QueryProjectsAsync\`\`1(queryFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous query on project items.

##### Returns

Results of the project query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to prepare query. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object being queried. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QuerySolutionAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken-'></a>
### QuerySolutionAsync\`\`1(queryFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous query on solution items.

##### Returns

Results of the solution query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to prepare query. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object being queried. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateProjectsAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken-'></a>
### UpdateProjectsAsync\`\`2(queryFunc,updateFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous update on projects hierarchy.

##### Returns

Results of the solution update actions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to select items to update. |
| updateFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}}') | Function to update selected items. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TUpdatable | Type of the object being returned as a result of the query selector. |
| TResult | Type of the object being returned as a result of the update actions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateSolutionAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken-'></a>
### UpdateSolutionAsync\`\`2(queryFunc,updateFunc,cancellationToken) `method`

##### Summary

Performs an asynchronous update on solutions hierarchy.

##### Returns

Results of the solution update actions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}}') | Function to select items to update. |
| updateFunc | [System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}}') | Function to update selected items. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TUpdatable | Type of the object being returned as a result of the query selector. |
| TResult | Type of the object being returned as a result of the update actions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException](#T-Microsoft-VisualStudio-ProjectSystem-Query-QueryExecutionException 'Microsoft.VisualStudio.ProjectSystem.Query.QueryExecutionException') | Thrown when query execution is failed. |

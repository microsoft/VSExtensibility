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
  - [#ctor(extensibility,name)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.Command.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.String)')
  - [DisableDuringExecution](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisableDuringExecution 'Microsoft.VisualStudio.Extensibility.Commands.Command.DisableDuringExecution')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-Commands-Command-Extensibility 'Microsoft.VisualStudio.Extensibility.Commands.Command.Extensibility')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-Command-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.Command.InitializeAsync(System.Threading.CancellationToken)')
- [CommandAddedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs')
  - [#ctor(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs.#ctor(Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand)')
  - [Command](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAddedEventArgs-Command 'Microsoft.VisualStudio.Extensibility.Commands.CommandAddedEventArgs.Command')
- [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute')
  - [#ctor(id,displayName,tooltipText,flags,containerType,placement,clientContexts)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-#ctor-System-String,System-String,System-String,Microsoft-VisualStudio-RpcContracts-Commands-CommandFlags,System-Type,Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.#ctor(System.String,System.String,System.String,Microsoft.VisualStudio.RpcContracts.Commands.CommandFlags,System.Type,Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement,System.String)')
  - [ClientContexts](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ClientContexts 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.ClientContexts')
  - [ContainerType](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-ContainerType 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.ContainerType')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.DisplayName')
  - [Flags](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Flags 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Flags')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Id 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Id')
  - [Placement](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Placement 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.Placement')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute.TooltipText')
- [CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync')
- [CommandEnabledWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandEnabledWhenAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute.#ctor(System.String,System.String[],System.String[])')
- [CommandIconAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute')
  - [#ctor(imageMoniker,iconSettings)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-#ctor-System-String,Microsoft-VisualStudio-Extensibility-Commands-IconSettings- 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.#ctor(System.String,Microsoft.VisualStudio.Extensibility.Commands.IconSettings)')
  - [Icon](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-Icon 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.Icon')
  - [IconSettings](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconAttribute-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute.IconSettings')
- [CommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement')
  - [ExtensionsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ExtensionsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.ExtensionsMenu')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-None 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.None')
  - [ToolsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ToolsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.ToolsMenu')
  - [ViewOtherWindowsMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ViewOtherWindowsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.ViewOtherWindowsMenu')
- [CommandRemovedEventArgs](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs')
  - [#ctor(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ICommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ICommand)')
  - [Command](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandRemovedEventArgs-Command 'Microsoft.VisualStudio.Extensibility.Commands.CommandRemovedEventArgs.Command')
- [CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase')
  - [#ctor(extensibility,container,serviceProvider,commandSetFactory)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Extension,System-IServiceProvider,Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Extension,System.IServiceProvider,Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory)')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Item-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Item(System.String)')
  - [Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Microsoft#VisualStudio#Extensibility#Commands#ICommandSet#Commands')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.Dispose(System.Boolean)')
  - [InitializeAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
  - [RegisterAnchoredCommand(command,dynamicCommandAnchorIdentifier)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterAnchoredCommand-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterAnchoredCommand(Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand,System.String)')
  - [RegisterCommand(commandId,commandHandler)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommand(System.String,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [RegisterCommand(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommand(Microsoft.VisualStudio.Extensibility.Commands.ICommand)')
  - [RegisterCommandAsync(commandType)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync-System-Type- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommandAsync(System.Type)')
  - [RegisterCommandAsync\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync``1 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.RegisterCommandAsync``1')
  - [UnregisterDynamicCommand(commandId)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-UnregisterDynamicCommand-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase.UnregisterDynamicCommand(System.String)')
- [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory')
  - [#ctor(serviceProvider)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.#ctor(System.IServiceProvider)')
  - [#ctor(serviceProvider,forceDiscovery)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory.#ctor(System.IServiceProvider,System.Boolean)')
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
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-String,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetProvider.ExecuteCommandAsync(System.String,System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [CommandShortcutAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute')
  - [#ctor(mod1,key1,mod2,key2,activationConstraint)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-#ctor-System-String,System-String,System-String,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.#ctor(System.String,System.String,System.String,System.String,System.String)')
  - [#ctor(mod1,key1,mod2,key2,activationConstraint)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-KnownKey,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-KnownKey,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.KnownKey,Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.KnownKey,System.String)')
  - [ActivationConstraint](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.ActivationConstraint')
  - [Key1](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Key1 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.Key1')
  - [Key2](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Key2 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.Key2')
  - [Mod1](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Mod1 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.Mod1')
  - [Mod2](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Mod2 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute.Mod2')
- [CommandVisibleWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandVisibleWhenAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute.#ctor(System.String,System.String[],System.String[])')
- [CommandWithCallback](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithCallback')
  - [#ctor(extensibility,name,handler)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithCallback.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.String,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithCallback.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
- [CommandsPackageAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute')
  - [#ctor(serviceName,versionString)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute.#ctor(System.String,System.String)')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageAttribute-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageAttribute.ServiceMoniker')
- [CommandsPackageLoadAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageLoadAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandsPackageLoadAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.CommandsPackageLoadAttribute.#ctor(System.String,System.String[],System.String[])')
- [DiagnosticsExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods')
  - [GetDiagnosticsReporter(extensibilityPoint,generatorId)](#M-Microsoft-VisualStudio-Extensibility-DiagnosticsExtensionMethods-GetDiagnosticsReporter-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.DiagnosticsExtensionMethods.GetDiagnosticsReporter(Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility,System.String)')
- [DiagnosticsReporter](#T-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter')
  - [#ctor(generatorId,extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.#ctor(System.String,Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [GeneratorId](#P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-GeneratorId 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.GeneratorId')
  - [ClearDiagnosticsAsync(textDocument,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ClearDiagnosticsAsync(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot,System.Threading.CancellationToken)')
  - [ClearDiagnosticsAsync(documentMoniker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ClearDiagnosticsAsync(System.Uri,System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.Dispose(System.Boolean)')
  - [ReportDiagnosticAsync(diagnostic,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticAsync-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ReportDiagnosticAsync(Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic,System.Threading.CancellationToken)')
  - [ReportDiagnosticsAsync(diagnostics,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticsAsync-System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DiagnosticsReporter.ReportDiagnosticsAsync(System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic},System.Threading.CancellationToken)')
- [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic')
  - [#ctor(span,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [#ctor(uri,range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.#ctor(System.Uri,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [DocumentVersion](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-DocumentVersion 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.DocumentVersion')
  - [ErrorCode](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ErrorCode 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.ErrorCode')
  - [HelpLink](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-HelpLink 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.HelpLink')
  - [Message](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Message 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Message')
  - [ProviderName](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-ProviderName 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.ProviderName')
  - [Range](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Range 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Range')
  - [Severity](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Severity 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Severity')
  - [Uri](#P-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-Uri 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.Uri')
  - [CreateDocumentDiagnostic(range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnostic-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.CreateDocumentDiagnostic(Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
  - [CreateDocumentDiagnosticForClosedDocument(uri,range,message,errorCode,severity,providerName,helpLink)](#M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnosticForClosedDocument-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic.CreateDocumentDiagnosticForClosedDocument(System.Uri,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.String,System.String,Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity,System.String,System.String)')
- [DocumentExtensions](#T-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions 'Microsoft.VisualStudio.Extensibility.Documents.DocumentExtensions')
  - [CloseAsync(document,option,extensibility,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions-CloseAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentExtensions.CloseAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.Threading.CancellationToken)')
  - [SaveAsync(document,extensibility,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions-SaveAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentExtensions.SaveAsync(Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.Threading.CancellationToken)')
- [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [CloseDocumentAsync(moniker,option,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-CloseDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.CloseDocumentAsync(System.Uri,Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption,System.Threading.CancellationToken)')
  - [GetOpenDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-GetOpenDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.GetOpenDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [GetOpenDocumentsAsync(token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-GetOpenDocumentsAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.GetOpenDocumentsAsync(System.Threading.CancellationToken)')
  - [OpenDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-OpenDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.OpenDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [OpenDocumentAsync(moniker,options,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-OpenDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.OpenDocumentAsync(System.Uri,Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions,System.Threading.CancellationToken)')
  - [SaveAllAsync(token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SaveAllAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.SaveAllAsync(System.Threading.CancellationToken)')
  - [SaveDocumentAsync(moniker,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SaveDocumentAsync-System-Uri,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.SaveDocumentAsync(System.Uri,System.Threading.CancellationToken)')
  - [SubscribeAsync(listener,filterRegex,token)](#M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SubscribeAsync-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility.SubscribeAsync(Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener,System.String,System.Threading.CancellationToken)')
- [DynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand')
  - [#ctor(extensibility,id,iconName,relativeDisplayOrder)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String,System-String,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.String,System.String,System.UInt32)')
  - [IconName](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IconName 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.IconName')
  - [RelativeDisplayOrder](#P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-RelativeDisplayOrder 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand.RelativeDisplayOrder')
- [DynamicCommandAnchor](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor')
  - [#ctor(id,commadSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-#ctor-System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.#ctor(System.String,Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
  - [AddCommand(command)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-AddCommand-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.AddCommand(Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand)')
  - [AddCommand(metadata,commandHandler)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-AddCommand-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.AddCommand(Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [RemoveCommand(commandId)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-RemoveCommand-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor.RemoveCommand(System.String)')
- [DynamicCommandWithCallback](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandWithCallback')
  - [#ctor(extensibility,metadata,callback)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandWithCallback.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata,Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync)')
  - [ExecuteCommandAsync(context,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandWithCallback.ExecuteCommandAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
- [ExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.#ctor(System.String)')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.IsEnabled')
  - [ExecuteCommandAsync()](#M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [ExtensibilityPoints](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints')
  - [Documents(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Documents-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Documents(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Languages(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Languages-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Languages(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Shell(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Shell-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Shell(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Views(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Views-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Views(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Workspaces(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Workspaces-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoints.Workspaces(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
- [Extension](#T-Microsoft-VisualStudio-Extensibility-Extension 'Microsoft.VisualStudio.Extensibility.Extension')
  - [CommandSet](#P-Microsoft-VisualStudio-Extensibility-Extension-CommandSet 'Microsoft.VisualStudio.Extensibility.Extension.CommandSet')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Extension-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Extension.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
  - [InitializeServices()](#M-Microsoft-VisualStudio-Extensibility-Extension-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Microsoft.VisualStudio.Extensibility.Extension.InitializeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-ExtensionMethods 'Microsoft.VisualStudio.Extensibility.ExtensionMethods')
  - [GetActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [GetSelectedPathAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-GetSelectedPathAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.GetSelectedPathAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [ShowPromptAsync\`\`1(clientContext,message,options,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowPromptAsync``1-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-String,Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.ShowPromptAsync``1(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.String,Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{``0},System.Threading.CancellationToken)')
  - [ShowUserPromptImplAsync(clientContext,message,options,defaultOptionIndex,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowUserPromptImplAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-String,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption},System-UInt32,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionMethods.ShowUserPromptImplAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.String,System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption},System.UInt32,System.Threading.CancellationToken)')
- [ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.DisplayName')
  - [Flags](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Flags 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.Flags')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-Id 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.Id')
  - [IsVisible](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-IsVisible 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.IsVisible')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommand-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.ICommand.TooltipText')
- [ICommandSet](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet')
  - [Commands](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-Commands 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.Commands')
  - [InitializeAsync(serviceBroker,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSet-InitializeAsync-Microsoft-ServiceHub-Framework-IServiceBroker,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSet.InitializeAsync(Microsoft.ServiceHub.Framework.IServiceBroker,System.Threading.CancellationToken)')
- [ICommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory')
  - [ServiceMoniker](#P-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-ServiceMoniker 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.ServiceMoniker')
  - [InitializeCommandsAsync(commandSet)](#M-Microsoft-VisualStudio-Extensibility-Commands-ICommandSetFactory-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase- 'Microsoft.VisualStudio.Extensibility.Commands.ICommandSetFactory.InitializeCommandsAsync(Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase)')
- [IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand')
  - [IconName](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-IconName 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.IconName')
  - [RelativeDisplayOrder](#P-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand-RelativeDisplayOrder 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand.RelativeDisplayOrder')
- [IExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand')
  - [IsEnabled](#P-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-IsEnabled 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.IsEnabled')
  - [ExecuteCommandAsync(contextProperties,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Commands-IExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Commands.IExecutableCommand.ExecuteCommandAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
- [IToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-IToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.IToggleCommand.IsChecked')
- [IconSettings](#T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings')
  - [IconAndText](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconAndText 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconAndText')
  - [IconOnly](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconOnly 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconOnly')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-None 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.None')
- [IsExternalInit](#T-System-Runtime-CompilerServices-IsExternalInit 'System.Runtime.CompilerServices.IsExternalInit')
- [KnownKey](#T-Microsoft-VisualStudio-Extensibility-Commands-KnownKey 'Microsoft.VisualStudio.Extensibility.Commands.KnownKey')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownKey-None 'Microsoft.VisualStudio.Extensibility.Commands.KnownKey.None')
  - [VK_LBUTTON](#F-Microsoft-VisualStudio-Extensibility-Commands-KnownKey-VK_LBUTTON 'Microsoft.VisualStudio.Extensibility.Commands.KnownKey.VK_LBUTTON')
- [KnownMonikers](#T-Microsoft-VisualStudio-Extensibility-KnownMonikers 'Microsoft.VisualStudio.Extensibility.KnownMonikers')
- [LanguagesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Documents-LanguagesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Documents.LanguagesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
- [ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey')
  - [Control](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Control 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.Control')
  - [LeftAlt](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-LeftAlt 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.LeftAlt')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-None 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.None')
  - [Shift](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Shift 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.Shift')
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
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Resources.Culture')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Resources.InvalidVersionString')
  - [Prompt_Choice_Cancel](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Cancel 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Cancel')
  - [Prompt_Choice_No](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_No 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_No')
  - [Prompt_Choice_OK](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_OK 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_OK')
  - [Prompt_Choice_Retry](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Retry 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Retry')
  - [Prompt_Choice_Yes](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Choice_Yes 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Choice_Yes')
  - [Prompt_Exception_NoNegativeValues](#P-Microsoft-VisualStudio-Extensibility-Resources-Prompt_Exception_NoNegativeValues 'Microsoft.VisualStudio.Extensibility.Resources.Prompt_Exception_NoNegativeValues')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Resources.ResourceManager')
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
  - [#ctor(extensibility,name)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,System.String)')
  - [IsChecked](#P-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-IsChecked 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand.IsChecked')
- [ToolWindow](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow')
  - [#ctor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Extensibility 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Extensibility')
  - [Title](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-Title 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.Title')
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
- [WorkspacesExtensibility](#T-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [QueryProjectsAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QueryProjectsAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.QueryProjectsAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [QuerySolutionAsync\`\`1(queryFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-QuerySolutionAsync``1-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.QuerySolutionAsync``1(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Threading.CancellationToken)')
  - [UpdateProjectsAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateProjectsAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-IProject},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.UpdateProjectsAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.IProject},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')
  - [UpdateSolutionAsync\`\`2(queryFunc,updateFunc,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Workspaces-WorkspacesExtensibility-UpdateSolutionAsync``2-System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{Microsoft-VisualStudio-ProjectSystem-Query-ProjectModel-ISolution},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncQueryable{``0}},System-Func{Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``0},Microsoft-VisualStudio-ProjectSystem-Query-IAsyncUpdatable{``1}},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Workspaces.WorkspacesExtensibility.UpdateSolutionAsync``2(System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{Microsoft.VisualStudio.ProjectSystem.Query.ProjectModel.ISolution},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncQueryable{``0}},System.Func{Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``0},Microsoft.VisualStudio.ProjectSystem.Query.IAsyncUpdatable{``1}},System.Threading.CancellationToken)')

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
| dynamicCommandAnchorIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the dynamic command anchor that the command should be anchored to. |

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
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to present to the user. |

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
| choiceText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The option text. |

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
| choiceText | [System.String)~Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription 'System.String)~Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') | The option text. |

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
| choiceResultPairs | [System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription,`0}}') | A collection of pairs mapping [ChoiceDescription](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceDescription 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceDescription') to `TResult` values. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1-#ctor-System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption,`0}}-'></a>
### #ctor(internalMap) `constructor`

##### Summary

Initializes a new instance of the [ChoiceResultCollection\`1](#T-Microsoft-VisualStudio-Extensibility-Shell-ChoiceResultCollection`1 'Microsoft.VisualStudio.Extensibility.Shell.ChoiceResultCollection`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| internalMap | [System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption,\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption,`0}}') | The mappings from result to [UserPromptOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption 'Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption'). |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Command-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String-'></a>
### #ctor(extensibility,name) `constructor`

##### Summary

Initializes a new instance of the [Command](#T-Microsoft-VisualStudio-Extensibility-Commands-Command 'Microsoft.VisualStudio.Extensibility.Commands.Command') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command identifier. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Command-DisableDuringExecution'></a>
### DisableDuringExecution `property`

##### Summary

Gets or sets a value indicating whether command should be disabled when it is executing to avoid multiple invocations at the same time.

##### Remarks

By default, this is set to false so command state will not be modified during execution.

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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute'></a>
## CommandAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the command name.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-#ctor-System-String,System-String,System-String,Microsoft-VisualStudio-RpcContracts-Commands-CommandFlags,System-Type,Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement,System-String-'></a>
### #ctor(id,displayName,tooltipText,flags,containerType,placement,clientContexts) `constructor`

##### Summary

Initializes a new instance of the [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Globally-unique command ID. |
| displayName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial display name for the command. |
| tooltipText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial tooltip text for the command. If left null defaults to displayName only when the command is a button or toolbar button. |
| flags | [Microsoft.VisualStudio.RpcContracts.Commands.CommandFlags](#T-Microsoft-VisualStudio-RpcContracts-Commands-CommandFlags 'Microsoft.VisualStudio.RpcContracts.Commands.CommandFlags') | The flags for the command. |
| containerType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional container type that should contain the command, this is used for automatic registration of commands. If left null command will be registered to default command set generated during compilation. |
| placement | [Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement') | Where the command should be parented to in the IDE. |
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

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Flags'></a>
### Flags `property`

##### Summary

Gets the flags associated with the command.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Id'></a>
### Id `property`

##### Summary

Gets the command ID.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-Placement'></a>
### Placement `property`

##### Summary

Gets where the command should be placed in the IDE.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute-TooltipText'></a>
### TooltipText `property`

##### Summary

Gets the initial command tooltip text.

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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement'></a>
## CommandPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Known locations that a command can be parented to.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ExtensionsMenu'></a>
### ExtensionsMenu `constants`

##### Summary

A group inside of the Extensions top level menu.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-None'></a>
### None `constants`

##### Summary

The command should not be placed anywhere. It only exists in the command well.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ToolsMenu'></a>
### ToolsMenu `constants`

##### Summary

A group inside of the Tools top level menu.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-ViewOtherWindowsMenu'></a>
### ViewOtherWindowsMenu `constants`

##### Summary

A group inside of the View -> Other Windows menu.

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
| commandId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique ID of the command in scope of the command set. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterAnchoredCommand-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand,System-String-'></a>
### RegisterAnchoredCommand(command,dynamicCommandAnchorIdentifier) `method`

##### Summary

Register an existing command implementation that is to be parented to a dynamic command anchor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-IDynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.IDynamicCommand') | Command instance to register. |
| dynamicCommandAnchorIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier of the dynamic command anchor that the command should be anchored to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync-'></a>
### RegisterCommand(commandId,commandHandler) `method`

##### Summary

Register a command instance using command name and handler. This is only for commands that are also registered in extension.json.

##### Returns

Returns the registers command instance to set command state if required.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command ID to register. |
| commandHandler | [Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Command handler. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommand-Microsoft-VisualStudio-Extensibility-Commands-ICommand-'></a>
### RegisterCommand(command) `method`

##### Summary

Register an existing command implementation. This is only for commands that are also registered in extension.json.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.ICommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ICommand 'Microsoft.VisualStudio.Extensibility.Commands.ICommand') | Command instance to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync-System-Type-'></a>
### RegisterCommandAsync(commandType) `method`

##### Summary

Registers a command defined by the provided type. This is only for commands that are also registered in extension.json.

##### Returns

Created command instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-RegisterCommandAsync``1'></a>
### RegisterCommandAsync\`\`1() `method`

##### Summary

Registers a command from a given type. This is only for commands that are also registered in extension.json.
The class provided must have [CommandAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute') attribute on the class.

##### Returns

Created command instance.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the command to register. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-UnregisterDynamicCommand-System-String-'></a>
### UnregisterDynamicCommand(commandId) `method`

##### Summary

Unregister a command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the command to unregister. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the command to unregister does not exist. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory-#ctor-System-IServiceProvider,System-Boolean-'></a>
### #ctor(serviceProvider,forceDiscovery) `constructor`

##### Summary

Initializes a new instance of the [CommandSetFactory](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetFactory 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Local service provider for extension host services. |
| forceDiscovery | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true command discovery will be executed even if there is a known container type. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandSetProvider-ExecuteCommandAsync-System-String,System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute'></a>
## CommandShortcutAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the command shortcut.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-#ctor-System-String,System-String,System-String,System-String,System-String-'></a>
### #ctor(mod1,key1,mod2,key2,activationConstraint) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First modifier key. |
| key1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First key. |
| mod2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional second key. |
| key2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional second modifier key. |
| activationConstraint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional UI context for the shortcut. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-KnownKey,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-KnownKey,System-String-'></a>
### #ctor(mod1,key1,mod2,key2,activationConstraint) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | First modifier key. |
| key1 | [Microsoft.VisualStudio.Extensibility.Commands.KnownKey](#T-Microsoft-VisualStudio-Extensibility-Commands-KnownKey 'Microsoft.VisualStudio.Extensibility.Commands.KnownKey') | First key. |
| mod2 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | Optional second key. |
| key2 | [Microsoft.VisualStudio.Extensibility.Commands.KnownKey](#T-Microsoft-VisualStudio-Extensibility-Commands-KnownKey 'Microsoft.VisualStudio.Extensibility.Commands.KnownKey') | Optional second modifier key. |
| activationConstraint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional UI context for the shortcut. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-ActivationConstraint'></a>
### ActivationConstraint `property`

##### Summary

Gets the optional UI Context GUID used to scope the shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Key1'></a>
### Key1 `property`

##### Summary

Gets the first key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Key2'></a>
### Key2 `property`

##### Summary

Gets the optional second key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Mod1'></a>
### Mod1 `property`

##### Summary

Gets the first modifier key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutAttribute-Mod2'></a>
### Mod2 `property`

##### Summary

Gets the optional second modifier key for this shortcut.

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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback'></a>
## CommandWithCallback `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An internal command implementation that executes a callback to support dynamic registration scenarios.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync-'></a>
### #ctor(extensibility,name,handler) `constructor`

##### Summary

Initializes a new instance of the [CommandWithCallback](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback 'Microsoft.VisualStudio.Extensibility.Commands.CommandWithCallback') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command identifier in context of the command set. |
| handler | [Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Command handler to execute. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandWithCallback-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
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

An attribute used on CommandsPackage classes to specify the CommandSet.

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
| generatorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique identifier for the component that owns the reporter to be created. |

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
| generatorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique identifier associated with the owner of this reporter. |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-GeneratorId'></a>
### GeneratorId `property`

##### Summary

Gets the unique identifier associated with the owner of this reporter.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(textDocument,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given open document.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot') | Text document to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ClearDiagnosticsAsync-System-Uri,System-Threading-CancellationToken-'></a>
### ClearDiagnosticsAsync(documentMoniker,cancellationToken) `method`

##### Summary

Clears all previous reported diagnostics by this generator for a given closed document.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentMoniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Document URI to clear diagnostic entries for. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

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

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| diagnostic | [Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') | New diagnostic to report. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DiagnosticsReporter-ReportDiagnosticsAsync-System-Collections-Generic-IEnumerable{Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic},System-Threading-CancellationToken-'></a>
### ReportDiagnosticsAsync(diagnostics,cancellationToken) `method`

##### Summary

Reports diagnostics with `diagnostics` by adding them to the previously reported list.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| diagnostics | [System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic}') | New diagnostics to report. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress invocation. |

<a name='T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic'></a>
## DocumentDiagnostic `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Languages

##### Summary

Class that represents a document diagnostic. Contains information about a span of text in a document
that holds an error, warning, information, or hint.

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### #ctor(span,message,errorCode,severity,providerName,helpLink) `constructor`

##### Summary

Initializes a new instance of the [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| span | [Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange') | Span that the diagnostic is located on in a specific ITextDocument. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-#ctor-System-Uri,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### #ctor(uri,range,message,errorCode,severity,providerName,helpLink) `constructor`

##### Summary

Initializes a new instance of the [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Uri of the document the diagnostic belongs on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | Location of the document that contains the diagnostic. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic-CreateDocumentDiagnostic-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange,System-String,System-String,Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity,System-String,System-String-'></a>
### CreateDocumentDiagnostic(range,message,errorCode,severity,providerName,helpLink) `method`

##### Summary

Creates and returns a new instance of a [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic') that belongs on an open document.

##### Returns

Newly created [DocumentDiagnostic](#T-Microsoft-VisualStudio-Extensibility-Languages-DocumentDiagnostic 'Microsoft.VisualStudio.Extensibility.Languages.DocumentDiagnostic').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.Data.TextRange') | Range that the diagnostic is located on in a specific ITextDocumentSnapshot. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

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
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Uri of the document the diagnostic belongs on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | Location of the document that contains the diagnostic. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String of text to be shown as the diagnostic description. |
| errorCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique error code associated with this type of diagnostic. |
| severity | [Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity](#T-Microsoft-VisualStudio-RpcContracts-DiagnosticManagement-DiagnosticSeverity 'Microsoft.VisualStudio.RpcContracts.DiagnosticManagement.DiagnosticSeverity') | Level of severity of the Diagnostic. |
| providerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Localized string describing the tool that generated the diagnostic. |
| helpLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uri to a help page to understand the diagnostic further. |

##### Remarks

Uri's should exclusively used with closed documnents since the lack of versioning is only safe on documents that are assured to not change.

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions'></a>
## DocumentExtensions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Exteension methods for [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') objects.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions-CloseAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken-'></a>
### CloseAsync(document,option,extensibility,token) `method`

##### Summary

Closes the view(s) for a [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot').

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task').representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document to close. |
| option | [Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption](#T-Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption 'Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption') | An option controlling if and how the document will be saved, if it has unsaved changes. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentExtensions-SaveAsync-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-Threading-CancellationToken-'></a>
### SaveAsync(document,extensibility,token) `method`

##### Summary

Saves the contents of a [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot').

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task').representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') | The document to save. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='T-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility'></a>
## DocumentsExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Documents

##### Summary

Provides the surface area for document management.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-CloseDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption,System-Threading-CancellationToken-'></a>
### CloseDocumentAsync(moniker,option,token) `method`

##### Summary

Closes the tab(s) for the document specified by `moniker`.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The moniker of the document to search for. |
| option | [Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption](#T-Microsoft-VisualStudio-RpcContracts-Documents-SaveDocumentOption 'Microsoft.VisualStudio.RpcContracts.Documents.SaveDocumentOption') | An option controlling if and how the document will be saved, if it has unsaved changes. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-GetOpenDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### GetOpenDocumentAsync(moniker,token) `method`

##### Summary

Returns the open document corresponding to `moniker`.

##### Returns

The matching document, or `null` if a matching document isn't found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-GetOpenDocumentsAsync-System-Threading-CancellationToken-'></a>
### GetOpenDocumentsAsync(token) `method`

##### Summary

Returns a collection of the documents that are currently open.

##### Returns

A collection of open documents.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-OpenDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### OpenDocumentAsync(moniker,token) `method`

##### Summary

Opens the document identified by `moniker`.

##### Returns

The document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Remarks

If the document identified by `moniker` is already open,
its [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') is returned.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-OpenDocumentAsync-System-Uri,Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions,System-Threading-CancellationToken-'></a>
### OpenDocumentAsync(moniker,options,token) `method`

##### Summary

Opens the document identified by `moniker`.

##### Returns

The document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The moniker of the document to search for. |
| options | [Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions](#T-Microsoft-VisualStudio-RpcContracts-OpenDocument-OpenDocumentOptions 'Microsoft.VisualStudio.RpcContracts.OpenDocument.OpenDocumentOptions') | Options defining how to open the document. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

##### Remarks

If the document identified by `moniker` is already open,
its [DocumentSnapshot](#T-Microsoft-VisualStudio-RpcContracts-Documents-DocumentSnapshot 'Microsoft.VisualStudio.RpcContracts.Documents.DocumentSnapshot') is returned.

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SaveAllAsync-System-Threading-CancellationToken-'></a>
### SaveAllAsync(token) `method`

##### Summary

Saves all open documents that have unsaved changes.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SaveDocumentAsync-System-Uri,System-Threading-CancellationToken-'></a>
### SaveDocumentAsync(moniker,token) `method`

##### Summary

Saves the document specified by `moniker`.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moniker | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The moniker of the document to search for. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility-SubscribeAsync-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener,System-String,System-Threading-CancellationToken-'></a>
### SubscribeAsync(listener,filterRegex,token) `method`

##### Summary

Adds a listener for document events.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.  The result of the
task is an object which, when disposed, will remove the event listener.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| listener | [Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener](#T-Microsoft-VisualStudio-RpcContracts-Documents-IDocumentEventsListener 'Microsoft.VisualStudio.RpcContracts.Documents.IDocumentEventsListener') | The event listener. |
| filterRegex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An optional regular expression string used to filter events.  If this string is not `null` and
not empty, then events will only be raised for documents whose monikers match the regular expression. |
| token | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String,System-String,System-UInt32-'></a>
### #ctor(extensibility,id,iconName,relativeDisplayOrder) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command identifier. |
| iconName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the icon to be used on the command UI. |
| relativeDisplayOrder | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Used to determine the relative display order of the command within a dynamic command anchor. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-IconName'></a>
### IconName `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-RelativeDisplayOrder'></a>
### RelativeDisplayOrder `property`

##### Summary

*Inherit from parent.*

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor'></a>
## DynamicCommandAnchor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of an anchor that commands can be dynamically added to and removed from.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-#ctor-System-String,Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-'></a>
### #ctor(id,commadSet) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommandAnchor](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the anchor. |
| commadSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') | The command set that the anchor belongs to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchor-AddCommand-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand-'></a>
### AddCommand(command) `method`

##### Summary

Register an existing command implementation and anchor it to this group.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommand 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommand') | Command instance to register. |

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
| commandId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the command to unregister. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the command to unregister does not exist. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback'></a>
## DynamicCommandWithCallback `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An internal command implementation that executes a callback to support dynamic registration scenarios.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata,Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync-'></a>
### #ctor(extensibility,metadata,callback) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommandWithCallback](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandWithCallback') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| metadata | [Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata](#T-Microsoft-VisualStudio-RpcContracts-Commands-CommandMetadata 'Microsoft.VisualStudio.RpcContracts.Commands.CommandMetadata') | Metadata related to the command. |
| callback | [Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandCallbackAsync 'Microsoft.VisualStudio.Extensibility.Commands.CommandCallbackAsync') | Command handler to execute. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandWithCallback-ExecuteCommandAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand'></a>
## ExecutableCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Provides a framework implementation of a command that can be executed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [ExecutableCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand 'Microsoft.VisualStudio.Extensibility.Commands.ExecutableCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the command. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-IsEnabled'></a>
### IsEnabled `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ExecutableCommand-ExecuteCommandAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### ExecuteCommandAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints'></a>
## ExtensibilityPoints `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Helper extension methods.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoints-Documents-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Documents(extensibility) `method`

##### Summary

Gets the surface area for document management.

##### Returns

an instance of [DocumentsExtensibility](#T-Microsoft-VisualStudio-Extensibility-Documents-DocumentsExtensibility 'Microsoft.VisualStudio.Extensibility.Documents.DocumentsExtensibility').

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

<a name='P-Microsoft-VisualStudio-Extensibility-Extension-CommandSet'></a>
### CommandSet `property`

##### Summary

Gets the extension's CommandSet.

<a name='M-Microsoft-VisualStudio-Extensibility-Extension-InitializeCommandsAsync-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase-'></a>
### InitializeCommandsAsync(commandSet) `method`

##### Summary

Called when command set is about to be initialized. This can be used to add commands, set up initial state.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandSet | [Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandSetBase 'Microsoft.VisualStudio.Extensibility.Commands.CommandSetBase') | Command set instance that is being initialized. |

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

an instance of [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') if there is an active text view, otherwise null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context to utilize. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowPromptAsync``1-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-String,Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0},System-Threading-CancellationToken-'></a>
### ShowPromptAsync\`\`1(clientContext,message,options,cancellationToken) `method`

##### Summary

Prompts the user with specified `message` and `options`,
waiting for the user to make a choice or dismiss the prompt without a selection.

##### Returns

The mapped result value of the choice defined in `options`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context to utilize. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The prompt message to show the user. |
| options | [Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptOptions{``0} 'Microsoft.VisualStudio.Extensibility.Shell.PromptOptions{``0}') | The options to configure the prompt. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | The type of the result value. |

##### Remarks

If `cancellationToken` is triggered, a visible prompt will be force closed.
In this case the return value is undefined and should be discarded.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionMethods-ShowUserPromptImplAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-String,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-RpcContracts-Notifications-UserPromptOption},System-UInt32,System-Threading-CancellationToken-'></a>
### ShowUserPromptImplAsync(clientContext,message,options,defaultOptionIndex,cancellationToken) `method`

##### Summary

Prompts the user with the specific text and options,
and waits for the user to select an option or dismiss the prompt.

##### Returns

The result of the prompt.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | Client context to utilize. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The prompt to show to the user. |
| options | [System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.RpcContracts.Notifications.UserPromptOption}') | The options. |
| defaultOptionIndex | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The index of the default option. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token. |

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

Gets a value indicating whether this command is toggled, or `null`
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

<a name='T-System-Runtime-CompilerServices-IsExternalInit'></a>
## IsExternalInit `type`

##### Namespace

System.Runtime.CompilerServices

##### Summary

Used by C# 9 for property `init` accessors.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-KnownKey'></a>
## KnownKey `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Known keys that can be used as a command's shortcut key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownKey-None'></a>
### None `constants`

##### Summary

Empty key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-KnownKey-VK_LBUTTON'></a>
### VK_LBUTTON `constants`

##### Summary

Virtual key codes that are supported as key bindings.

<a name='T-Microsoft-VisualStudio-Extensibility-KnownMonikers'></a>
## KnownMonikers `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

The well-known image monikers for images supplied with the Visual Studio image catalog.

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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey'></a>
## ModifierKey `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Enum containing the modifier keys for shortcuts.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Control'></a>
### Control `constants`

##### Summary

Control key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-LeftAlt'></a>
### LeftAlt `constants`

##### Summary

Left alt key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-None'></a>
### None `constants`

##### Summary

Empty modifier key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Shift'></a>
### Shift `constants`

##### Summary

Shift key.

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
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The unique ID of the command. |

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
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, managed instances should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs-'></a>
### OnPropertyChanged(eventArgs) `method`

##### Summary

Fires [](#E-Microsoft-VisualStudio-Extensibility-Commands-PlaceholderCommand-PropertyChanged 'Microsoft.VisualStudio.Extensibility.Commands.PlaceholderCommand.PropertyChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventArgs | [System.ComponentModel.PropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs') | The arg to pass to the event. |

<a name='T-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter'></a>
## ProgressReporter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Shell

##### Summary

An entity that inherits [IProgress\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress`1 'System.IProgress`1') used by background work running on an extension to report progress.

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-#ctor-System-Guid,Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler-'></a>
### #ctor(workId,workProgressHandler) `constructor`

##### Summary

Initializes a new instance of the [ProgressReporter](#T-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter 'Microsoft.VisualStudio.Extensibility.Shell.ProgressReporter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| workId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Work Id. |
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
| isDisposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-OnWorkCanceled-System-Object,Microsoft-VisualStudio-RpcContracts-ProgressReporting-WorkCanceledEventArgs-'></a>
### OnWorkCanceled(sender,args) `method`

##### Summary

Cancel the ongoing background work in the extension after [](#E-Microsoft-VisualStudio-RpcContracts-ProgressReporting-IWorkProgressHandler-WorkCanceled 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.IWorkProgressHandler.WorkCanceled') event has been triggered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Sender. |
| args | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.WorkCanceledEventArgs](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-WorkCanceledEventArgs 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.WorkCanceledEventArgs') | WorkCancelledEventArgs. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ProgressReporter-Report-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressStatus-'></a>
### Report(progressStatus) `method`

##### Summary

Inherited from [IProgress\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress`1 'System.IProgress`1').

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
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An error message. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An error message. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An inner exception that is the cause of the exception. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-PromptException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Initializes a new instance of the [PromptException](#T-Microsoft-VisualStudio-Extensibility-Shell-PromptException 'Microsoft.VisualStudio.Extensibility.Shell.PromptException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The serialization info. |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The streaming context. |

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
| defaultChoiceIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index in `choices` of the choice to present as the default. |
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
| cancelIsDefault | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the "Cancel" choice should be presented as the default choice. |

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

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toolWindowType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the tool window. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-HideToolWindowAsync``1-System-Threading-CancellationToken-'></a>
### HideToolWindowAsync\`\`1(cancellationToken) `method`

##### Summary

Hides the tool window of the given type.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

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
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Sender. |
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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

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
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The title of the dialog. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

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
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The title of the dialog. |
| options | [Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption') | The options for displaying the dialog. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync-System-Type,System-Boolean,System-Threading-CancellationToken-'></a>
### ShowToolWindowAsync(toolWindowType,activate,cancellationToken) `method`

##### Summary

Shows the tool window of the given type.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toolWindowType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the tool window. |
| activate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowToolWindowAsync``1-System-Boolean,System-Threading-CancellationToken-'></a>
### ShowToolWindowAsync\`\`1(activate,cancellationToken) `method`

##### Summary

Shows the tool window of the given type.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the in-progress request. |

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
| workDisplayName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the background work. |
| options | [Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressReporterOptions](#T-Microsoft-VisualStudio-RpcContracts-ProgressReporting-ProgressReporterOptions 'Microsoft.VisualStudio.RpcContracts.ProgressReporting.ProgressReporterOptions') | Options for customizing progress reporting behaviors. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

<a name='M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-StartProgressReportingAsync-System-String,System-Threading-CancellationToken-'></a>
### StartProgressReportingAsync(workDisplayName,cancellationToken) `method`

##### Summary

Simple overload for starting progress reporting for background work. Work progress is not cancellable by user by default.

##### Returns

Progress reporter used to report progress for the background work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| workDisplayName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the background work. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

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

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,System-String-'></a>
### #ctor(extensibility,name) `constructor`

##### Summary

Initializes a new instance of the [ToggleCommand](#T-Microsoft-VisualStudio-Extensibility-Commands-ToggleCommand 'Microsoft.VisualStudio.Extensibility.Commands.ToggleCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility point to be used for command execution. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Command identifier. |

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
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether managed resources should be disposed. This should be `false` when
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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress content creation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-HideAsync-System-Threading-CancellationToken-'></a>
### HideAsync(cancellationToken) `method`

##### Summary

Hides the tool window.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Initializes the tool window.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress initialization. |

##### Remarks

This method is called prior to calling [GetContentAsync](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-GetContentAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow.GetContentAsync(System.Threading.CancellationToken)') and can be used
for any work that needs to be done prior to creating the tool window's UI content.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnHideAsync-System-Threading-CancellationToken-'></a>
### OnHideAsync(cancellationToken) `method`

##### Summary

Notifies that the tool window is being hidden.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-OnShowAsync-System-Threading-CancellationToken-'></a>
### OnShowAsync(cancellationToken) `method`

##### Summary

Notifies that the tool window is being shown.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress show. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ShowAsync-System-Boolean,System-Threading-CancellationToken-'></a>
### ShowAsync(activate,cancellationToken) `method`

##### Summary

Shows the tool window.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to activate the tool window during the show. Activating a tool window will move focus into it. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress hide. |

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
| traceSource | [System.Diagnostics.TraceSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') | Logger instance that can be used to trace extension actions. |

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
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True if the container is being disposed, false if it's being finalized. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowContainer-GetToolWindow-System-IServiceProvider,System-Type-'></a>
### GetToolWindow(serviceProvider,toolWindowType) `method`

##### Summary

Gets the tool window of the given type.

##### Returns

The tool window matching the given type or null if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| toolWindowType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the tool window. |

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
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Extension host service provider. |
| traceSource | [System.Diagnostics.TraceSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') | Logger instance that can be used to trace extension actions. |

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
| identifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The tool window identifier. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the identifier doesn't match a registered tool window. |

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
| toolWindowType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the tool window. |

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

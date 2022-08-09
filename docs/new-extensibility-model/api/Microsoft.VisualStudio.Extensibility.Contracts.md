<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Contracts

## Contents

- [ActivationContextAttribute](#T-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute.#ctor(System.String,System.String[],System.String[])')
  - [Expression](#P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-Expression 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute.Expression')
  - [TermNames](#P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-TermNames 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute.TermNames')
  - [TermValues](#P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-TermValues 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute.TermValues')
- [Dock](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock')
  - [Bottom](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Bottom 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Bottom')
  - [Left](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Left')
  - [None](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-None 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.None')
  - [Right](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Right 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Right')
  - [Top](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Top 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Top')
- [ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute')
  - [#ctor(rpcContractType,wrapperObjectType)](#M-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-#ctor-System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.#ctor(System.Type,System.Type)')
  - [RpcContractType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-RpcContractType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.RpcContractType')
  - [WrapperObjectType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-WrapperObjectType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.WrapperObjectType')
- [ExtensionPartAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute')
  - [#ctor(interfaceType)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-#ctor-System-Type- 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.#ctor(System.Type)')
  - [InterfaceType](#P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-InterfaceType 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.InterfaceType')
- [HostingOptionsAttribute](#T-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute 'Microsoft.VisualStudio.Extensibility.HostingOptionsAttribute')
  - [#ctor(requiresInProcessHosting)](#M-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute-#ctor-System-Boolean- 'Microsoft.VisualStudio.Extensibility.HostingOptionsAttribute.#ctor(System.Boolean)')
  - [RequiresInProcessHosting](#P-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute-RequiresInProcessHosting 'Microsoft.VisualStudio.Extensibility.HostingOptionsAttribute.RequiresInProcessHosting')
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Contracts-Resources 'Microsoft.VisualStudio.Extensibility.Contracts.Resources')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.CommandIdAlreadyRegistered')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.Culture')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.InvalidVersionString')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ResourceManager')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.UnsupportedDocumentMoniker')
- [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute')
  - [#ctor(serviceName,serviceVersion,factoryType,instanceType,interfaceType)](#M-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-#ctor-System-String,System-String,System-Type,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.#ctor(System.String,System.String,System.Type,System.Type,System.Type)')
  - [FactoryType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-FactoryType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.FactoryType')
  - [InstanceType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InstanceType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.InstanceType')
  - [InterfaceType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InterfaceType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.InterfaceType')
  - [Moniker](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-Moniker 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.Moniker')
- [ToolWindowAttribute](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute')
  - [#ctor(placement,dockDirection,allowAutoCreation)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-#ctor-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-Dock,System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.#ctor(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement,Microsoft.VisualStudio.Extensibility.ToolWindows.Dock,System.Boolean)')
  - [#ctor(placement,dockDirection,allowAutoCreation)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ToolWindows-Dock,System-Boolean- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.#ctor(System.String,Microsoft.VisualStudio.Extensibility.ToolWindows.Dock,System.Boolean)')
  - [AllowAutoCreation](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-AllowAutoCreation 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.AllowAutoCreation')
  - [DockDirection](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-DockDirection 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.DockDirection')
  - [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement')
- [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement')
  - [DocumentWell](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell')
  - [Floating](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating')
- [ToolWindowVisibleWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowVisibleWhenAttribute 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowVisibleWhenAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowVisibleWhenAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowVisibleWhenAttribute.#ctor(System.String,System.String[],System.String[])')

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute'></a>
## ActivationContextAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute base class that describes metadata based on activation context.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [ActivationContextAttribute](#T-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute 'Microsoft.VisualStudio.Extensibility.ActivationContextAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Values of each term in the same order as term names array. |

<a name='P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-Expression'></a>
### Expression `property`

##### Summary

Gets the activation expression.

<a name='P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-TermNames'></a>
### TermNames `property`

##### Summary

Gets the names of the terms used in the expression.

<a name='P-Microsoft-VisualStudio-Extensibility-ActivationContextAttribute-TermValues'></a>
### TermValues `property`

##### Summary

Gets the term values in the same order as term names.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock'></a>
## Dock `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Dock direction that can be used to control how a tool window is docked when it's first shown.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Bottom'></a>
### Bottom `constants`

##### Summary

Docks the tool window below its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left'></a>
### Left `constants`

##### Summary

Docks the tool window to the left of its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-None'></a>
### None `constants`

##### Summary

Docks the tool window alongside its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Right'></a>
### Right `constants`

##### Summary

Docks the tool window to the right of its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Top'></a>
### Top `constants`

##### Summary

Docks the tool window above its placement target.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute'></a>
## ExtensionContractAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Contains additional information about an extension part contract, specifically around wrapping type.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-#ctor-System-Type,System-Type-'></a>
### #ctor(rpcContractType,wrapperObjectType) `constructor`

##### Summary

Initializes a new instance of the [ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rpcContractType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the rpc contract interface. |
| wrapperObjectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the wrapper object. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-RpcContractType'></a>
### RpcContractType `property`

##### Summary

Gets the RPC contract type this interface is intended for.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-WrapperObjectType'></a>
### WrapperObjectType `property`

##### Summary

Gets the wrapper object type.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute'></a>
## ExtensionPartAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute base class that indicates the type of contract provided by the ExtensionPart object.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-#ctor-System-Type-'></a>
### #ctor(interfaceType) `constructor`

##### Summary

Initializes a new instance of the [ExtensionPartAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the interface exposed by this extension part.. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets the contract interface type.

<a name='T-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute'></a>
## HostingOptionsAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute base class that indicates the type of contract provided by the ExtensionPart object.

<a name='M-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute-#ctor-System-Boolean-'></a>
### #ctor(requiresInProcessHosting) `constructor`

##### Summary

Initializes a new instance of the [HostingOptionsAttribute](#T-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute 'Microsoft.VisualStudio.Extensibility.HostingOptionsAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requiresInProcessHosting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, extension is required to be hosted in process. |

<a name='P-Microsoft-VisualStudio-Extensibility-HostingOptionsAttribute-RequiresInProcessHosting'></a>
### RequiresInProcessHosting `property`

##### Summary

Gets a value indicating whether the extension requires to be hosted in process.

<a name='T-Microsoft-VisualStudio-Extensibility-Contracts-Resources'></a>
## Resources `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Contracts

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-CommandIdAlreadyRegistered'></a>
### CommandIdAlreadyRegistered `property`

##### Summary

Looks up a localized string similar to Command ID is already registered..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-InvalidVersionString'></a>
### InvalidVersionString `property`

##### Summary

Looks up a localized string similar to Invalid version identifier..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-UnsupportedDocumentMoniker'></a>
### UnsupportedDocumentMoniker `property`

##### Summary

Looks up a localized string similar to Unsupported document moniker..

<a name='T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute'></a>
## ServiceFactoryRegistrationAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Describes a mapping from service moniker to internal service factory type and extension part instance type.

<a name='M-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-#ctor-System-String,System-String,System-Type,System-Type,System-Type-'></a>
### #ctor(serviceName,serviceVersion,factoryType,instanceType,interfaceType) `constructor`

##### Summary

Initializes a new instance of the [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the service. |
| serviceVersion | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Version of the service. |
| factoryType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Factory class type. |
| instanceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional service object instance class type, if specified the type info will be passed to the factory. |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional interface type, if specified the type info will be passed to factory to determine the wrapper type. |

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-FactoryType'></a>
### FactoryType `property`

##### Summary

Gets the service factory type.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InstanceType'></a>
### InstanceType `property`

##### Summary

Gets the service object instance type.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets the target interface type for this service moniker, should be specified if instance type is implementing multiple interfaces.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-Moniker'></a>
### Moniker `property`

##### Summary

Gets the service moniker.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute'></a>
## ToolWindowAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

An attribute used on ToolWindow classes to register a tool window and define its default behaviors.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-#ctor-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-Dock,System-Boolean-'></a>
### #ctor(placement,dockDirection,allowAutoCreation) `constructor`

##### Summary

Initializes a new instance of the [ToolWindowAttribute](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placement | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The placement location for the tool window. Valid values come from [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement'). |
| dockDirection | [Microsoft.VisualStudio.Extensibility.ToolWindows.Dock](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock') | The direction relative to the placement where the tool window should be docked. |
| allowAutoCreation | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the tool window can be created automatically. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-#ctor-System-String,Microsoft-VisualStudio-Extensibility-ToolWindows-Dock,System-Boolean-'></a>
### #ctor(placement,dockDirection,allowAutoCreation) `constructor`

##### Summary

Initializes a new instance of the [ToolWindowAttribute](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The placement location for the tool window. Valid values come from guids of other tool windows. |
| dockDirection | [Microsoft.VisualStudio.Extensibility.ToolWindows.Dock](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock') | The direction relative to the placement where the tool window should be docked. |
| allowAutoCreation | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the tool window can be created automatically. |

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-AllowAutoCreation'></a>
### AllowAutoCreation `property`

##### Summary

Gets a value indicating whether the tool window can be created automatically.

##### Remarks

When true, the tool window will be created if it should be visible in the current window layout or when any
relevant visibility contexts activate. When false the tool window will not be created as part of loading any
window layout or due to visibility contexts, and the only way to trigger the creation is to manually show it.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-DockDirection'></a>
### DockDirection `property`

##### Summary

Gets the dock direction where the tool window should be placed relative to the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement') value.

##### Remarks

If the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement') has the value [Floating](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating') this value is ignored. If
the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement') has the value [DocumentWell](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell') this value will dock
the tool window to the corresponding side of the main window's document well. If the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement') is
any other value the tool window will be docked relative to the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement') based on the value of the
"Insert new tabs to the right" setting with the exception of [Left](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Left') which will always dock to
the left of the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute.Placement').

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowAttribute-Placement'></a>
### Placement `property`

##### Summary

Gets the default placement location for the tool window. This can be a well-known string from
[ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement'), or the guid string of another tool window.

##### Remarks

If the value is [Floating](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating') the tool window will be created in its own floating
window. If the value is [DocumentWell](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell') the tool window will be docked in
relation to the main window's document well. Any other value will attempt to find the referenced location and
dock the tool window relative to that location, but if that location cannot be found, the tool window will
fallback to opening in a floating window.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement'></a>
## ToolWindowPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Known default tool window placements.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell'></a>
### DocumentWell `constants`

##### Summary

Places the tool window in the active document well by default.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating'></a>
### Floating `constants`

##### Summary

Places the tool window in a standalone floating window by default.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowVisibleWhenAttribute'></a>
## ToolWindowVisibleWhenAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

An attribute used on ToolWindow classes to register a visibility context for showing a tool window.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowVisibleWhenAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [ToolWindowVisibleWhenAttribute](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowVisibleWhenAttribute 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowVisibleWhenAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The names of the terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The values of each term in the same order as term names array. |

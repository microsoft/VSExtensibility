<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Contracts

## Contents

- [ActivationContextAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute')
  - [#ctor(expression,termNames,termValues)](#M-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-#ctor-System-String,System-String[],System-String[]- 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute.#ctor(System.String,System.String[],System.String[])')
  - [Expression](#P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-Expression 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute.Expression')
  - [TermNames](#P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-TermNames 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute.TermNames')
  - [TermValues](#P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-TermValues 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute.TermValues')
- [ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute')
  - [#ctor(rpcContractType,wrapperObjectType)](#M-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-#ctor-System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.#ctor(System.Type,System.Type)')
  - [RpcContractType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-RpcContractType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.RpcContractType')
  - [WrapperObjectType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-WrapperObjectType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.WrapperObjectType')
- [ExtensionPartAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute')
  - [#ctor(interfaceType)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-#ctor-System-Type- 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.#ctor(System.Type)')
  - [InterfaceType](#P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-InterfaceType 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.InterfaceType')
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

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute'></a>
## ActivationContextAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute base class that describes metadata based on activation context.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-#ctor-System-String,System-String[],System-String[]-'></a>
### #ctor(expression,termNames,termValues) `constructor`

##### Summary

Initializes a new instance of the [ActivationContextAttribute](#T-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute 'Microsoft.VisualStudio.Extensibility.Commands.ActivationContextAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Boolean expression string. |
| termNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of terms used in the expression. |
| termValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Values of each term in the same order as term names array. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-Expression'></a>
### Expression `property`

##### Summary

Gets the activation expression.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-TermNames'></a>
### TermNames `property`

##### Summary

Gets the name of the terms used in the expression.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ActivationContextAttribute-TermValues'></a>
### TermValues `property`

##### Summary

Gets the term values in the same order as term names.

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

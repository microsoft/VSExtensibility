<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Framework

## Contents

- [ClientContext](#T-Microsoft-VisualStudio-Extensibility-ClientContext 'Microsoft.VisualStudio.Extensibility.ClientContext')
  - [#ctor(contextProperties,extensibility)](#M-Microsoft-VisualStudio-Extensibility-ClientContext-#ctor-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ClientContext.#ctor(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ClientContext-Extensibility 'Microsoft.VisualStudio.Extensibility.ClientContext.Extensibility')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-ClientContext-Item-System-String- 'Microsoft.VisualStudio.Extensibility.ClientContext.Item(System.String)')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-ClientContext-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.ClientContext.ServiceBrokerClient')
  - [DisposeManagedResources()](#M-Microsoft-VisualStudio-Extensibility-ClientContext-DisposeManagedResources 'Microsoft.VisualStudio.Extensibility.ClientContext.DisposeManagedResources')
- [DefaultJsonServiceFactory](#T-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
- [DisposableObject](#T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-IsDisposed 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.IsDisposed')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose(System.Boolean)')
  - [DisposeManagedResources()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeManagedResources 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.DisposeManagedResources')
  - [DisposeNativeResources()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeNativeResources 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.DisposeNativeResources')
  - [Finalize()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Finalize 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Finalize')
- [EmptyResourceDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-#ctor 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.#ctor')
  - [Instance](#P-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-Instance 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.Instance')
  - [GetStringResourceAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.GetStringResourceAsync(System.Globalization.CultureInfo,System.String,System.Threading.CancellationToken)')
- [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint')
  - [#ctor(serviceBroker,localServiceProvider,resourceDictionary)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker,System.IServiceProvider,Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary)')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-IsDisposed 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.IsDisposed')
  - [LocalServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.LocalServiceProvider')
  - [ResourceDictionary](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ResourceDictionary 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ResourceDictionary')
  - [ServiceBroker](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBroker')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBrokerClient')
  - [CreateChildInstance\`\`1()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-CreateChildInstance``1 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.CreateChildInstance``1')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.Dispose')
  - [Dispose(isDisposing)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.Dispose(System.Boolean)')
  - [ThrowIfDisposed()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ThrowIfDisposed 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ThrowIfDisposed')
- [ExtensibilityPointManager](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,key,factory)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-String,System-Func{``0}- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint,System.String,System.Func{``0})')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,factory)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-Func{``0}- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint,System.Func{``0})')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
- [ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-#ctor 'Microsoft.VisualStudio.Extensibility.ExtensionCore.#ctor')
  - [ResourceDictionary](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceDictionary 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ResourceDictionary')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceManager 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ResourceManager')
  - [ServiceFactoryMap](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceFactoryMap 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ServiceFactoryMap')
  - [ServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ServiceProvider')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-CreateAsync-System-IServiceProvider,Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-ServiceHub-Framework-Services-AuthorizationServiceClient,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.CreateAsync(System.IServiceProvider,Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.ServiceHub.Framework.IServiceBroker,Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient,System.Threading.CancellationToken)')
  - [GetFactory(serviceMoniker)](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetFactory-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.GetFactory(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [InitializeServices(serviceCollection)](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.InitializeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods')
  - [AsStringResourceDictionary(resman)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-AsStringResourceDictionary-System-Resources-ResourceManager- 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods.AsStringResourceDictionary(System.Resources.ResourceManager)')
  - [CloneAsNonDisposable(serviceBroker)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-CloneAsNonDisposable-Microsoft-ServiceHub-Framework-IServiceBroker- 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods.CloneAsNonDisposable(Microsoft.ServiceHub.Framework.IServiceBroker)')
- [ExtensionPart](#T-Microsoft-VisualStudio-Extensibility-ExtensionPart 'Microsoft.VisualStudio.Extensibility.ExtensionPart')
  - [#ctor(container,extensibilityObject)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.#ctor(Microsoft.VisualStudio.Extensibility.ExtensionCore,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Container](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Container 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Container')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Extensibility 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Extensibility')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-IsDisposed 'Microsoft.VisualStudio.Extensibility.ExtensionPart.IsDisposed')
  - [AttachServiceScope(serviceScope)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-AttachServiceScope-Microsoft-Extensions-DependencyInjection-IServiceScope- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.AttachServiceScope(Microsoft.Extensions.DependencyInjection.IServiceScope)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Dispose')
  - [Dispose(isDisposing)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Dispose(System.Boolean)')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.InitializeAsync(System.Threading.CancellationToken)')
  - [InitializeInternalAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeInternalAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.InitializeInternalAsync(System.Threading.CancellationToken)')
- [IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Extensibility 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.Extensibility')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Item-System-String- 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.Item(System.String)')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.ServiceBrokerClient')
- [IServiceFactory](#T-Microsoft-VisualStudio-Extensibility-IServiceFactory 'Microsoft.VisualStudio.Extensibility.IServiceFactory')
  - [CreateAsync(serviceMoniker,activationOptions,serviceProvider,instanceType,interfaceType)](#M-Microsoft-VisualStudio-Extensibility-IServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.IServiceFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor(serviceMoniker)](#M-Microsoft-VisualStudio-Extensibility-IServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.IServiceFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
- [MultiTargetingRpcConnection](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection')
  - [#ctor(jsonRpcConnection)](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection.#ctor(Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection)')
  - [AddLocalRpcTarget()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-AddLocalRpcTarget-System-Object- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection.AddLocalRpcTarget(System.Object)')
- [MultiTargetingServiceJsonRpcDescriptor](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor')
  - [#ctor(innerDescriptor)](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.#ctor(Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor)')
  - [Clone()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-Clone 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.Clone')
  - [ConstructRpcConnection()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-ConstructRpcConnection-System-IO-Pipelines-IDuplexPipe- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.ConstructRpcConnection(System.IO.Pipelines.IDuplexPipe)')
- [ResourceManagerDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary')
  - [#ctor(resourceManager)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-#ctor-System-Resources-ResourceManager- 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary.#ctor(System.Resources.ResourceManager)')
  - [GetStringResourceAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary.GetStringResourceAsync(System.Globalization.CultureInfo,System.String,System.Threading.CancellationToken)')
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Resources 'Microsoft.VisualStudio.Extensibility.Resources')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Resources.CommandIdAlreadyRegistered')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Resources.Culture')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Resources.InvalidVersionString')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Resources.ResourceManager')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Resources.UnsupportedDocumentMoniker')
- [ServiceBrokerNonDisposableWrapper](#T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper')
  - [#ctor(serviceBroker)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker)')
  - [GetPipeAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetPipeAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.GetPipeAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.Threading.CancellationToken)')
  - [GetProxyAsync\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetProxyAsync``1-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.GetProxyAsync``1(Microsoft.ServiceHub.Framework.ServiceRpcDescriptor,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.Threading.CancellationToken)')
- [TransientServiceProvider](#T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider')
  - [#ctor(serviceProvider)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-IServiceProvider- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.#ctor(System.IServiceProvider)')
  - [AddSingleton(type,value)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton-System-Type,System-Object- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.AddSingleton(System.Type,System.Object)')
  - [AddSingleton\`\`1(value)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton``1-``0- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.AddSingleton``1(``0)')
  - [GetService()](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-GetService-System-Type- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.GetService(System.Type)')
- [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility')
  - [#ctor(serviceBroker,serviceProvider,resourceDictionary)](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker,System.IServiceProvider,Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary)')

<a name='T-Microsoft-VisualStudio-Extensibility-ClientContext'></a>
## ClientContext `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for accessing client context JSON blob in a structured method.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContext-#ctor-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(contextProperties,extensibility) `constructor`

##### Summary

Initializes a new instance of the [ClientContext](#T-Microsoft-VisualStudio-Extensibility-ClientContext 'Microsoft.VisualStudio.Extensibility.ClientContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextProperties | [System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}') | Client context bag passed by remote commands provider. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object instance. |

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-Extensibility'></a>
### Extensibility `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-Item-System-String-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContext-DisposeManagedResources'></a>
### DisposeManagedResources() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory'></a>
## DefaultJsonServiceFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.
This default factory uses either the service moniker name as the type name, or type information from [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute') attribute
and creates an instance using dependency injection (TBD) and uses JSON serialization.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject'></a>
## DisposableObject `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

An helper for implementating disposable instances following the recommended pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object has been disposed once, protects against double disposal.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the current object then suppresses further finalization.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Standard virtual overload for [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable') pattern.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `True` means this is a call to [Dispose](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose').
`False` means it has been called from the finalizer. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeManagedResources'></a>
### DisposeManagedResources() `method`

##### Summary

Allows derived classes to provide custom dispose handling for managed resources.

##### Parameters

This method has no parameters.

##### Remarks

Derived classes are expected to override this method to dispose their managed resources, then call the base class.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeNativeResources'></a>
### DisposeNativeResources() `method`

##### Summary

Allows derived classes to provide custom dispose handling for native resources.

##### Parameters

This method has no parameters.

##### Remarks

Derived classes are expected to override this method to dispose their native resources, then call the base class.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Finalize'></a>
### Finalize() `method`

##### Summary

Finalizes an instance of the [DisposableObject](#T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject') class.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary'></a>
## EmptyResourceDictionary `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A resource string dictionatry that is empty, always throws.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmptyResourceDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-Instance'></a>
### Instance `property`

##### Summary

Gets the singleton instance.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken-'></a>
### GetStringResourceAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint'></a>
## ExtensibilityPoint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary-'></a>
### #ctor(serviceBroker,localServiceProvider,resourceDictionary) `constructor`

##### Summary

Initializes a new instance of the [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to use for the extensibility wrapper. |
| localServiceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for local services. |
| resourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resource dictionary instance to utilize for accessing localized resources. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object is disposed.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider'></a>
### LocalServiceProvider `property`

##### Summary

Gets the local service provider.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ResourceDictionary'></a>
### ResourceDictionary `property`

##### Summary

Gets the resource dictionary instance for querying localized strings.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker'></a>
### ServiceBroker `property`

##### Summary

Gets the underlying service broker instance.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

Gets the service broker client instance that can be used to query for brokered services.

##### Remarks

This instance is backed by the same [ServiceBroker](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBroker') instance and will be disposed at the same time.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-CreateChildInstance``1'></a>
### CreateChildInstance\`\`1() `method`

##### Summary

Creates an instance of T based on this instances of services.

##### Returns

an instance of T.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | a type inheriting from [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose-System-Boolean-'></a>
### Dispose(isDisposing) `method`

##### Summary

Disposes the instane and underlying proxies.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDisposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ThrowIfDisposed'></a>
### ThrowIfDisposed() `method`

##### Summary

Throws if object is disposed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager'></a>
## ExtensibilityPointManager `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-String,System-Func{``0}-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,key,factory) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional key to identify the instance in addition to type. |
| factory | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | Factory to create the new instance. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-Func{``0}-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,factory) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |
| factory | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | Factory to create the new instance. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.
This method creates T via dependency injection using the [LocalServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.LocalServiceProvider').

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionCore'></a>
## ExtensionCore `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Base class for an extension that can host multiple service instances. This class is inteded for internal use only, extension developers should instead
inherit from Microsoft.VisualStudio.Extensibility.Extension.

##### Remarks

The instance act as the shared instance similar to previous VSPackage concept.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceDictionary'></a>
### ResourceDictionary `property`

##### Summary

Gets the resource dictionary instance that can be passed to services.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Gets the resource manager instance to be used for localization.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceFactoryMap'></a>
### ServiceFactoryMap `property`

##### Summary

Gets the service factory map from moniker to factory type.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceProvider'></a>
### ServiceProvider `property`

##### Summary

Gets the service provider used for querying extension host services and local services.

##### Remarks

This provider is in-process only and does not include brokered remote services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-CreateAsync-System-IServiceProvider,Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-ServiceHub-Framework-Services-AuthorizationServiceClient,System-Threading-CancellationToken-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetFactory-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetFactory(serviceMoniker) `method`

##### Summary

Gets the service factory for the service moniker requested.

##### Returns

an instance of [IServiceFactory](#T-Microsoft-VisualStudio-Extensibility-IServiceFactory 'Microsoft.VisualStudio.Extensibility.IServiceFactory') that should be able to create the service instance for the requested moniker.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker requested. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when a factory registration is not present for the queried moniker. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### InitializeServices(serviceCollection) `method`

##### Summary

Initializes the service collection used in creating service factories.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Service collection to build. |

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods'></a>
## ExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

Helper extension methods.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-AsStringResourceDictionary-System-Resources-ResourceManager-'></a>
### AsStringResourceDictionary(resman) `method`

##### Summary

Creates a string resource dictionary from a [ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') instance.

##### Returns

an instance of [IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resman | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') | Resource manager instance. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-CloneAsNonDisposable-Microsoft-ServiceHub-Framework-IServiceBroker-'></a>
### CloneAsNonDisposable(serviceBroker) `method`

##### Summary

Create a clone of [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') that does not implement any other interface including [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable').
This clone could be used to avoid accidental disposal.

##### Returns

An [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') that does not implement [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Service broker instance to clone. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionPart'></a>
## ExtensionPart `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Base class for services or parts to be returned from service factories.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(container,extensibilityObject) `constructor`

##### Summary

Initializes a new instance of the [ExtensionPart](#T-Microsoft-VisualStudio-Extensibility-ExtensionPart 'Microsoft.VisualStudio.Extensibility.ExtensionPart') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [Microsoft.VisualStudio.Extensibility.ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') | Extension instance that can be used for sharing state across parts. |
| extensibilityObject | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance to be used by the service implementation. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Container'></a>
### Container `property`

##### Summary

Gets the container instance that hosts this and related parts.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the extensibility instance for this service.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object is disposed.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-AttachServiceScope-Microsoft-Extensions-DependencyInjection-IServiceScope-'></a>
### AttachServiceScope(serviceScope) `method`

##### Summary

Attaches a service scope to follow the lifetime of this extension part.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceScope | [Microsoft.Extensions.DependencyInjection.IServiceScope](#T-Microsoft-Extensions-DependencyInjection-IServiceScope 'Microsoft.Extensions.DependencyInjection.IServiceScope') | Service scope to dispose when the part is disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose-System-Boolean-'></a>
### Dispose(isDisposing) `method`

##### Summary

Disposes the instane and underlying services.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDisposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Provides an asynchronous way for extension parts to initialize their fields.
This method is called before the instance is handed to Visual Studio.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeInternalAsync-System-Threading-CancellationToken-'></a>
### InitializeInternalAsync(cancellationToken) `method`

##### Summary

Provides an asynchronous way for extension parts to initialize their fields.
This method is called before the instance is handed to Visual Studio.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext'></a>
## IClientContext `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Definitions

##### Summary

Container for client context at the time of a command invocation.

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the extensibility instance that can be used by extension methods extending the client context.

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Item-System-String-'></a>
### Item `property`

##### Summary

Gets the value of client context category.

##### Returns

The category values in deserialized string format.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Category identifier. |

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

Gets the service broker instance that can be used by extension methods extending the client context.

<a name='T-Microsoft-VisualStudio-Extensibility-IServiceFactory'></a>
## IServiceFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.

<a name='M-Microsoft-VisualStudio-Extensibility-IServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync(serviceMoniker,activationOptions,serviceProvider,instanceType,interfaceType) `method`

##### Summary

Creates the service instance of T when requested.

##### Returns

a Task returning instance of the service object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker that was requested. |
| activationOptions | [Microsoft.ServiceHub.Framework.ServiceActivationOptions](#T-Microsoft-ServiceHub-Framework-ServiceActivationOptions 'Microsoft.ServiceHub.Framework.ServiceActivationOptions') | Service activation options. |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for extension host services including service broker assigned to instance being created. |
| instanceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional instance type if it was specified in the service registration. |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional interface type if it was specified in the service registration to indicate the interface being queried. |

<a name='M-Microsoft-VisualStudio-Extensibility-IServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor(serviceMoniker) `method`

##### Summary

Gets the description of a service.

##### Returns

An instance of a [ServiceRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceRpcDescriptor').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker that was requested. |

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection'></a>
## MultiTargetingRpcConnection `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

Specialized [JsonRpcConnection](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection') that extends the default implementation
with support for providing secondary RPC targets via interfaces annotated with
[ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute').

##### Remarks

This component enables C# APIs for extensions to be implemented in terms of interfaces,
kept entirely separate from the object implementing the RPC contract, enables a single
extension to implement multiple RPC contracts, and makes the conversion from RPC to C#
types seamless for the extender.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection-'></a>
### #ctor(jsonRpcConnection) `constructor`

##### Summary

Initializes a new instance of the [MultiTargetingRpcConnection](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonRpcConnection | [Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection') | The JsonRpc connection. |

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-AddLocalRpcTarget-System-Object-'></a>
### AddLocalRpcTarget() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor'></a>
## MultiTargetingServiceJsonRpcDescriptor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

Specialized [ServiceJsonRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor') that extends the default implementation
with support for providing secondary RPC targets via interfaces annotated with
[ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute').

##### Remarks

This component enables C# APIs for extensions to be implemented in terms of interfaces,
kept entirely separate from the object implementing the RPC contract, enables a single
extension to implement multiple RPC contracts, and makes the conversion from RPC to C#
types seamless for the extender.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-'></a>
### #ctor(innerDescriptor) `constructor`

##### Summary

Initializes a new instance of the [MultiTargetingServiceJsonRpcDescriptor](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| innerDescriptor | [Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor') | The original descriptor. |

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

Needed to ensure that this object survives ServiceHub's attempts
to re-wrap it for [TraceSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') configuration.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-ConstructRpcConnection-System-IO-Pipelines-IDuplexPipe-'></a>
### ConstructRpcConnection() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary'></a>
## ResourceManagerDictionary `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A resource string dictionatry that is backed by a ResX resource manager.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-#ctor-System-Resources-ResourceManager-'></a>
### #ctor(resourceManager) `constructor`

##### Summary

Initializes a new instance of the [ResourceManagerDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceManager | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') | Resource manager instance to utilize. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken-'></a>
### GetStringResourceAsync() `method`

##### Summary

*Inherit from parent.*

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

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper'></a>
## ServiceBrokerNonDisposableWrapper `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A wrapper for [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') to hide away other interfaces.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker-'></a>
### #ctor(serviceBroker) `constructor`

##### Summary

Initializes a new instance of the [ServiceBrokerNonDisposableWrapper](#T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Service broker instance to wrap. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetPipeAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken-'></a>
### GetPipeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetProxyAsync``1-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken-'></a>
### GetProxyAsync\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider'></a>
## TransientServiceProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A service provider that contains transient values and passes other types to another service provider.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-IServiceProvider-'></a>
### #ctor(serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [TransientServiceProvider](#T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider to pass queries to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton-System-Type,System-Object-'></a>
### AddSingleton(type,value) `method`

##### Summary

Adds a singleton value to the service provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the object. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value to add. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton``1-``0-'></a>
### AddSingleton\`\`1(value) `method`

##### Summary

Adds a singleton value to the service provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | Value to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the value. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-GetService-System-Type-'></a>
### GetService() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility'></a>
## VisualStudioExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary-'></a>
### #ctor(serviceBroker,serviceProvider,resourceDictionary) `constructor`

##### Summary

Initializes a new instance of the [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to use for the extensibility wrapper. |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for local services. |
| resourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resource dictionary instance to utilize for accessing localized resources. |

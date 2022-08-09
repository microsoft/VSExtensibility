---
title: Extension Anatomy Reference
description: A reference for extension anatomy
date: 2021-8-16
---

# Anatomy of a new Visual Studio Extension
An extension utilizing the new extensibility SDK will have several components that interact together and also with Visual Studio. 

## Extension instance
The starting point for each extension is an instance of `Microsoft.VisualStudio.Extensibility.Extension`. This instance contains the necessary methods for Visual Studio to query services provided by the extension and also provides virtual methods for extension to provide localized resources and extension owned local services to be shared between the components of the extension.

For simple extensions that don't require such services, a default implementation will be created by code generators at build time. See `SimpleRemoteCommandSample` extension for such an example.

In other cases, such as `MarkdownLinter` extension project will have its own class that derives from `Microsoft.VisualStudio.Extensibility.Extension` to customize certain aspects of the extension.

For extension developers that are familiar with the existing VS SDK APIs, this class is very similar to `AsyncPackage` class that is used in the in-process extensibility model.

## VisualStudioExtensibility object
The object `Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility` acts as the entry point for extensibility features exposed by Visual Studio. This class will have various extension methods, properties to quickly enumerate through available features in extensibility SDK. Please see the (TBD:link) API documentation for available methods.

## Extension parts
For features where an extension contributes components to Visual Studio such as commands, editor listeners, extensions will utilize attributed classes. Build process will generate the correct metadata to ensure these components can be discovered by Visual Studio.

Currently the SDK supports a limited set of components to be exported:

* [Command handlers](../extension-guides/command/command.md)
* [Text view lifetime listeners](../extension-guides/editor/editor.md) for tracking text view created, closed events.
* [Text view change listeners](../extension-guides/editor/editor.md) for tracking changes to an open text view.

Instances for these classes will be created as part of the extensibility framework provided by the SDK using dependency injection library and constructors can be used to retrieve instances of services provided by either the SDK or by the extension itself to share state across components.

### Lifetime of extension parts
Lifetime of each part is managed by the respective component that loads those parts inside Visual Studio IDE process.

* Command handlers will be initialized when the corresponding command set is activated which can be during the first execution of the command. Once activated, command handlers should only be disposed when IDE is shutdown.

* Similarly text view event listeners will be initialized when the first text view matching the content type specified is loaded in the IDE. Currently, such listeners will be active until IDE is shutdown but this behavior may change in future.

In general, for complex extensions we recommend extension to provide local services that parts can import in their constructor and using those services to share state across parts and across instances of the same part. This will ensure that extension state is not affected by lifetime changes of extension parts.

### Services provided by SDK for injection
The following services are provided by the SDK that can be used in constructor for any extension part:

* `VisualStudioExtensibility`: Every extension part can inject an instance of `VisualStudioExtensibility` to interact with Visual Studio IDE.

* `Extension`: Parts can inject `Microsoft.VisualStudio.Extensibility.Extension` type or the extensions own type inheriting from it to extension parts.

* `TraceSource`: A trace source instance is created on demand for each extension that can be used to record diagnostic information. These instances are registered with Visual Studio diagnostics provider which can be used to merge logs from multiple services and utilize future tooling to access real time logging. See [Logging](logging.md) section for more information.

* Local services: Any local services provided by the extension itself will also be available for dependency injection.

* `MefInjection<TService>` and `AsyncServiceProviderInjection<TService, TInterface>`: In-proc extensions can inject [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services that would be traditionally consumed through either [MEF](https://docs.microsoft.com/en-us/visualstudio/extensibility/managed-extensibility-framework-in-the-editor) or the [AsyncServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.shell.asyncserviceprovider).

## Local extension services
In certain scenarios an extension may want to share state between different components such as a command handler and a text view change listener, as it can be seen in `MarkdownLinter` example. These services can be added to in-process service collection via overriding `Extension.InitializeServices` method and as instances of extension parts are created, the services will be injected based on the constructor arguments.

There are 3 options that a service can be added:

* `AddTransient`: A new instance of the service is created for each part that ingests it.
* `AddScoped`: A new instance of the service is created within a certain scope. In context of Visual Studio extensibility, scope refers to a single extension part.
* `AddSingleton`: There is a single shared instance of service that is created on first ingestion.

Due to lifetime of `VisualStudioExtensibility` object being bound to the scope of a single extension part, any local service that ingests it has to be a scoped or transient service. Trying to create a singleton service that injects `VisualStudioExtensibility` will result in failure.

For an example of how local services are used please see the [MarkdownLinter extension](../../../New_Extensibility_Model/Samples/MarkdownLinter/).

## Client context
As all extensions in the new SDK runs out of process, we introduce the concept of client context for various extension parts to represent the state of the IDE as when the event or method is invoked. This context is represented by `IClientContext` instance in the SDK and is passed in to various operations such as command execution handlers. The SDK provides extension methods on `IClientContext` that can be utilized to retrieve objects from the context. For example extensions can get the active text view or the URI for the selected items at the time of command execution utilizing `IClientContext` instance.

Some components such as commands, will also have allow extension developers to declare which contexts they are interested. This is done to optimize the amount of data transferred in each remote execution since client context can get large in the future. In the initial preview, there are only two available contexts `Shell` and `Editor` and both are included by default when declaring a command using `CommandAttribute`.

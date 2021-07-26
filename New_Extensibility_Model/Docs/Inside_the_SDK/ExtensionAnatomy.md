# Anatomy of a new Visual Studio Extension
An extension utilizing the new extensibility SDK will have several components that interact together and also with Visual Studio. 

## Extension instance
The starting point for each extension is an instance of `Microsoft.VisualStudio.Extensibility.Extension`. This instance contains the necessary methods for Visual Studio to query services provided by the extension and also provides virtual methods for extension to provide localized resourcs and extension owned local services to be shared between the components of the extension.

For simple extensions that don't require such services, a default implementation will be created by code generators at build time. See `SimpleRemoteCommandSample` extension for such an example.

In other cases, such as `MarkdownLinter` extension project will have its own class that derives from `Microsoft.VisualStudio.Extensibility.Extension` to customize certain aspects of the extension.

For extension developers that are familiar with the existing VS SDK APIs, this class is very similar to `AsyncPackage` class that is used in the in-process extensibility model.

## VisualStudioExtensibility object
The object `Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility` acts as the entry point for extensibility features exposed by Visual Studio. This class will have various extension methods, properties to quickly enumerate through available features in extensibility SDK. Please see the (TBD:link) API documentation for available methods.

## Extension parts
For features where an extension contributes components to Visual Studio such as commands, editor listeners, extensions will utilize attributed classes. Build process will generate the correct metadata to ensure these components can be discovered by Visual Studio.

Currently the SDK supports a limited set of components to be exported:

* Command handlers
* Text view lifetime listeners for tracking text view created, closed events.
* Text view change listeners for tracking changes to an open text view.

TBD: Links

Instances for these classes will be created as part of the extensibility framework provided by the SDK using dependency injection library and constructors can be used to retrieve instances of services provided by either the SDK or by the extension itself to share state across components.

### Lifetime of extension parts
TBD

### Services provided by SDK for injection
The following services are provided by the SDK that can be used in constructor for any extension part:

* `VisualStudioExtensibility`: Every extension part can inject an instance of `VisualStudioExtensibility` to interact with Visual Studio IDE.

* `Extension`: Parts can inject `Microsoft.VisualStudio.Extensibility.Extension` type or the extensions own type inheriting from it to extension parts.

* `TraceSource`: A trace source instance is created on demand for each extension that can be used to record diagnostic information. These instances are registered with Visual Studio diagnostics provider which can be used to merge logs from multiple services and utilize future tooling to access real time logging.

* Local services: Any local services provided by the extension itself will also be available for dependency injection.

## Local extension services
In certain scenarios an extension may want to share state between different components such as a command handler and a text view change listener, as it can be seen in `MarkdownLinter` example. These services can be added to in-process service collection via overriding `Extension.InitializeServices` method and as instances of extension parts are created, the services will be injected based on the constructor arguments.

For an example of a local service please see `MarkdownLinter` example, specifically `MarkdownDiagnosticsService` class.


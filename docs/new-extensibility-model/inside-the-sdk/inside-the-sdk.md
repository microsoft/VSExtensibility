# Inside Visual Studio Extensibility SDK

The new Visual Studio Extensibility SDK is built on top of brokered services infrastructure that was introduced in Visual Studio 2019. It primarily involves of:

* A `VisualStudioExtensibility` object that acts as the entry point for the extensibility API. This object will have extension methods on it such as `Views()` or `Languages()` that exposes extensibility points of the IDE.

* Wrappers and extension methods around brokered services exposed by [IServiceBroker](https://docs.microsoft.com/en-us/dotnet/api/microsoft.servicehub.framework.iservicebroker?view=visualstudiosdk-2019) infrastructure with the goal of making services easy to use. In some cases, extension methods will return the contract interface directly.

* Base classes for extension parts, commands and the extension itself which are used to expose brokered services from extension to Visual Studio IDE. These services are the primary method that Visual Studio calls in to the extension.

* A code generator framework to generate `extension.json` metadata file based on extension parts and its attributes. This file declares the services, extension parts and other services exposed by the extension.
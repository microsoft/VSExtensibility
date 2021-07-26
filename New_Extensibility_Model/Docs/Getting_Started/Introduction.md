# Visual Studio OOP extensibility model

## Benefits
The new extensibility model is designed with the following goals in mind:

* Ease of use: We like to have well documented, simple paths for most common operations that extensions perform in Visual Studio. This should translate to shorter development time for small productivity extensions that work with existing languages in Visual Studio.

* Reliability: As we move extensions and components out-of-process, we can isolate components from which other increasing overall reliability of Visual Studio and also responsiveness of IDE in certain cases.

* Cross-product: While this is not possible today, a long term goal for this extensibility model is to be cross product compatible as it is primarily based on JsonRPC protocols to communicate with host IDE process.

## Technology
The new extensibility model is primarily built on top remote RPC contracts that are provided as brokered services from Visual Studio. The extensions are hosted in an external ServiceHub process that communicates with Visual Studio via RPC and both utilize services provided by Visual Studio and may also provide services to Visual Studio process in certain cases.

Extensibility packages that are provided as part of the SDK consist of base classes, utility methods and wrapper objects around these RPC contracts with the goal of making extensibility surface area easier to use, easier to discover and also to be able to quickly contribute to Visual Studio ecosystem such as creating a new command handler.

### Links
TBD: Do we have links around ServiceHub, IServiceBroker?

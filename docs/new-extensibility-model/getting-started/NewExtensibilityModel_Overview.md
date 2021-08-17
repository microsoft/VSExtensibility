# New Extensibility Model Overview

While the existing model loads extensions in-process, the new extensibility model brings Visual Studio extensions out-of-process.  This out-of-proc model gives you the opportunity to create more reliable, secure, and easier-to-write extensions while still providing the in-depth functionality the old model provides.  The following documentation describes:

* The general architecture of the new extensibility model
* How to take advantage of the new extensibility model’s APIs
* How to compile and F5 debug an extension with the new model 
* Resources and code samples to get started writing an extension with the new model

## What is the new extensibility model & why should you use it?

The new, out-of-proc extensibility model aims to address many of the problems both developers experience when using and writing extensions in Visual Studio using the old model.  These issues include:

* Extension-caused crashes and hangs of Visual Studio and other installed extensions
* Inconsistent hard-to-find docs and APIs, tribal knowledge requirements, and overwhelming architecture
* Lack of secure extensions
* Having to restart Visual Studio when installing extensions

Writing extensions using the new model provides the following benefits:

* **Increased reliability** – Extensions written with the new model are out-of-proc and will not block the Visual Studio UI.  This means that if the extension crashes, VS will not crash as a result. 
* **Reduced API complexity** – The new model’s wrapper API has been built from the ground-up to be more cohesive and simpler to implement while retaining the old model’s advanced functionality.
* **Low-trust extensions (Coming Soon)** – Since extensions in the new model run in a separate process, they can be isolated from devenv and ran in a low-trust sandbox. This environment will provide the extensions with read-only access to the file system and controlled writing access via the model’s APIs. 
* **Hot-reloading functionality (Coming Soon)** – Excluding ones requiring VS component prerequisites that haven’t been installed yet, extensions written using the new model can be installed and loaded without needing to restart Visual Studio.
* **.NET Core Only** – With VS transitioning primarily to .NET core, all new model extensions will be run on .NET core.  All APIs will also be built on .NET core and will be .NET 6 compatible.
* **Cross-CPU Platform** – Since APIs will be IServiceBroker and .NET core based, all Gladstone extensions will run on all CPU platforms supported by .net core runtime.

## Next Steps

To get started writing an extension using the new model, here are some docs, walkthroughs, samples, and videos to get you started:

**[TODO: Add links to docs here]**

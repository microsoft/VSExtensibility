# Visual Studio Out-Of-Process Extensibility SDK

While the existing model loads extensions in-process, the new extensibility model brings Visual Studio extensions out-of-process. This out-of-proc model gives you the opportunity to create more reliable, secure, and easier-to-write extensions while still providing the in-depth functionality the old model provides. The following documentation describes:

* The general architecture of the new extensibility model
* How to take advantage of the new extensibility model’s APIs
* How to compile and F5 debug an extension with the new model 
* Resources and code samples to get started writing an extension with the new model

## Getting Started
* [Introduction to new out-of-process extensibility](Getting_Started/NewExtensibility_Overview.md)
* [Create your first extension](Getting_Started/Create_Your_First_Extension.md)

## Extension Guides
* [Parts of a new Visual Studio extension](Inside_the_SDK/ExtensionAnatomy.md)
* [Parts of the SDK](Inside_the_SDK/InsideTheSDK.md)
* [Commands](Extension_Guides/Command/Command.md)
* [Editor components](Extension_Guides/Editor/Editor.md)
* [Rule based conditions](Inside_the_SDK/Activation_Constraints.md)

## Samples and walkthroughs
A Visual Studio solution containing all samples can be found at [Samples.sln](../Samples/Samples.sln).

* [Simple command handler](Extension_Guides/SimpleCommandSample.md) ([Source](../Samples/SimpleRemoteCommandSample))
* [Markdown Linter](Extension_Guides/MarkdownLinterSample.md) ([Source](../Samples/MarkdownLinter))
* [Insert guid extension sample](../Samples/InsertGuidExtension)
* [Command registration, localization sample](../Samples/CommandRegistrationsSample)

## API Docs

The following two namespaces are primary extensibility surface provided by the SDK:

* [Microsoft.VisualStudio.Extensibility](APIs/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](APIs/Microsoft.VisualStudio.Extensibility.Editor.md)


The following assemblies contain classes related to infrastructure and underlying implementation for the wrappers in the SDK:

* [Microsoft.VisualStudio.Extensibility.Framework](APIs/Microsoft.VisualStudio.Extensibility.Framework.md)
* [Microsoft.VisualStudio.Extensibility.Contracts](APIs/Microsoft.VisualStudio.Extensibility.Contracts.md)
* [Microsoft.VisualStudio.Extensibility.EditorHostService](APIs/Microsoft.VisualStudio.Extensibility.EditorHostService.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](APIs/Microsoft.VisualStudio.ProjectSystem.Query.md)
---
title: VS Extensibility
description: Welcome to Visual Studio Out-of-Proc Extensibility
date: 2021-8-19
---

# Welcome to the VSExtensibility website!
This site is your hub for all [announcements](announcements.md) and documentation for ongoing and upcoming Visual Studio extensibility projects.  Documentation is currently available for the following:

* Out-of-Proc Extensibility SDK (see below)
* [Extensions to Language Server Protocol (LSP)](lsp/lsp-extensions-specifications.md) 

# Visual Studio Out-Of-Process Extensibility SDK

While the existing model loads extensions in-process, the new extensibility model brings Visual Studio extensions out-of-process. This out-of-proc model gives you the opportunity to create more reliable, secure, and easier-to-write extensions while still providing the in-depth functionality the old model provides. The following documentation describes:

* The general architecture of the new extensibility model
* How to take advantage of the new extensibility model’s APIs
* How to compile and F5 debug an extension with the new model 
* Resources and code samples to get started writing an extension with the new model

For future updates please bookmark our [announcements](announcements.md) page

## Getting Started
* [Introduction to new out-of-process extensibility](new-extensibility-model/getting-started/oop-extensibility-model-overview.md)
* [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md)

## Extension Guides
* [Parts of a new Visual Studio extension](new-extensibility-model/inside-the-sdk/extension-anatomy.md)
* [Parts of the SDK](new-extensibility-model/inside-the-sdk/inside-the-sdk.md)
* [Commands](new-extensibility-model/extension-guides/command/command.md)
* [Editor components](new-extensibility-model/extension-guides/editor/editor.md)
* [Rule based conditions](new-extensibility-model/inside-the-sdk/activation-constraints.md)

## Samples and walkthroughs
A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

* [Simple command handler](new-extensibility-model/getting-started/create-your-first-extension.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample))
* [Markdown Linter](new-extensibility-model/extension-guides/markdown-linter-sample.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter))
* [Insert guid extension sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension)
* [Command registration, localization sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample)

## API Docs

The following two namespaces are primary extensibility surface provided by the SDK:

* [Microsoft.VisualStudio.Extensibility](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Extensibility.editor.md)

The following assemblies contain classes related to infrastructure and underlying implementation for the wrappers in the SDK:

* [Microsoft.VisualStudio.Extensibility.Framework](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Framework.md)
* [Microsoft.VisualStudio.Extensibility.Contracts](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Contracts.md)
* [Microsoft.VisualStudio.Extensibility.EditorHostService](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.EditorHostService.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)
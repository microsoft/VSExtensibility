---
title: VS Extensibility
description: Welcome to Visual Studio Extensibility model
date: 2021-8-19
---

# Welcome to the VSExtensibility documentation

This site is your hub for all documentation for ongoing and upcoming Visual Studio extensibility projects.  Documentation is currently available for the following:

* Visual Studio Extensibility SDK (see below)
* [Extensions to Language Server Protocol (LSP)](lsp/lsp-extensions-specifications.md) 

# Visual Studio Extensibility SDK

The following documentation describes:

* The general architecture of the new extensibility model
* How to take advantage of the new extensibility model’s APIs
* How to compile and debug an extension with the new model
* Resources and code samples to get started writing an extension with the new model

For future updates please bookmark our [announcements](announcements.md) page.

## Navigate the documentation

| Article | Description|
|-|-|
| [Get started](#get-started) | Never developed an extension before? Start with beginner quickstarts and introductory tutorials. |
| [Modern extension development](modern-extension-development.md) | Discover the VSExtensibility framework and how it compares to the VS SDK. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [Feature catalog](features.md) | Find information to answer questions solve specific problems. |
| [API reference](#api-docs) | Browse the VSExtensibility API documentation. |

## Get Started

| Article | Description|
|-|-|
| [Introduction to new out-of-process extensibility](new-extensibility-model/getting-started/oop-extensibility-model-overview.md) | Learn what the VS Extensibility model can do. |
| [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md) | Learn how to create a extension. |
| [Create a simple extension](new-extensibility-model/getting-started/tutorial-create-simple-extension.md) | Follow a tutorial and create a sample extension that adds a GUID to the editor window. |

## Overviews

| Article | Description|
|-|-|
| [Parts of a new Visual Studio extension](new-extensibility-model/inside-the-sdk/extension-anatomy.md) | Build your mental model of how Visual Studio extensions work. |
| [Parts of the SDK](new-extensibility-model/inside-the-sdk/inside-the-sdk.md) | Learn waht's in the SDK. |
| [Commands](new-extensibility-model/extension-guides/command/command.md) | Learn how to create extension functions and expose them to users in the IDE. |
| [Editor components](new-extensibility-model/extension-guides/editor/editor.md) | Learn how to extend the code editor. |
| [Rule based conditions](new-extensibility-model/inside-the-sdk/activation-constraints.md) | Control how and when your extension appears in the IDE. |

## Samples and tutorials

A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler](new-extensibility-model/getting-started/create-your-first-extension.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample)) | Demonstrates the basics of working with commands. |
| [Insert guid extension sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension) | An extension that inserts text or code in the code editor. See also the [tutorial](new-extensibility-modlel/getting-started/tutorial-create-simple-extension.md). |
| [Command registration, localization sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample) | An extension that shows a command registered with specific activation conditions. |
| [Markdown Linter](new-extensibility-model/extension-guides/markdown-linter-sample.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter)) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |

## API Docs

The following two namespaces are primary extensibility surface provided by the SDK:

* [Microsoft.VisualStudio.Extensibility](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Extensibility.editor.md)

The following assemblies contain classes related to infrastructure and underlying implementation for the wrappers in the SDK:

* [Microsoft.VisualStudio.Extensibility.Framework](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Framework.md)
* [Microsoft.VisualStudio.Extensibility.Contracts](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Contracts.md)
* [Microsoft.VisualStudio.Extensibility.EditorHostService](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.EditorHostService.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)
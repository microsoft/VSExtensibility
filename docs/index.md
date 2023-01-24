---
title: VisualStudio.Extensibility
description: Welcome to Visual Studio Extensibility model
date: 2021-8-19
---

# Welcome to the VisualStudio.Extensibility documentation

The VisualStudio.Extensibility SDK is a new framework for developing Visual Studio extensions currently in active development and is now made available as a preview, which you can download from []().

With the current preview, you can already develop a wide range of extensions to Visual Studio, from creating a simple command and exposing it in the IDE, to adding support for a new language, extending code or text editing functionality, exposing the functionality of a tool in the IDE, and more.

The new framework is designed to be fully asynchronous and keep extensions isolated, usually in a separate process. These design principles are critical for keeping the Visual Studio IDE responsive and stable, even if extensions themselves have problems.

We're actively seeking feedback and engagement. During the preview phase, the framework isn't code complete, and this preview phase is a great time to get community input to help us identify issues and opportunities. You can enter issues in our [public repo](https://github.com/microsoft/VSExtensibility/issues).

The new VisualStudio.Extensibility framework may ultimately replace the VS SDK. However, you can also develop with both frameworks in the same extension, if the functionality you are trying to use is not yet available in the new framework, or if you are updating an existing extension written with the existing VS SDK.

This site is your hub for all documentation for ongoing and upcoming VisualStudio.Extensibility projects.  Documentation is currently available for the following:

* Visual Studio.Extensibility SDK (see below)
* [Extensions to Language Server Protocol (LSP)](lsp/lsp-extensions-specifications.md) 

## Visual Studio Extensibility SDK

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
| [Modern extension development](modern-extension-development.md) | Discover the VisualStudio.Extensibility SDK and how it compares to the Visual Studio SDK. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Concepts](#concepts) | Find information to answer questions solve specific problems. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [API reference](#api-docs) | Browse the VisualStudio.Extensibility API documentation. |
| [Advanced topics](#advanced) | Learn implementation details of the VisualStudio.Extensibility SDK. |

## Get Started

| Article | Description|
|-|-|
| [Introduction to new out-of-process extensibility](new-extensibility-model/getting-started/oop-extensibility-model-overview.md) | Learn what the VisualStudio.Extensibility model can do. |
| [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md) | Learn how to create a extension. |
| [Create a simple extension](new-extensibility-model/getting-started/tutorial-create-simple-extension.md) | Follow a tutorial and create a sample extension that adds a GUID to the editor window. |

## Overviews

| Article | Description|
|-|-|
| [Commands](new-extensibility-model/extension-guides/command/command.md) | Learn how to create extension functions and expose them to users in the IDE. |
| [Editor components](new-extensibility-model/extension-guides/editor/editor.md) | Learn how to extend the code editor. |
appears in the IDE. |
| [Output window](new-extensibility-model/extension-guides/outputWindow/outputWindow.md) | Learn how to use the output window in an extension. |
| [Tool windows](new-extensibility-model/extension-guides/toolWindow/toolWindow.md) | Learn how to work with tool windows, dockable windows hosted within the Visual Studio IDE. |
| [User prompts](new-extensibility-model/extension-guides/userPrompts/userPrompts.md)| Learn how to use prompts to interact with the user. |

## Concepts

| Article | Description|
|-|-|
| [Parts of a new Visual Studio extension](new-extensibility-model/inside-the-sdk/extension-anatomy.md) | Build your mental model of how Visual Studio extensions work. |
| [Parts of the SDK](new-extensibility-model/inside-the-sdk/inside-the-sdk.md) | Learn waht's in the SDK. |
| [Rule based conditions](new-extensibility-model/inside-the-sdk/activation-constraints.md) | Control how and when your extension appears in the IDE. |

## Samples and tutorials

A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler](new-extensibility-model/getting-started/create-your-first-extension.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample)) | Demonstrates the basics of working with commands. |
| [Insert guid extension sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension) | Shows how to insert text or code in the code editor. See also the [tutorial](new-extensibility-modlel/getting-started/tutorial-create-simple-extension.md). |
| [Command registration, localization sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample) | An extension that shows a command registered with specific activation conditions. |
| [Command parenting sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Command-Parenting-Sample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample) | Shows the most basic use of the [Output Window API](./../../../docs/new-extensibility-model/extension-guides/outputWindow/outputWindow.md)|
| [Tool window extension](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowExtension) | Shows how to create a tool window and populate it with content. |
| [User prompt sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/UserPromptSample) | Shows how to create a simple command to display a prompt to the user. |
| [Markdown Linter](new-extensibility-model/extension-guides/markdown-linter-sample.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter)) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Comment remover](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report. |

## API Docs

The following two namespaces are primary extensibility surface provided by the SDK:

* [Microsoft.VisualStudio.Extensibility](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Extensibility.editor.md)

The following assemblies contain classes related to infrastructure and underlying implementation for the wrappers in the SDK:

* [Microsoft.VisualStudio.Extensibility.Framework](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Framework.md)
* [Microsoft.VisualStudio.Extensibility.Contracts](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Contracts.md)
* [Microsoft.VisualStudio.Extensibility.EditorHostService](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.EditorHostService.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)

## Advanced

| Article | Description|
|-|-|
| [Remote UI](new-extensibility-model/inside-the-sdk/remote-ui.md) | |
| [Advanced Remote UI](new-extensibility-model/inside-the-sdk/advanced-remote-ui.md) | |
| [In-proc extensions](new-extensibility-model/getting-started/in-proc-extensions.md) | Learn how to make extension that run in-process. |

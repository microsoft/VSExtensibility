---
title: VisualStudio.Extensibility
description: Welcome to the Visual Studio Extensibility model
date: 2021-8-19
---

# Welcome to the VisualStudio.Extensibility documentation

VisualStudio.Extensibility is a new framework for developing Visual Studio extensions. The new framework focuses primarily on extensions that run out-of-process from the IDE for improved performance and reliability, and it features a modern, asynchronous API that has been streamlined and carefully engineered to maximize developer productivity. VisualStudio.Extensibility is currently in active development and is now made available as a preview, which you can download by cloning this code repository and installing []().

With the current preview, you can develop a wide range of extensions to Visual Studio, including creating a simple command and exposing it in the IDE, working with code or text in the editor, exposing the functionality of a tool in the IDE, creating debugger visualizers, and more.

VisualStudio.Extensibility aims to address many of the problems both developers experience when using and writing extensions in Visual Studio using the old model.  These issues include:

* Extension-caused crashes and hangs of Visual Studio and other installed extensions
* Inconsistent hard-to-find docs and APIs, tribal knowledge requirements, and overwhelming architecture
* Lack of secure extensions
* Having to restart Visual Studio when installing extensions

Eventually, the VisualStudio.Extensibility SDK will ultimately replace the VS SDK. However, until that time, you might encounter situations where the functionality you need in your extension is not yet available in VisualStudio.Extensibility. In that case, you can develop an in-process extension by leveraging the new VisualStudio.Extensibility APIs while relying on [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk) to cover any feature gap.

This site is your hub for all documentation for the VisualStudio.Extensibility SDK. Documentation is currently available for the following:

* VisualStudio.Extensibility SDK (see the following sections)
* [Extensions to Language Server Protocol (LSP)](lsp/lsp-extensions-specifications.md)

## Navigate the documentation

| Article | Description|
|-|-|
| [Get started](#get-started) | Never developed an extension before? Start with beginner quickstarts and introductory tutorials. |
| [Concepts](#concepts) | Build your mental model of how the SDK and extensions work. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [API reference](#api-docs) | Browse the VisualStudio.Extensibility API documentation. |
| [Advanced topics](#advanced) | Learn implementation details of the VisualStudio.Extensibility SDK. |

In addition, we recommend a thorough understanding of [asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/) and [dependency injection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection). The UI Framework used in Visual Studio is Windows Presentation Foundation (WPF), so you might want to review the [WPF documentation](/dotnet/desktop/wpf/).

## Get Started

The following articles will help you get oriented and started.

* [Create your first extension](new-extensibility-model/getting-started/create-your-first-extension.md) shows how to create the equivalent of "Hello, world" as an extension.
* Next , follow a tutorial and create a more interesting extension that adds a GUID to the editor window. See [Create a simple extension](new-extensibility-model/getting-started/tutorial-create-simple-extension.md).

To understand how to work with the new extensibility model, we recommend a thorough understanding of [asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/) and [dependency injection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection). In addition, the UI framework we use is Windows Presentation Foundation (WPF), so you should review the [WPF documentation](/dotnet/desktop/wpf/). Knowledge of the [MVVM model](/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern) might be helpful.

## Concepts

If you're familiar with the Visual Studio SDK, see [Introduction to VisualStudio.Extensibility for VS SDK users](new-extensibility-model/getting-started/oop-extensibility-model-overview.md).

Build your mental model of how Visual Studio extensions work. See [Parts of a new Visual Studio extension](new-extensibility-model/inside-the-sdk/extension-anatomy.md).

Learn what's in the SDK at [Functional areas of the SDK](new-extensibility-model/inside-the-sdk/inside-the-sdk.md)

When and where should your extension appear in the IDE? Visual Studio extensions surface in the IDE at when certain conditions are met. To control how and when your extension appears in the IDE, see [Rule-based activation constraints](new-extensibility-model/inside-the-sdk/activation-constraints.md).

## Overviews

Read an overview of the areas of the SDK that you might need for your extension development projects:

* To learn how to create extension functions and expose them to users in the IDE, see [Commands](new-extensibility-model/extension-guides/command/command.md).
* To learn how to extend the code editor, see [Editor extensions](new-extensibility-model/extension-guides/editor/editor.md).
* To learn how to use the output window in an extension, see [Output window](new-extensibility-model/extension-guides/outputWindow/outputWindow.md).
* To learn how to work with tool windows, dockable windows hosted within the Visual Studio IDE, see [Tool windows](new-extensibility-model/extension-guides/toolWindow/toolWindow.md).
* To learn how to use prompts to interact with the user, see [User prompts](new-extensibility-model/extension-guides/userPrompts/userPrompts.md).

## Samples and tutorials

A Visual Studio solution containing all samples can be found at [Samples.sln](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler](new-extensibility-model/getting-started/create-your-first-extension.md) ([Source](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample)) | Demonstrates the basics of working with commands. |
| [Insert guid extension sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuidExtension) | Shows how to insert text or code in the code editor. See also the [tutorial](new-extensibility-model/getting-started/tutorial-create-simple-extension.md). |
| [Command registration, localization sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandRegistrationsSample) | An extension that shows a command registered with specific activation conditions. |
| [Command parenting sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/Command-Parenting-Sample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample) | Shows the most basic use of the [Output Window API](./new-extensibility-model/extension-guides/outputWindow/outputWindow.md)|
| [Tool window extension](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowExtension) | Shows how to create a tool window and populate it with content. |
| [User prompt sample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/UserPromptSample) | Shows how to create a simple command to display a prompt to the user. |
| [Markdown Linter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Comment remover](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report. |

## API Docs

The following two namespaces are primary extensibility surface provided by the SDK:

* [Microsoft.VisualStudio.Extensibility](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md)
* [Microsoft.VisualStudio.Extensibility.Editor](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Editor.md)

The following assemblies contain classes related to infrastructure and underlying implementation for the wrappers in the SDK:

* [Microsoft.VisualStudio.Extensibility.Framework](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Framework.md)
* [Microsoft.VisualStudio.Extensibility.Contracts](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Contracts.md)
* [Microsoft.VisualStudio.Extensibility.EditorHostService](new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.EditorHostService.md)
* [Microsoft.VisualStudio.ProjectSystem.Query](new-extensibility-model/api/Microsoft.VisualStudio.ProjectSystem.Query.md)

## Advanced

| Article | Description|
|-|-|
| [Remote UI](new-extensibility-model/inside-the-sdk/remote-ui.md) | Start learning about remote UI model used in the VisualStudio.Extensibility SDK.|
| [Advanced Remote UI](new-extensibility-model/inside-the-sdk/advanced-remote-ui.md) | In-depth information on the remote UI model. |
| [In-proc extensions](new-extensibility-model/getting-started/in-proc-extensions.md) | Learn how to make extension that run in-process. |

## Send feedback

We're actively seeking feedback and engagement. The preview phase is a great time to get community input to help us identify issues and opportunities. You can provide feedback and report bugs in our [issues tracker](https://github.com/microsoft/VSExtensibility/issues).

For future updates please bookmark our [announcements](announcements.md) page.

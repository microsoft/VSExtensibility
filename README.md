---
title: VisualStudio.Extensibility
description: Welcome to the Visual Studio Extensibility model
date: 2021-8-19
---

# Welcome to VisualStudio.Extensibility

VisualStudio.Extensibility is a new framework for developing Visual Studio extensions. The new framework focuses primarily on extensions that run out-of-process from the IDE for improved performance and reliability, and it features a modern, asynchronous API that has been streamlined and carefully engineered to maximize developer productivity. VisualStudio.Extensibility is in active development.

With the current version, you can develop a wide range of extensions to Visual Studio, including creating commands, working with code or text in the editor, displaying prompts or dialogs to the user, creating debugger visualizers, and more!

VisualStudio.Extensibility aims to address many of the problems developers experience when using and writing extensions in Visual Studio. Writing extensions using VisualStudio.Extensibility provides the following benefits:

* **Increased reliability**: Visual Studio remains responsive and won't crash if an extension crashes or hangs.
* **Reduced API complexity**: VisualStudio.Extensibility has simplified architecture, consistent APIs, and clear documentation.
* **Hot-loading functionality**: Visual Studio doesn't need to be restarted when installing extensions.
Eventually, the VisualStudio.Extensibility SDK will ultimately allow you to write any extension you could write using the VSSDK. However, until that time, you might encounter situations where the functionality you need in your extension is not yet available in VisualStudio.Extensibility. In that case, you can develop an in-process extension by leveraging the new VisualStudio.Extensibility APIs while relying on VSSDK to cover any feature gap. To learn more, see [In-proc extensions](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions).

> **Important** Documentation for the VisualStudio.Extensibility SDK has moved to a new location: [VisualStudio.Extensibility documentation](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility).

Documentation is currently available for the following:

* VisualStudio.Extensibility SDK (see the following sections)
* [Extensions to Language Server Protocol (LSP)](docs/lsp/lsp-extensions-specifications.md)

## Navigate the documentation

| Article | Description|
|-|-|
| [Install VisualStudio.Extensibility](#install-visualstudioextensibility) | Download and install VisualStudio.Extensibility. |
| [Get started](#get-started) | Start with beginner quickstarts and introductory tutorials if you've never developed an extension before. |
| [Concepts](#concepts) | Build your mental model of how the SDK and extensions work. |
| [Overviews](#overviews) | Learn more by reading overviews of each major area of functionality. |
| [Samples](#samples-and-tutorials) | Explore sample code demonstrating major features. |
| [API reference](#api-docs) | Browse the VisualStudio.Extensibility API documentation. |
| [Experimental APIs and Breaking Changes](#experimental-apis-and-breaking-changes) | Learn about our approach to stable-vs-experimental APIs and about breaking changes from the previous version. |
| [Known Issues](#known-issues) | View known issues with the VisualStudio.Extensibility SDK. |
| [Advanced topics](#advanced-topics) | Learn implementation details of the VisualStudio.Extensibility SDK. |

## Install VisualStudio.Extensibility

VisualStudio.Extensibility works with Visual Studio 2022 version 17.9 or higher with the `Visual Studio extension development` workload to be installed. VisualStudio.Extensibility extensions can be installed on Visual Studio 2022 version 17.9 and above.
VisualStudio.Extensibility packages having a version higher than 17.9 provide additional functionalities and can be used when targeting the corresponding version of Visual Studio. For example, when building an extension with VisualStudio.Extensibility packages version 17.10, the resulting extension will be compatible with Visual Studio 17.10 and above.

## Get Started

The following articles will help you get oriented and started:

* [Create your first Visual Studio extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension) shows how to create the equivalent of "Hello, world" as an extension.
*  [Create a simple extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/tutorial-create-simple-extension) shows you how to create a more interesting extension that adds a GUID to the editor window.

To understand how to work with VisualStudio.Extensibility, we recommend a thorough understanding of [asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/) and [dependency injection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection). In addition, UI in VisualStudio.Extensibility is based on Windows Presentation Foundation (WPF), so you might want to review the [WPF documentation](https://learn.microsoft.com/dotnet/desktop/wpf/).

## Concepts

If you're familiar with the Visual Studio SDK, refer to [Introduction to VisualStudio.Extensibility for VSSDK users](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/oop-extensibility-model-overview).

To build your mental model of how Visual Studio extensions work, see [Parts of a new Visual Studio extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/extension-anatomy).

To find out what is included in the SDK, see [Functional areas of the SDK](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/inside-the-sdk).

Visual Studio extensions appear in the IDE when certain conditions are met. To have control over how and when your extension appears in the IDE, see [Rule-based activation constraints](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/activation-constraints).

Visual Studio extensions make their features available to Visual Studio through contributions. For more information, see [Contributions](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/contributions-and-configurations).

Learn about the [Remote UI](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/remote-ui) model used in the VisualStudio.Extensibility.

## Overviews

Read an overview of the areas of the SDK that you might need for your extension development projects:

* To learn how to create commands and expose them to users in the IDE, see [Commands](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/command/command).
* To learn how to work with the contents of files and documents, see [Editor](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/editor/editor?view=vs-2022).
* To learn how to work with the in-memory representation of those documents themselves, see [Documents](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/document/documents).
* To learn how to use the output window in an extension, see [Output window](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window).
* To learn how to work with tool windows, dockable windows within the Visual Studio IDE, see [Tool windows](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/tool-window/tool-window).
* To learn how to use prompts with customizable buttons to interact with the user, see [User prompts](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/user-prompt/user-prompts).
* To learn how to use dialogs with custom UI to interact with the user, see [Dialogs](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/dialog/dialog).
* To learn how to create custom data visualizations when debugging, see [Debugger Visualizers](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers).
* To learn how to query or modify information about project sand solutions, see [Project Query](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/project/project).

## Samples and tutorials

You can find a Visual Studio solution that contains all samples at [Samples.sln](New_Extensibility_Model/Samples/Samples.sln).

| Sample | Description|
|-|-|
| [Simple command handler](New_Extensibility_Model/Samples/SimpleRemoteCommandSample) | Demonstrates the basics of working with commands. See also the [Create your first Visual Studio extension](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension) tutorial.|
| [Insert guid extension](New_Extensibility_Model/Samples/InsertGuid) | Shows how to insert text or code in the code editor. See also the [Create your simple extension](//learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/get-started/tutorial-create-simple-extension) tutorial.|
| [Command parenting](New_Extensibility_Model/Samples/CommandParentingSample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](New_Extensibility_Model/Samples/DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window](New_Extensibility_Model/Samples/OutputWindowSample) | Shows the most basic use of the [Output Window API](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window).|
| [Tool window](New_Extensibility_Model/Samples/ToolWindowSample) | Shows how to create a tool window and populate it with content. |
| [User prompt](New_Extensibility_Model/Samples/UserPromptSample) | Shows how to display a prompt to the user. |
| [Dialog](New_Extensibility_Model/Samples/DialogSample) | Shows how to display a dialog with custom UI to the user.|
| [Word count margin](New_Extensibility_Model/Samples/WordCountMargin) | Shows how to create an editor margin extension that displays the word count in a document.|
| [Markdown linter](New_Extensibility_Model/Samples/MarkdownLinter) | Shows how multiple components can interact together inside an extension and how different areas of Visual Studio can be extended.|
| [Project Query](New_Extensibility_Model/Samples/VSProjectQueryAPISample) | Shows several different kinds of project system queries you can make. |
| [Comment remover](New_Extensibility_Model/Samples/CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts, and progress report.|
| [RegexMatchDebugVisualizer](New_Extensibility_Model/Samples/RegexMatchDebugVisualizer) | Shows how to use [Remote UI](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/remote-ui) to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize regular expression matches that will launch in a modal dialog window. |
| [MemoryStreamDebugVisualizer](New_Extensibility_Model/Samples/MemoryStreamDebugVisualizer) | Shows how to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize MemoryStream objects that launches in a non-modal tool window. |
| [CompositeExtension](New_Extensibility_Model/Samples/CompositeExtension) | Shows how to create an extension with in-proc and out-of-proc components that communicate using brokered services. . |

## Experimental APIs and Breaking Changes
Starting with our 17.9 release, we're ready to label the vast majority of our APIs as stable. That is, we don't plan to make any breaking changes to these APIs. Any breaking changes that might need to be made, for example in response to user feedback about usability, will be communicated formally and with plenty of notice on our [breaking changes](./docs/breaking_changes.md) page.

There are a few of our APIs that don't yet meet this bar for stability, for one of several reasons:
* The feature area is new and additional features and changes are expected in future versions.
* The API is new and we want to incorporate user feedback into the deisgn before marking it stable.
* We've received feedback that a particular API is difficult to use, so we're planning on updating it in future versions.

For these APIs, we've explicitly labeled them using the `[Experimental]` attribute to help extension authors create their extensions with confidence in the the SDK.

For more information, including how to use experimental APIs, please see our [Experimental APIs](./docs/experimental_apis.md) page.

## Known Issues

We appreciate your feedback and bug reports in our [Issues Tracker](https://github.com/microsoft/VSExtensibility/issues), and we work to address any issues found in the SDK.

Please visit our [Known Issues](./docs/known_issues.md) page for information about any current known issues.

## Advanced Topics

| Article | Description|
|-|-|
| [Advanced Remote UI](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/advanced-remote-ui) | In-depth information on the remote UI model |
| [In-proc extensions](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions) | A quick walkthrough on different options to use VisualStudio.Extensibility SDK in-proc|

## API Docs

* API Docs are available on [learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.extensibility).

## Send feedback

We're actively seeking feedback and engagement. The preview phase is a great time to get community input to help us identify issues and opportunities. You can provide feedback and report bugs in our [issues tracker](https://github.com/microsoft/VSExtensibility/issues).

For future updates please bookmark our [announcements](docs/announcements.md) page.

While VisualStudio.Extensibility is in the preview phase, it’s a great time for you, our community members, to share your input to help us identify issues and opportunities. Community participation is welcome and highly encouraged; we value the input and insights provided by extension developers like you!

You can provide feedback and report bugs in our issues tracker. Please note that we don’t have a dedicated support team – we, the engineering team working on VisualStudio.Extensibility will be the ones monitoring and triaging issues and other extension developers will be able to comment on these, too. Because we don’t have a dedicated support team, it may take some time before we get to issues and we won’t always be able to respond to everything.

Regarding our response flow on issues, here’s a general overview:
- You submit an issue.
- That issue remains in a “triage” state until we’ve assigned a team member to investigate it.
- Once assigned, the issue is moved to “scheduled”. This doesn’t imply an immediate fix, but indicates that we’re actively looking into it.
- Issues we won’t address immediately will be moved to “backlog”.
- Issues that are either fixed in code or addressed via comments will be closed.

For future updates please bookmark our announcements page.

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft trademarks or logos is subject to and must follow [Microsoft Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos is subject to those third-party's policies.

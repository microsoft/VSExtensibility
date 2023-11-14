# Visual Studio Out-of-Process Extensibility Samples

Each sample directory may have its own `README.md` file to describe its specific scenario
and call out interesting aspects to its sample.

Samples include:

| Sample | Description|
|-|-|
| [Simple command handler](./SimpleRemoteCommandSample) | Demonstrates the basics of working with commands. See also the [Create your first extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension) tutorial.|
| [Insert guid](./InsertGuid) | Shows how to insert text or code in the code editor, how to configure a command with a specific activation condition, and how to use a resource file for localization. See also the [tutorial](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/tutorial-create-simple-extension). |
| [Command parenting](./CommandParentingSample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](./DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window](./OutputWindowSample) | Shows the most basic use of the [Output Window API](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window)|
| [Tool window](./ToolWindowSample) | Shows how to create a tool window and populate it with content. |
| [User prompt](./UserPromptSample) | Shows how to display a prompt to the user. |
| [Dialog](./DialogSample) | Shows how to display a dialog with custom UI to the user. |
| [Word count margin](./WordCountMargin) | Shows how to create an editor margin extension that displays the word count in a document. |
| [Markdown linter](./MarkdownLinter) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Project Query](./VSProjectQueryAPISample) | Shows several different kinds of project system queries you can make. |
| [Comment remover](./CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report. |
| [RegexMatchDebugVisualizer](./RegexMatchDebugVisualizer) | Shows how to use [Remote UI](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/remote-ui) to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize regular expression matches that will launch in a modal dialog window. |
| [MemoryStreamDebugVisualizer](./MemoryStreamDebugVisualizer) | Shows how to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize MemoryStream objects that launches in a non-modal tool window. |

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

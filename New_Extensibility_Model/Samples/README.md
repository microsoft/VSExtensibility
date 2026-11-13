# VisualStudio.Extensibility Samples

Each sample directory may have its own `README.md` file to describe its specific scenario
and call out interesting aspects to its sample.

Open [Samples.slnx](./Samples.slnx) for all samples in this directory, including out-of-process,
in-process, and hybrid extensions, as well as a VSSDK language-configuration example.

| Sample | Description |
| --- | --- |
| [Simple command handler](./SimpleRemoteCommandSample) | Demonstrates the basics of working with commands. See also the [Create your first Visual Studio extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension) tutorial. |
| [Insert GUID](./InsertGuid) | Shows how to insert text or code in the code editor, configure command activation, and localize resources. See also the [Create a simple extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/tutorial-create-simple-extension) tutorial. |
| [Encode / Decode Base64](./EncodeDecodeBase64) | Shows how to encode or decode selected text in a C# document, including multiple selections. |
| [Command parenting](./CommandParentingSample) | Shows how to author a command that can be parented to different aspects of the IDE. |
| [Document selector](./DocumentSelectorSample) | Shows how to create an editor extension that is only applicable to files matching a file path pattern. |
| [Output window](./OutputWindowSample) | Shows the most basic use of the [Output Window API](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window). |
| [Tool window](./ToolWindowSample) | Shows how to create a tool window and populate it with content. |
| [User prompt](./UserPromptSample) | Shows how to display a prompt to the user and gather simple input. |
| [Dialog](./DialogSample) | Shows how to display a dialog with custom UI to the user. |
| [File picker](./FilePickerSample) | Shows how to prompt users to open one or more files, save a file, or select a folder. |
| [Word count margin](./WordCountMargin) | Shows how to create an editor margin extension that displays the word count in a document. |
| [Markdown linter](./MarkdownLinter) | A complete extension with many moving parts interacting to provide an enhanced experience in the editor for a certain file type. |
| [Project Query](./VSProjectQueryAPISample) | Shows several different kinds of project system queries you can make. |
| [Settings](./SettingsSample) | Shows how to define, read, monitor, and update extension settings to configure a tool window, with settings actions, a live preview, and setting-based command activation. |
| [External settings](./ExternalSettingsSample) | Shows an experimental external settings provider backed by an in-memory store, including validation and change notifications. |
| [Taggers](./TaggersSample) | Shows how to create taggers to highlight portions of code or enable new Code Lenses. |
| [Classification](./ClassificationSample) | Shows how to create classification taggers to color text in different colors based on syntax. |
| [Code Lens](./CodeLensSample) | Shows how to create an invokable click-count Code Lens and a word-count Code Lens with custom UI. |
| [Rust language server provider](./RustLanguageServerProvider) | Shows how to launch and connect to rust-analyzer to provide IntelliSense and tooltips for Rust files. Requires Rust and rust-analyzer. |
| [Language configuration](./LanguageConfigurationSample) | Shows how to package and register a language-configuration JSON file and an optional TextMate grammar in a content-only VSIX, without any DLLs, to support editor behavior such as comment toggling and bracket auto-closing. |
| [Roslyn integration](./RoslynIntegrationExtension) | Shows how an out-of-process extension queries the C# workspace through a Roslyn-hosted message handler to find a symbol's defining assembly. |
| [Comment remover](./CommentRemover) | Shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts, and progress reporting. |
| [RegexMatchDebugVisualizer](./RegexMatchDebugVisualizer) | Shows how to use [Remote UI](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/remote-ui) to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize regular expression matches that will launch in a modal dialog window. |
| [MemoryStreamDebugVisualizer](./MemoryStreamDebugVisualizer) | Shows how to create a [Debugger Visualizer](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers) to visualize MemoryStream objects that launches in a non-modal tool window. |
| [Feature gallery](./FeatureGallery) | Demonstrates multiple SDK features in an out-of-process extension, including document editing, editor margins, taggers, classification, settings, dialogs, images, and language servers. |
| [In-process feature gallery](./InProcFeatureGallery) | Runs the shared Feature Gallery source as an in-process, VSSDK-compatible extension. |
| [Extension publisher](./ExtensionPublisher) | Shows how to publish extensions to the Visual Studio Marketplace from within Visual Studio. |
| [CompositeExtension](./CompositeExtension) | Shows how to create an extension with in-proc and out-of-proc components that communicate using brokered services. |
| [ExtensionWithTraditionalComponents](./ExtensionWithTraditionalComponents) | Shows how to create an out-of-proc extension that packages VSSDK components. |
| [AsyncPackageAndMEF](./AsyncPackageAndMEF) | Shows how to write an in-proc VisualStudio.Extensibility extension that also includes components that are common in VSSDK extensions: `AsyncPackage`s and MEF components. |
| [MultiTargetedExtensions](./MultiTargetedExtensions) | Shows how to target multiple versions of Visual Studio with [out-of-process VisualStudio.Extensibility](./MultiTargetedExtensions/MultiTargetedExtensibilityExtension), [hybrid VSSDK + VisualStudio.Extensibility](./MultiTargetedExtensions/MultiTargetedHybridExtension), and [classic VSSDK](./MultiTargetedExtensions/MultitargetedVssdkExtension) extensions. |

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

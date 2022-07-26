# Visual Studio Out-of-Process Extensibility Samples

Each sample directory may have its own `README.md` file to describe its specific scenario
and call out interesting aspects to its sample.

Samples include:

* SimpleRemoteCommandSample: A simple extension showing how to declare a single command.
* CommandRegistrationsSample: Showcases how to register commands in different ways and command placement, localization.
* InsertGuidExtension: A simple extension showing how to read/modify editor buffers.
* MarkdownLinter: An end-to-end example showing various features available in the extensibility SDK.
* CommentRemover: A conversion of Mads Kristensen's [Comment Remover](https://github.com/madskristensen/CommentRemover) extension to in-proc VisualStudio.Extensibility. This sample shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report.
* DocumentSelectorSample: A sample demonstrating how to define an editor extension that is only applicable to files matching a file path pattern.

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

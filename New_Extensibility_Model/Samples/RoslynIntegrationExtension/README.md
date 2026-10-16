# Roslyn Integration Sample

This sample demonstrates how an out-of-process VisualStudio.Extensibility extension
can query the C# workspace using a custom message handler hosted by Roslyn. The
**Find Assembly from Symbol** command shows the type of the symbol at the caret,
the name and version of its defining assembly, and the assembly's metadata path
when available. A button opens File Explorer with that assembly selected.

## Prerequisites and running the sample

- Visual Studio 2026 version 18.13 or later with the **Visual Studio extension
  development** workload and the .NET 10 SDK.
- The VisualStudio.Extensibility SDK and Build packages at version `18.13.507`,
  `Microsoft.VisualStudio.Extensibility.CodeAnalysis` at version `18.13.507`, and
  `Microsoft.VisualStudio.Extensibility.CodeAnalysis.Server` at version `18.13.458`.
  If these packages are not available from your configured sources, add the
  [public VSSDK feed](https://pkgs.dev.azure.com/azure-public/vside/_packaging/vssdk/nuget/v3/index.json)
  as a NuGet package source.

1. Open [Samples.slnx](../Samples.slnx) and set the `RoslynIntegrationExtension`
   project as the startup project (not `RoslynMessageHandler`).
2. Build and press **F5** to start the experimental instance of Visual Studio.
3. In that instance, open a C# project and a `.cs` document. Wait for the project
   to load so Roslyn can resolve its references.
4. Place the caret on a type name or on a local variable, field, property, or
   parameter. Select **Extensions > Find Assembly from Symbol**, or invoke the
   command from the editor context menu.
5. Inspect the dialog. For a type from a metadata reference, select the folder
   button to locate its assembly in File Explorer.

For example, place the caret on `StringBuilder` in a project that references
`System.Text.StringBuilder`. For a type defined in the current project, the
dialog shows the type and assembly identity, but there is no metadata assembly
path, so the folder button is disabled. Whitespace and unsupported symbols,
such as methods, produce a prompt instead of a dialog.

## How it works

The sample contains two projects:

| Project | Purpose |
|---------|---------|
| [RoslynIntegrationExtension](RoslynIntegrationExtension/RoslynIntegrationExtension.csproj) | A .NET 10 out-of-process extension that contributes the command and a Remote UI dialog. It references the CodeAnalysis client package and the handler project. |
| [RoslynMessageHandler](RoslynMessageHandler/RoslynMessageHandler.csproj) | A .NET Standard 2.0 class library containing the Roslyn-hosted handler and the JSON request and response types. It references only the CodeAnalysis.Server package, not the extension SDK or Build package. |

`FindAssemblyCommand` gets the active text view, converts the caret position to
a `DocumentPosition`, and calls
`Languages().CSharp().QueryAsync<FindAssemblyHandler, FindAssemblyMessage, FindAssemblyResponse>`
with the document snapshot. Passing the snapshot ties the query to that document
version; the default query fails if the document has changed before Roslyn
handles the message.

Roslyn loads the handler assembly and invokes
`IExtensionDocumentMessageHandler.ExecuteAsync` with a document context.
`FindAssemblyHandler` uses `SymbolFinder.FindSymbolAtPositionAsync` to resolve
the symbol, maps supported symbols to their types, and uses the semantic model's
compilation to locate the containing assembly's metadata reference.

The request and response use `JsonPropertyName` attributes for serialization.
The extension displays the response through `AssemblyInfoPopup`, whose XAML is
an embedded resource and whose data context exposes serialized `DataMember`
properties and an `AsyncCommand`. The handler project is copied alongside the
extension through its project reference and packaged in the extension's VSIX;
it is not a separately installed extension.

Handlers can be unloaded and reloaded by Roslyn, so they should not depend on
persistent in-memory state. This handler is stateless. Query failures are shown
to the user and rethrown; cancellation is allowed to propagate without an error
prompt.

## Experimental APIs

The integration uses experimental APIs. The relevant source files suppress
`VSEXTPREVIEW_LANGUAGES_QUERY`, and the handler also suppresses Roslyn's
`RSEXPERIMENTAL008` diagnostic. These APIs may change in future releases; see
[Experimental APIs](../../../docs/experimental_apis.md).

For more background, see the [Roslyn SDK](https://learn.microsoft.com/dotnet/csharp/roslyn-sdk/)
and [VisualStudio.Extensibility dialogs](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/dialog/dialog).
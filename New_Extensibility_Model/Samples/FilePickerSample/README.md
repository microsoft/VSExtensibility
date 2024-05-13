---
title: File Picker Sample reference
description: A reference for File Picker samples
date: 2024-05-10
---

# File Picker Sample Extension

This is a simple extension that shows how to work with the file/directory picker during execution of a few sample commands.

## Command definition
The extension contains multiple code files that defines four commands and its properties starting with the `VisualStudioContribution` class attribute which makes the commands available to Visual Studio:

- `OpenFileCommand`
- `OpenMultipleFilesCommand`
- `OpenSaveAsFileCommand`
- `OpenFolderCommand`

The four commands follow a similar command definition.

```csharp
[VisualStudioContribution]
internal class OpenFileCommand : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `FilePickerSample.OpenFileCommand` as its unique identifier.

The `CommandConfiguration` property defines information about the command that is available to Visual Studio even before the extension is loaded:

```csharp
public override CommandConfiguration CommandConfiguration => new("%FilePickerSample.OpenFileCommand.DisplayName%")
{
    TooltipText = "%FilePickerSample.OpenFileCommand.ToolTipText%",
    Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
};
```

The command is placed in the `Tools` top-level menu.

These commands utilize different options available to customize the dialog.

## Getting the ShellExtensibility helpers

Once user executes the command, the SDK will route execution to the `ExecuteCommandAsync` method.

In our example, we utilize the `VisualStudioExtensibility` object to acquire the `ShellExtensibility` helpers.

```csharp
var shell = this.Extensibility.Shell();
```

## Asking the user to choose a file to open
Once we have the shell helpers, we use the `ShowOpenFileDialogAsync` method to prompt the user with a file dialog. We pass in a custom `FileDialogOptions` to configure the
dialog presented to the user. The dialog will have `test.cs` as the default filename with 2 file filters, one for log files and one for CSharp files. The `DefaultFilterIndex = 1` means that the CSharp file filter is selected by default.
If the user closes or cancels the dialog, `ShowOpenFileDialogAsync` will return `null`.

```csharp
FileDialogOptions options = new()
{
    InitialFileName = "test.cs",
    Filters = new DialogFilters([
        new("Log Files", "*.txt", "*.log"),
        new("CSharp Files", "*.cs"),
    ])
    {
        DefaultFilterIndex = 1,
    },
};

string? filePath = await this.Extensibility.Shell().ShowOpenFileDialogAsync(options, ct);
```

## Asking the user to choose multiple files to open
It may be more preferable to have the user choose multiple files instead of just one. Using `ShowOpenMultipleFilesDialogAsync` instead of `ShowOpenFileDialogAsync`
will accomplish this.

`ShowOpenMultipleFilesDialogAsync` returns a list of strings, and `null` if the user closes or cancels the dialog.

```csharp
FileDialogOptions options = new()
{
    InitialFileName = "test.cs",
    Filters = new DialogFilters(
        new("Log Files", "*.txt", "*.log"),
        new("CSharp Files", "*.cs")),
};

IReadOnlyList<string>? filePaths = await this.Extensibility.Shell().ShowOpenMultipleFilesDialogAsync(options, ct);
```

## Asking the user to choose a file to save as
In addition to choosing a file to open, we can utilize the file dialog to choose a file to save as, which can allow the user to specify a custom file name.

The `FileDialogOptions` utilize the `Title` and `InitialFileName` properties to set a custom title and default filename.

```csharp
 FileDialogOptions options = new()
{
    Title = "Save as File",
    InitialFileName = "result.txt",
};

string? filePath = await this.Extensibility.Shell().ShowSaveAsFileDialogAsync(options, ct);
```

## Asking the user to choose a folder to open
We can also have the user choose a folder path instead of a file path. Using `ShowOpenFolderDialogAsync` will accomplish this.

Instead of `FileDialogOptions`, we must pass in `FolderDialogOptions` to configure the folder dialog.

```csharp
FolderDialogOptions options = new();
string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, ct);
```


## Usage

Once deployed, the File Picker Sample commands can be invoked anytime from the Tools menu.

See also, [Create Visual Studio file/directory picker prompts](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/user-prompt/file-directory-picker-prompts).
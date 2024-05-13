---
title: File Picker Sample reference
description: A reference for File Picker samples
date: 2024-05-10
---

# File Picker Sample Extension

This is a simple extension that shows how to work with the file/directory picker during execution of a few sample commands.

## Command definition

The extension contains four commands:

- `OpenFileCommand`
- `OpenMultipleFilesCommand`
- `OpenSaveAsFileCommand`
- `OpenFolderCommand`

Please see the [Insert Guid sample](../InsertGuid/) for more information about creating and configuring commands.

## Prompting the user to select a file to open

For our first command, we use the `ShowOpenFileDialogAsync` method to prompt the user with an open file dialog.

We use a `FileDialogOptions` object to configure the dialog presented to the user. The dialog will have `test.cs` as the default filename with two file filters: one for log files and one for CSharp files. The `DefaultFilterIndex = 1` means that the CSharp file filter is selected by default.

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

string? filePath = await this.Extensibility.Shell().ShowOpenFileDialogAsync(options, cancellationToken);
```

If the user closes or cancels the dialog, `ShowOpenFileDialogAsync` will return `null`.

## Prompting the user to select multiple files to open

In some cases, the user may need to choose more than one file. Using `ShowOpenMultipleFilesDialogAsync` instead of `ShowOpenFileDialogAsync` allows the user to select one or more files at a time.

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

`ShowOpenMultipleFilesDialogAsync` returns a list of strings, and `null` if the user closes or cancels the dialog.

## Prompting the user to select a file to Save As

In addition to choosing a file to open, we can utilize the file dialog to choose a file to Save As, which allows the user to specify a custom file name.

Here we set the `Title` and `InitialFileName` properties in the `FileDialogOptions` object to set a custom title and default filename:

```csharp
 FileDialogOptions options = new()
{
    Title = "Save as File",
    InitialFileName = "result.txt",
};

string? filePath = await this.Extensibility.Shell().ShowSaveAsFileDialogAsync(options, ct);
```

## Prompting the user to select a folder to open

We can also prompt the user to choose a folder path instead of a file path by using the `ShowOpenFolderDialogAsync` method.

Instead of `FileDialogOptions`, we must pass in a `FolderDialogOptions` object to configure the folder dialog.

```csharp
FolderDialogOptions options = new();
string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, ct);
```

## Usage

Once deployed, the File Picker Sample commands can be invoked anytime from the Tools menu.

See also, [Create Visual Studio file/directory picker prompts](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/user-prompt/file-directory-picker-prompts).
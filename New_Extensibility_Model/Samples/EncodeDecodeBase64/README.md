---
title: Encode / Decode Base64 Extension Sample reference
description: A reference for Encode / Decode Base64 sample
date: 2025-4-3
---

# Walkthrough: Encode / Decode Base64 Extension Sample

This extension is a simple extension that shows how a command that modifies an open editor window can be quickly added to Visual Studio.

## Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class EncodeDecodeBase64Command : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `EncodeDecodeBase64.EncodeDecodeBase64Command` as its unique identifier.

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new("%EncodeDecodeBase64.EncodeDecodeBase64Command.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.ConvertPartition, IconSettings.IconAndText),
        VisibleWhen = ActivationConstraint.SolutionState(SolutionState.FullyLoaded),
        EnabledWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, "csharp"),
    };
```

The command is placed in `Extensions` top menu and uses `ConvertPartition` icon moniker.

The `VisibleWhen` and `EnabledWhen` properties defines when the command is visible and enabled in the `Extensions` menu. You can refer to [Activation Constraints](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/activation-constraints) to learn about different options that you can use to determine command visibility and state. In this case, the command is visible anytime a solution is fully loaded in the IDE, but enabled only when the active editor is a C# document.

## Getting the active editor view

Once user executes the command, SDK will route execution to `ExecuteCommandAsync` method. `IClientContext` instance contains information about the state of IDE at the time of command execution and can be used in conjunction with `VisualStudioExtensibility` object.

In our example, we utilize `GetActiveTextViewAsync` method to get the active text view at the time of command execution which includes information about document being open, version of the document and the selection.

```csharp
using var textView = await context.GetActiveTextViewAsync(cancellationToken);
```

## Mutating the text in active view

Once we have the active text view, we can edit the document attached to the view to replace the selection with a new guid string as below.

```csharp
ITextViewSnapshot textDocumentEditor = await textView.GetTextDocumentAsync(cancellationToken);
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        ITextDocumentEditor textDocumentEditor = textView.Document.AsEditable(batch);
        // [...]
    },
    cancellationToken);
```

## Accessing every selections in the active view

The `ITextViewSnapshot` instance contains a `Selections` property that can be used to get the current selections in the view. There can be empty or [multiple selections](https://learn.microsoft.com/en-us/visualstudio/ide/finding-and-replacing-text?view=vs-2022#multi-caret-selection).
```csharp
ITextDocumentEditor textDocumentEditor = textView.Document.AsEditable(batch);
var selections = textView.Selections;

for (int i = 0; i < selections.Count; i++)
{
    var selection = selections[i];
    if (selection.IsEmpty)
    {
        continue;
    }

    string newText = this.EncodeOrDecode(selection.Extent.CopyToString());
    textDocumentEditor.Replace(selection.Extent, newText);
}
```

## Logging errors

Each extension part including command sets is assigned a `TraceSource` instance that can be utilized to log diagnostic errors. Please see [Logging](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/logging) section for more information.

## Usage

Once deployed, the Encode / Decode Base64 command can be used when editing any C# document. The command by default will be under Extensions menu.

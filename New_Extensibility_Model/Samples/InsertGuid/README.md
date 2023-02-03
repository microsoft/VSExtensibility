---
title: Insert Guid Extension Sample reference
description: A reference for Insert Guid sample reference
date: 2022-8-4
---

# Walkthrough: Insert Guid Extension Sample

This extension is a simple extension that shows how a command that modifies an open editor window can be quickly added to Visual Studio.

## Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class InsertGuidCommand : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `Microsoft.VisualStudio.Gladstone.InsertGuid.InsertGuidCommand` as its unique identifier.

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new    ("%InsertGuidCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
        Icon = new(ImageMoniker.KnownValues.OfficeWebExtension, IconSettings.    IconAndText),
        VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, ".+"),
    };
```

The command is placed in `Extensions` top menu and uses `OfficeWebExtension` icon moniker.

The `VisibleWhen` property defines when the command is visible in the `Extensions` menu. You can refer to [Activation Constraints](../inside-the-sdk/activation-constraints.md/) to learn about different options that you can use to determine command visibility and state. In this case, the command is enabled anytime there is an active editor in the IDE.

## Getting the active editor view

Once user executes the command, SDK will route execution to `ExecuteCommandAsync` method. `IClientContext` instance contains information about the state of IDE at the time of command execution and can be used in conjuction with `VisualStudioExtensibility` object.

In our example, we utilize `GetActiveTextViewAsync` method to get the active text view at the time of command execution which includes information about document being open, version of the document and the selection.

```csharp
using var textView = await context.GetActiveTextViewAsync(cancellationToken);
```

## Mutating the text in active view

Once we have the active text view, we can mutate the document attached to the view to replace the selection with a new guid string as below.

```csharp
var document = await textView.GetTextDocumentAsync(cancellationToken);
await this.Extensibility.Editor().MutateAsync(
    m =>
    {
        var mutator = m.GetMutator(document);
        mutator.Replace(textView.Selection.Extent, newGuidString);
    },
    cancellationToken);
```

## Logging errors

Each extension part including command sets is assigned a `TraceSource` instance that can be utilized to log diagnostic errors. Please see [Logging](../inside-the-sdk/logging.md) section for more information.

## Usage

Once deployed, the Insert Guid command can be used when editing any code files. The command by default will be under Extensions menu.
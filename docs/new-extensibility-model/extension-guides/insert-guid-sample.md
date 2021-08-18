---
title: Insert Guid Extension Sample reference
description: A reference for Insert Guid sample reference
date: 2021-8-16
---

# Walkthrough: Insert Guid Extension Sample

This extension is a simple extension that shows how a command that modifies an open editor window can be quickly added to Visual Studio.

Source code: TBD

## Command definition

The extension consist of a single code file that defines a command and its properties starting with class attributes as seen below:

```csharp
	[Command(
		"Microsoft.VisualStudio.InsertGuidExtension.InsertGuidCommand",
		1,
		"Insert new guid",
		placement: KnownCommandPlacement.ExtensionsMenu)]
	[CommandIcon("OfficeWebExtension", IconSettings.IconAndText)]
	[CommandVisibleWhen("AnyFile", new string[] { "AnyFile" }, new string[] { "ClientContext:Shell.ActiveEditorContentType=.+" })]
```

The first `Command` attribute registers the command using the unique name `Microsoft.VisualStudio.InsertGuidExtension.InsertGuidCommand` and id `1`. The command is placed in `Extensions` top menu and uses `OfficeWebExtension` icon moniker.

`CommandVisibleWhen` attribute defines when the command is visible in `Extensions` menu. You can refer to [Activation Constraints]() to learn about different options that you can use to determine command visibility and state. In this case, the command is enabled anytime there is an active editor in the IDE.

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

Each extension part including command sets is assigned a `TraceSource` instance that can be utilized to log diagnostic errors. Please see [Logging](../Inside_the_SDK/Logging.md) section for more information.
---
title: Simple Remote Command Sample reference
date: 2023-10-17
---

## Walkthrough: Simple Remote Command Sample

This extension is a simple extension that shows how a command can be quickly added to Visual Studio.

### Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class CommandHandler : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `SimpleRemoteCommandSample.CommandHandler` as its unique identifier.

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new("%SimpleRemoteCommandSample.CommandHandler.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };
```

The command is placed in the `Tools` top level menu and uses the `Extension` icon moniker. The command will always be enabled and visible.

### Usage

Once deployed, the Simple Sample Command can be found under the `Tools` top level menu.

### Additional Readings

More information can be found at, [Add Visual Studio commands](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/command/command)

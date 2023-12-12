---
title: Command Parenting Sample reference
date: 2023-10-17
---

## Command Parenting Sample

This extension is meant to act as a sample for how to author a command that can be parented to different aspects of the IDE. The command in this extension is parented to a new Toolbar created by the extension, the context menu when a project item is selected in the Solution Explorer, the context menu when a project is selected in the Solution Explorer, and the solution is selected in the Solution Explorer.

## Walkthrough: Command Parenting Sample

This extension is meant to act as a sample for how to author a command that can be parented to different aspects of the IDE. The command in this extension is parented to a new Toolbar created by the extension, the context menu when a project item is selected in the `Solution Explorer`, the context menu when a project is selected in the `Solution Explorer`, and the context menu when a solution is selected in the `Solution Explorer`.

### Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `CommandParentingSample.SampleCommand` as its unique identifier.

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new("%CommandParentingSample.SampleCommand.DisplayName%")
    {
        Placements =
        [
            // File in project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 521, priority: 0),

            // Project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 518, priority: 0),

            // Solution context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 537, priority: 0),
        ],
    };
```

The command is placed in the in 3 different places in the IDE using the `CommandPlacement.VsctParent` method. The command will always be enabled and visible.

### Toolbar Definition

Different from commands, toolbars are configured as static properties and the `VisualStudioContribution` attribute is placed on the property itself instead of the owning class. The attribute registers the toolbar using the owning class full type name plus the property name, `CommandParentingSample.ExtensionCommandConfiguration.ToolBar`, as its unique identifier.

The `ToolbarConfiguration` property defines information about the toolbar that are available to Visual Studio even before the extension is loaded:

```csharp
    [VisualStudioContribution]
    public static ToolbarConfiguration ToolBar => new("%CommandParentingSample.ToolBar.DisplayName%")
    {
        Children =
        [
            ToolbarChild.Command<SampleCommand>(),
        ],
    };
```

By default, all toolbars registered this way are parented to the `Standard Toolbar Tray` in Visual Studio. The toolbar can be made visible by clicking the command under `View` -> `Toolbars` -> `Command Parenting Sample Toolbar`.

The `SampleCommand` from earlier is parented onto this toolbar using `ToolbarChild.Command<SampleCommand>()` in the toolbar's `Children`.

### Additional Readings

More information can be found at:

- [Add Visual Studio commands](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/command/command)
- [Menus and Toolbars overview](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/command/menus-and-toolbars?view=vs-2022)

---
title: Tool Windows reference
description: A reference for extensibility tool windows
date: 2022-7-20
---

# Tool Windows Overview

Tool windows are a way to add complex UI and interactions to Visual Studio. They typically provide a user-friendly way to interact with various APIs and features. For example, the Solution Explorer tool window provides a tree-based view of the current project/solution/folder and provides simple gestures for the opening, renaming, and creating of files.

Tool windows are single-instance, meaning that only one instance of the Tool Window can be open at a time. When a Tool Window is closed in the IDE, it is only visibly hidden, instead of being fully closed and disposed of like documents.

# Getting Started

To get started, follow the [create the project](./../../getting-started/create-your-first-extension.md) section in Getting Started section.

Next, see the [ToolWindowExtension](./../../../../New_Extensibility_Model/Samples/ToolWindowExtension) sample for a full example of creating an extension with a tool window.

# Working with Tool Windows

This guide is designed to cover the top user scenarios when working with Tool Windows:

- [Tool Windows Overview](#tool-windows-overview)
- [Getting Started](#getting-started)
- [Working with Tool Windows](#working-with-tool-windows)
- [Creating a Tool Window](#creating-a-tool-window)
  - [ToolWindow Attribute](#toolwindow-attribute)
  - [Example](#example)
- [Adding Content to a Tool Window](#adding-content-to-a-tool-window)
- [Creating a Command to Show a Tool Window](#creating-a-command-to-show-a-tool-window)
  - [Example](#example-1)
- [Controlling the Visibility of a Tool Window](#controlling-the-visibility-of-a-tool-window)
  - [Example](#example-2)

# Creating a Tool Window

Creating a tool window with the new Extensibility Model is as simple as extending the base class [`Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow`](./../../api/Microsoft.VisualStudio.Extensibility.md/#toolwindow-type) and adorning your class with the attribute [`Microsoft.VisualStudio.Extensibility.VisualStudioContribution`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute).

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
```

## ToolWindow Attribute

The `ToolWindow` abstract class requires the implementation of the [`ToolWindowConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.md/#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindow-ToolWindowConfiguration) configuration, which has a few properties that you should become familiar with:

| Parameter | Type | Required | Description | Default Value |
| --------- |----- | -------- | ----------- | ------------- |
| Placement | ToolWindowPlacement | No | The location in Visual Studio where the tool window should be opened the first time. [`ToolWindowPlacement.DockedTo`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DockedTo-System-Guid-) allows to dock the tool window to a guid matching an old vsix-style tool window id. See more about [ToolWindowPlacement](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement). | ToolWindowPlacement.Floating |
| DockDirection | Dock | No | The direction relative to the placement where the tool window should be docked when opened the first time. See more about [Dock](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock). | Dock.None |
| AllowAutoCreation | Bool | No | Whether or not the tool window can be created automatically. Setting this to false means that tool windows that are open when Visual Studio is closed will not be automatically restored when Visual Studio is opened again. | `true` |

## Example

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }

    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.Floating,
        DockDirection = Dock.Right,
        AllowAutoCreation = true,
    };

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        // Create and return a RemoteUserControl
    }
}
```

# Adding Content to a Tool Window

Because extensions in VisualStudio.Extensibility might be out-of-process from the IDE, we cannot directly use WPF as a presentation layer for content in Tool Windows. Instead, adding content to a tool window requires creating a [RemoteUserControl](./../../inside-the-sdk/remote-ui.md) and the corresponding data template for that control. While there are some simple examples below, we recommend reading the [Remote UI documentation](./../../inside-the-sdk/remote-ui.md) when adding Tool Window content.

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }

    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.DocumentWell,
    };

    public override async Task InitializeAsync(CancellationToken cancellationToken)
    {
        // Do any work here that is needed before creating the control.
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl());
    }
}
```

MyToolWindowControl.cs: (this is an example file name and should have the same name as the data template file)

```csharp
internal class MyToolWindowControl : RemoteUserControl
{
    public MyToolWindowControl()
        : base(dataContext: null)
    {
    }
}
```

MyToolWindowControl.xaml (this is an example file name and should have the same name as the class that derives from RemoteUserControl)

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml">
    <Label></Label>
</DataTemplate>
```

See the [Remote UI](./../../inside-the-sdk/remote-ui.md) docs for more information on creating a RemoteUserControl.

# Creating a Command to Show a Tool Window

A common mechanism for showing a tool window is to add a [command](./../command/command.md) that, when invoked, shows the tool window by calling `ShellExtensibility.ShowToolWindowAsync()`.

`ShowToolWindowAsync()` has a boolean parameter, `activate`:
 - When `true`, the tool window will be both visible in the IDE *and* given focus.
 - When `false`, the tool window will be visibile in the IDE, but may be visible only as a tab in a tab group if other tool windows are active.

## Example

```csharp
[VisualStudioContribution]
public class MyToolWindowCommand : Command
{
    public MyToolWindowCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }
    
    public override CommandConfiguration CommandConfiguration => new("My Tool Window")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
    }
}
```

See the [Commands](./../command/command.md) docs to learn more about creating and using commands.

# Controlling the Visibility of a Tool Window

Another way of controling the visibility of a tool window, besides using commands, is to use rule-based activation constraints. The [`VisibleWhen`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-VisibleWhen) property allows tool windows to automatically be opened when certain conditions are met, and hidden again when those conditions are no longer applicable.

## Example

```csharp
// The tool window will be shown if the active document is a .cs file, and
// will be hidden if the active document is any any other type of file.
public override ToolWindowConfiguration ToolWindowConfiguration => new()
{
    VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.cs$"),
};
```

See the [Using rule based activation constraints](../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints) docs for more information on valid term values.

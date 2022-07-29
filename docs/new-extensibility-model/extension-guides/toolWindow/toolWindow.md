---
title: Tool Windows reference
description: A reference for extensibility tool windows
date: 2022-7-20
---

# Tool Windows

Tool windows are a way to add complex UI and interactions to Visual Studio. They typically provide a user friendly mechanism for interacting with various APIs and features. For example, the Solution Explorer provides a tree-based view of the current project/solution/folder and allows simple gestures for opening, renaming, creating files.

Tool windows are single-instance , meaning that only one instance of the tool window can be open at a time. After a single-instance tool window is opened, it remains open until Visual Studio is closed, and when closed the tool window is only visibly hidden instead of being fully closed and disposed like documents. Tool windows can be dynamic, meaning that they are visible whenever their related context rule applies. The use of auto-visibility can reduce the clutter of windows in the IDE. Tool windows can be docked, floating, or tabbed in the document well. The default size and location apply only when the tool window is first opened and after that the tool window state is persisted.

## Creating new tool windows

To get started, follow the [create the project](../getting-started/create-your-first-extension.md) section in Getting Started section.

### Registering a tool window

Creating a tool window with the new Extensibility Model is as simple as extending the base class `Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindow` and adorning your class with the attribute `Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute`.

The attribute [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowAttribute](./../../api/Microsoft.VisualStudio.Extensibility.md/#toolwindowattribute-type) has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| Placement | ToolWindowPlacement or String | No | The location in Visual Studio where the tool window should be opened the first time. If this value is a string it's expected to be a guid matching an old vsix-style tool window id. See more about [ToolWindowPlacement](#tool-window-placement). |
| DockDirection | Dock | No | The direction relative to the placement where the tool window should be docked when opened the first time. See more about [Dock](#dock). |
| AllowAutoCreation | Bool | No | Whether or not the tool window can be created automatically. Setting this to false means that tool windows that are open when Visual Studio is closed will not be automatically restored when Visual Studio is opened again. |

```csharp
// This is a default tool window registration that will result in:
// 1) Placement of ToolWindowPlacement.Floating
// 2) Dock direction of Dock.None
// 3) Allow auto-creation being enabled
[ToolWindow]
public class MyToolWindow : ToolWindow
{
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        // TODO: Create and return a RemoteUserControl
    }
}
```
See the [ToolWindowExtension](./../../../../New_Extensibility_Model/Samples/ToolWindowExtension) sample to get started with creating an extension with a tool window.

### Creating content for a tool window

Once a tool window is registered it will need content. Adding content requires creating a RemoteUserControl and corresponding data template for the control.

```csharp
    [ToolWindow(ToolWindowPlacement.DocumentWell)]
    public class MyToolWindow : ToolWindow
    {
        public MyToolWindow(VisualStudioExtensibility extensibility)
            : base(extensibility)
        {
            this.Title = "My Tool Window";
        }

        public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
        {
            // The data object allows for data binding in the control.
            var dataContext = new MyToolWindowData(this.Extensibility);

            // The only work done here should be related to creating the content.
            // If additional work is needed prior to creating the control, it
            // can be done by overriding the InitializeAsync method
            var control = new MyToolWindowControl(dataContext);
            return Task.FromResult<IRemoteUserControl>(control);
        }
    }
```

MyToolWindowControl.cs: (this is an example file name and should have the same name as the data template file)

```csharp
internal class MyToolWindowControl : RemoteUserControl
{
    public MyToolWindowControl(object? dataContext, SynchronizationContext? synchronizationContext = null)
        : base(dataContext, synchronizationContext)
    {
    }
}
```

MyToolWindowControl.xaml (this is an example file name and should have the same name as the class that derives from RemoteUserControl)

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <!-- TODO: Fill with content -->
</DataTemplate>
```

See the [Remote UI](./../../inside-the-sdk/remote-ui.md) docs for more information on creating a RemoteUserControl.

### Registering a command to show tool window

A common mechanism for opening a tool window is to add a command that, when invoked, shows the tool window.

```csharp
[Command("ToolWindowExtension.MyToolWindowCommand", "My Tool Window", placement: CommandPlacement.ToolsMenu)]
[CommandIcon(KnownMonikers.ToolWindow, IconSettings.IconAndText)]
public class MyToolWindowCommand : Command
{
    public MyToolWindowCommand(VisualStudioExtensibility extensibility, string name)
        : base(extensibility, name)
    {
    }

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        // "Activate: true" here means that the tool window will be shown and given focus
        // "Activate: false" here means that the tool window will only be shown which may result in only showing its tab
        await this.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
    }
}
```

See the [Commands](./../command/command.md) docs to learn more about setting up commands.

### Registering a tool window with dynamic visibility

Another mechanism for opening a tool window is to set up a context rule for when it should be shown or hidden. This allows tool windows to automatically be opened when certain conditions are met, and hidden again when those conditions are no longer applicable.

The attribute [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowVisibleWhenAttribute](./../../api/Microsoft.VisualStudio.Extensibility.md/#toolwindowvisiblewhenattribute-type) has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| Expression | String | Yes | A boolean expression string which, when true, will mean the context is active and the tool window will be shown. |
| TermNames | String[] | Yes | The names of the terms used in the expression. |
| TermValues | String[] | Yes | The values of each term. The term values must be in the same order as term names array. |

```csharp
// The tool window will be shown if a .cs file is the active document, and
// will be hidden whenever any other file type is the active document.
[ToolWindow]
[ToolWindowVisibleWhen("FileSelected",
                       new string[] { "FileSelected" },
                       new string[] { "ClientContext:Shell.ActiveSelectionFileName=.cs$" })]
public class MyToolWindow : ToolWindow
{
    // TODO: Implement the rest of the class
}
```
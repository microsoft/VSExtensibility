---
title: Tool Window Extension Sample reference
description: A reference for Tool Window sample
date: 2023-10-24
---

# Walkthrough: Tool Window Extension Sample

This extension is a simple extension that shows how a tool window can be quickly added to Visual Studio.

## Tool window definition

The extension contains a code file that defines a tool window and its properties starting with the `VisualStudioContribution` class attribute which makes the tool window available to Visual Studio:

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
```

The `ToolWindowConfiguration` property defines information about the tool window that is available to Visual Studio even before the extension is loaded:

```csharp
    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.DocumentWell,
    };
```

This configuration places the tool window in the document well when it's created the first time. You can refer to [ToolWindowPlacement](https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowplacement?view=vs-extensibility) to learn about other placement options. Since this configuration doesn't specify the additional options, it will have the default DockDirection and AllowAutoCreation values. You can refer to [ToolWindowConfiguration](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/tool-window/tool-window#toolwindow-attribute) to learn more about the configuration options.

The title of the tool window can be customized by setting the Title property:

```csharp
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }
```

Adding content to the tool window can be done by setting up a remote user control and corresponding data model:

```csharp
    public override Task InitializeAsync(CancellationToken cancellationToken)
    {
        this.dataContext = new MyToolWindowData(this.Extensibility);
        return Task.CompletedTask;
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl(this.dataContext));
    }
```
The data model creation and any other precursor work should be done in the InitializeAsync while the actual UI creation happens in the GetContentAsync.

## Tool window content creation

The tool window content is created as a DataTemplate .xaml file and a separate control class .cs file:

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml"
              xmlns:styles="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:colors="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
    ...
</DataTemplate>
```

```csharp
internal class MyToolWindowControl : RemoteUserControl
{
```

The .cs and .xaml files should have the same name (MyToolWindowControl in this sample). Additionally the xaml file should be included as an EmbeddedResource instead of a Page, so editing the csproj file may be necessary in some cases.

A data model that backs the UI is required for data-driven UI:

```csharp
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
```

The data model must derive from NotifyPropertyChangedObject and set the DataContract class attribute and DataMemeber property attribute for all UI bound properties.

You can refer to [Add content to a tool window](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/tool-window/tool-window#add-content-to-a-tool-window) to learn more about setting up the tool window content and remote UI.

## Show tool window command definition

Once the tool window is defined, it's common to have a command to allow showing the tool window. The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
public class MyToolWindowCommand : Command
{
```

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new("%ToolWindowSample.MyToolWindowCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };
```

The command is placed in the `Tools` top menu and uses the `ToolWindow` icon moniker.

```csharp
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
    }
```

When executed, the command will use the tool window type to look up and show that tool window. Because the parameter 'activate' is true, the tool window content will be focused when the tool window is shown. Passing 'false' instead means the tool window and its content will be shown, but not receive focus.

## Logging errors

Each extension part including command sets is assigned a `TraceSource` instance that can be utilized to log diagnostic errors. Please see [Logging](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/logging) section for more information.

## Usage

Once deployed, the My Tool Window command can be used to show My Tool Window in the document well.
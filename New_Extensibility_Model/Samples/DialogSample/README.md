---
title: Dialog Sample reference
description: A reference for Dialog sample
date: 2023-10-24
---

# Walkthrough: Dialog Extension Sample

This extension is a simple extension that shows how a command that shows a dialog can be quickly added to Visual Studio.

## Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
public class MyDialogCommand : Command
{
```

The `CommandConfiguration` property defines information about the command that are available to Visual Studio even before the extension is loaded:

```csharp
    public override CommandConfiguration CommandConfiguration => new("%DialogSample.MyDialogCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Dialog, IconSettings.IconAndText),
    };
```

The command is placed in the `Tools` top menu and uses the `Dialog` icon moniker.

The dialog is shown when the command is executed using the Shell helpers:

```csharp
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        // Ownership of the RemoteUserControl is transferred to VisualStudio, so it should not be disposed by the extension
        #pragma warning disable CA2000 // Dispose objects before losing scope
        var control = new MyDialogControl(null);
        #pragma warning restore CA2000 // Dispose objects before losing scope

        await this.Extensibility.Shell().ShowDialogAsync(control, cancellationToken);
    }
```

The dialog title and buttons can be customized as well, but are left as the default in the sample. You can refer to [Dialog](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/dialog/dialog) for more information about setting up a dialog.

## Dialog content creation

The dialog content is created as a DataTemplate .xaml file and a separate control class .cs file:

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
internal class MyDialogControl : RemoteUserControl
{
```

The .cs and .xaml files should have the same name (MyDialogControl in this sample). Additionally the xaml file should be included as an EmbeddedResource instead of a Page, so editing the csproj file may be necessary in some cases.

You can refer to [Add content to a tool window](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/tool-window/tool-window#add-content-to-a-tool-window) to learn more about setting up the tool window content and remote UI.

## Resource dictionaries

The extension also shows how to reference a resource dictionary from a Remote UI control:

```chsarp
internal class MyDialogControl : RemoteUserControl
{
    public MyDialogControl(object? dataContext, SynchronizationContext? synchronizationContext = null)
        : base(dataContext, synchronizationContext)
    {
        this.ResourceDictionaries.AddEmbeddedResource("DialogSample.MyResources.xaml");
    }
```

The resource dictionary and its localized variants must be configured as embedded resources:

```xml
<ItemGroup>
  <EmbeddedResource Include="MyResources.*xaml" />
  <Page Remove="MyResources.*xaml" />
</ItemGroup>
```

Resources provided by the resource dictionary can be referenced as dynamic resources:

```csharp
<TextBlock Text="{DynamicResource myDialogText}" />
```

## Logging errors

Each extension part including command sets is assigned a `TraceSource` instance that can be utilized to log diagnostic errors. Please see [Logging](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/logging) section for more information.

## Usage

Once deployed, the Insert Guid command can be used when editing any code files. The command by default will be under Extensions menu.
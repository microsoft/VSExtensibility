---
title: Commands reference
description: A reference for extensibility commands
date: 2022-7-20
---

# Commands Overview

A command represented by the `Command` class is some action that can be initiated by a user, such as when the user chooses a menu item, presses a toolbar button, or types a keyboard shortcut. Commands have an ID and a display name, an execution method (`ExecuteCommandAsync`) that performs the action, as well as a means to provide parameters, an icon for display in the toolbar to identify the command, a tooltip to explain the command to the user, and they can be enabled or disabled depending on various conditions.

Commands in the new Extensibility Model run asynchronously and so the user can continue to interact with the IDE while commands are executing.

## Get started

To get started, follow the [create the project](../getting-started/create-your-first-extension.md) section in Getting Started section.

Next, see the [InsertGuidSample](./../../../../New_Extensibility_Model/Samples/InsertGuidExtension) sample for a more complete look at creating an extension with a command.

## Work with commands

This guide is designed to cover the top user scenarios when working with Commands:

- [Creating a Command](#creating-a-command)
- [Placing a Command in the IDE](#placing-a-command-in-the-ide)
- [Adding an Icon to a Command](#adding-an-icon-to-a-command)
- [Controlling the Visibility of a Command](#controlling-the-visibility-of-a-command)
- [Controlling the Enabled/Disabled state of a Command](#controlling-the-enableddisabled-state-of-a-command)
- [Setting additional Command Metadata Using Flags](#setting-additional-command-metadata-using-flags)
- [Localizing a Command](#localizing-a-command)
- [Changing the Display Name of a Command](#changing-the-display-name-of-a-command)

## Create a command

Creating a command with the new Extensibility Model begins with extending the base class [`Microsoft.VisualStudio.Extensibility.Commands.Command`](./../../api/Microsoft.VisualStudio.Extensibility.md/#command-type) and adorning your class with the attribute [`Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandattribute-type).

```csharp
[Command(CommandId, CommandDisplayName)]
public class MyCommand : Command
```

### Command attribute

The [`CommandAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandattribute-type) attribute has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| Id | String | Yes | A globally unique identifier for the command. It is recommended to use the full class name of your command here. |
| DisplayName | String | Yes | The default display name of your command. Surround this string with the '%' character to enable localizing this string. See more on this at [Localizing a command](#localizing-a-command). |
| TooltipText | String | No | The text to display as the tooltip when the command is hovered or focused. |
| Flags | CommandFlags | No | Flags to set additional properties on the command. Some options include CanToggle and CanSelect. See more on this at [Setting additional Command Metadata Using Flags](#setting-additional-command-metadata-using-flags). |
| ContainerType | Type? | No | The type that is to act as the CommandSet for this command. Setting this parameter to null automatically generates a default CommandSet for your command. |
| Placement | CommandPlacement | No | Indicates where within Visual Studio your command should be parented. If no placement is provided the command defaults to being parented to the Standard toolbar. |
| ClientContexts | String | No | Client contexts requested by the command, separated by ','. By default the Shell and Editor contexts are returned. A client context is a snapshot of specific IDE states at the time a command was originally executed. Since these commands are executed asynchronously this state could change between the time the user executed the command and the command handler running. See more on this at [Client contexts](./../../inside-the-sdk/activation-constraints.md/#client-contexts). |

### Example

The `Command` also needs a constructor that takes the `VisualStudioExtensibility` object (which allows communication with the IDE), and an execution method `ExecuteCommandAsync`. The following example provides a minimal implementation of a generic command that doesn't do anything:

```csharp
[Command(CommandId, "My Command", placement: CommandPlacement.ToolsMenu)]
public class MyCommand : Command
{
	private const string CommandId = "MyCommand";

	public MyCommand(VisualStudioExtensibility extensibility, string id)
		: base(extensibility, id)
	{
	}

	public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}
}
```

## Place a command in the IDE

There are a set of well-defined places in Visual Studio where commands can be placed. These placements are defined by the enum `Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement`, which is passed into the constructor of the [Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandattribute-type) on your class. The current set of supported placements are:

- `CommandPlacement.ToolsMenu` - The command will be placed in a group under the top-level "Tools" menu in Visual Studio.
- `CommandPlacement.ViewOtherWindowsMenu` - The command will be placed in a group under the top-level "View" -> "Other Windows" menu in Visual Studio.
- `CommandPlacement.ExtensionsMenu` - The command will be placed in a group under the top-level "Extensions" menu in Visual Studio.

```csharp
[Command(CommandId, CommandDisplayName, placement: CommandPlacement.ExtensionsMenu)]
public class MyCommand : Command
```

## Add an icon to a command

Commands support adding icons to their menu item, either in addition to or instead of the display name of the command. To add an icon to your command, add the attribute [`Microsoft.VisualStudio.Extensibility.Commands.CommandIconAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandiconattribute-type) to your command class.

### CommandIcon Attribute

The [`CommandIconAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandiconattribute-type) has two parameters:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| ImageMoniker | String | Yes | You can either use a custom moniker for an image that you added following the [Adding custom images](#adding-custom-images) section or reference a Visual Studio [KnownMoniker](/dotnet/api/microsoft.visualstudio.imaging.knownmonikers) like `KnownMonikers.AddItem` |
| IconSettings | IconSettings | Yes | Configures how the command will be displayed. For example `IconSettings.IconAndText` displays the icon alongside the command's display name, whereas `IconSettings.IconOnly` will only show the command's icon and not its DisplayName if parented to a toolbar. |

### Example

```csharp
[CommandIcon(KnownMonikers.Extension, IconSettings.IconAndText)]
```

### Use a custom image for the command icon

You can add custom images, which you can then reference with custom monikers by following these steps:

1. Rename the image source files to follow the `%Custom Moniker%.*` pattern (for example, `MyMoniker.1.png`). Files prefixed with the same moniker will all be used as backing sources for the same custom moniker. Different source will be used based on the requested icon size.
	- For example, `MyImage.16.16.png` (a 16\*16 png), `MyImage.20.20.png` (a 20\*20 png) and `MyImage.xaml` are all considered as sources for `MyImage`. 
	- When the requested icon size is 16*16, `MyImage.16.16.png` will be used, when requested size is 20\*20, `MyImage.20.20.png` will be used, in all other cases, `MyImage.xaml` will be used.
2. Put all of the image source files under `Images` folder.
	- The default image assets folder is `Images`, but you can also customized it by adding `<ImageAssetsPath>%YourFolder%</ImageAssetsPath>`
  
### Example

```csharp
[CommandIcon("MyImage", IconSettings.IconAndText)]
```

# Control the visibility of a command

The visibility of a command can be controlled by adding the attribute [`Microsoft.VisualStudio.Extensibility.Commands.CommandVisibleWhenAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandvisiblewhenattribute-type) to your command class.

The attribute supports specifying a condition through a number of individual parameters that together specify the condition and all its logic and inputs. To specify the condition, you specify an expression in one parameter, define a set of terms (strings) used in the expression in another parameter, and what values those terms should be replaced with upon evaluation in a third parameter. The combination of the expression, terms, and values is called a *rule-based activation constraint* and is fully described at [Using rule based activation constraints](../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints).

When you specify the parameters for term names and their corresponding values, you give them in the same sequence but in different parameters. The term name at index 0 corresponds with the term value at that same index. The command is visible when the expression evaluates to true, and invisible when it is false.

If this attribute is omitted from your command, the default is for the command to always be visible.

### Example

```csharp
// This command would become visible when an editor for a file with any file extension is active.
[CommandVisibleWhen(
	expression: "AnyFile",
	termNames: new string[] { "AnyFile" },
	termValues: new string[] { "ClientContext:Shell.ActiveEditorContentType=.+" })]
```

## Control the Enabled/Disabled state of a command

The visibility of a command can be controlled by adding the attribute [Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandenabledwhenattribute-type) to your command class. The attribute works by accepting a rule-based activation constraint, as described in the previous section, so it involves specifying an expression in one parameter, terms in another parameter, and values for those terms in a third parameter. The command would be enabled when the expression evaluates to true, and disabled when it is false.

If this attribute is omitted from your command, the default is for the command to always be enabled. You can also automatically have your command be disabled if it is currently executing by setting `this.DisableDuringExecution = true;` in the constructor of your command class. Setting this property will override the enabled/disabled state defined by the `Microsoft.VisualStudio.Extensibility.Commands.CommandEnabledWhenAttribute` while the command is being executed.

### Example

```csharp
// This command would become enabled when a solution is loaded in the IDE and a file with the file 
// extension ".jpg", ".jpeg", or ".txt" is selected in the Solution Explorer.
[CommandEnabledWhen(
	expression: "SolutionLoaded & IsValidFile",
	termNames: new string[] { "SolutionLoaded", "IsValidFile" },
	termValues: new string[] { "SolutionState:Exists", "ClientContext:Shell.ActiveSelectionFileName=(.jpg|.jpeg|.txt)$" })]
```

For more information on valid term values, see [Using rule based activation constraints](./../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints).

## Setting additional command metadata using flags

Command flags help define additional properties on your commands that are used at runtime to define special behaviors that your command can have. The flags that are currently supported are:

- `CanToggle` - Indicates that the `IsChecked` property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsTogglePatternAvailable` return true for the UI element.
- `CanSelect` - Indicates that the `IsChecked` property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsSelectionPatternAvailable` return true for the UI element.

## Localizing a command

The text displayed on a command can be localized by including *string-resources.json* files with your extension and surrounding the `DisplayName` parameter with `%` characters in your [Microsoft.VisualStudio.Extensibility.Commands.CommandAttribute](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandattribute-type).

A `Command` attribute with a localized `DisplayName` looks like the following:

```csharp
[Command(CommandId, "%Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName%", placement: CommandPlacement.ToolsMenu)]
```

### string-resources.json

Your extension should provide a `string-resources.json` file for every language that your extension supports. This JSON file is a dictionary of key/value pairs where the key is a globally (all of Visual Studio) unique identifier for a string resource and the value is the localized string resource. These JSON files should be deployed with your extension under the ".vsextension" directory, with each language you support being shipped in a folder matching the name of the locale, that is, "de" for German, "it" for Italian, etc. The `string-resources.json` deployed at the root of the ".vsextension" directory is used as the default if your extension does not support the language that Visual Studio is currently set to. An example of what this directory structure would look like can be seen here:

![Localization directory structure](localizing-a-command.png "Localization directory structure")

string-resources.json sample:

```json
{
    "Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName": "Sample Remote Command",
    "Microsoft.VisualStudio.MyExtension.OutputWindowTest.DisplayName": "Output Window Test"
}
```

## Change the display name of a command

While the display name for a command is initially set in the [`CommandAttribute`](./../../api/Microsoft.VisualStudio.Extensibility.md/#commandattribute-type) (see [Creating a Command](#creating-a-command)), it can be changed at runtime by setting the `DisplayName` property in your command.

### Example

```csharp
[Command(CommandId, "Initial Display Name")]
public class MyCommand : Command
{
    private const string CommandId = "MyCommand";

    public MyCommand(VisualStudioExtensibility extensibility, string id)
     : base(extensibility, id)
    {
    }

    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        // Update the command's Display Name
        this.DisplayName = "Updated Display Name";
        return Task.CompletedTask;
    }
}
```

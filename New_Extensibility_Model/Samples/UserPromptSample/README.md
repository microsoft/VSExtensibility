---
title: User Prompt Sample reference
description: A reference for User Prompt sample
date: 2023-10-25
---

# User Prompt Extension Sample

This is a simple extension that shows how to display user prompts during execution of a command.

## Command definition

The extension contains a code file that defines a command and its properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
```

The `VisualStudioContribution` attribute registers the command using the class full type name `UserPromptSample.SampleCommand` as its unique identifier.

The `CommandConfiguration` property defines information about the command that is available to Visual Studio even before the extension is loaded:

```csharp
public override CommandConfiguration CommandConfiguration => new("%UserPromptSample.SampleCommand.DisplayName%")
{
    TooltipText = "%UserPromptSample.SampleCommand.ToolTip%",
    Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
};
```

The command is placed in the `Tools` top-level menu.

## Getting the ShellExtensibility helpers

Once user executes the command, the SDK will route execution to the `ExecuteCommandAsync` method.

In our example, we utilize the `VisualStudioExtensibility` object to acquire the `ShellExtensibility` helpers.

```csharp
var shell = this.Extensibility.Shell();
```

## Asking the user to confirm an operation

Once we have the shell helpers, we use the `ShowPromptAsync` method to prompt the user with a message asking whether to continue executing the command. We use the built-in `PromptOptions.OkCancel` to configure the
choices presented to the user. If the user does not click 'OK' `ShowPromptAsync` will return `false`, and we
return early from the command handler.

```csharp
if (!await shell.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel, ct))
{
    return;
}
```

## Asking to user to confirm a destructive or long-running operation

For confirm operations which could be destructive, it may be preferable to have the 'Cancel' button be the
default selection, instead of 'OK'. `PromptOptions.OKCancel` has a `WithCancelAsDefault` method which
will accomplish this.

```csharp
// Asking the user to confirm a dangerous operation.
if (!await shell.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel.WithCancelAsDefault(), ct))
{
    return;
}
```

## Asking the user to select from a set of custom options

In addition to the built-in `PromptOptions`, we can define a set of custom options using `PromptOptions<T>`. `ShowPromptAsync` will return the value of type `T` that we map to each option label. In this example, if the user selects the button with the label 'GruvBox Is Groovy', `ShowPrompAsync` will return the enum value `TokenThemeResult.GruvBox`.

The example also demonstrates configuring the return value if the user dismisses the prompt without
making a selection using the `PromptOptions<T>.DismissedReturns` property, and setting the default
selection using the `PromptOptions<T>.DefaultChoiceIndex` property.

```csharp
// Custom prompt
var themeResult = await shell.ShowPromptAsync(
    "Which theme should be used for the generated output?",
    new PromptOptions<TokenThemeResult>
    {
        Choices =
        {
            { "Solarized Is Awesome", TokenThemeResult.Solarized },
            { "OneDark Is The Best", TokenThemeResult.OneDark },
            { "GruvBox Is Groovy", TokenThemeResult.GruvBox },
        },
        DismissedReturns = TokenThemeResult.None,
        DefaultChoiceIndex = 2,
    },
    ct);
```

## Usage

Once deployed, the User Prompt Sample command can be invoked anytime from the Tools menu.

See also, [Create Visual Studio user prompts](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/user-prompt/user-prompts).
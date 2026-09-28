---
title: User Prompt Sample reference
description: A reference for User Prompt sample
date: 2025-04-25
---

# User Prompt Extension Sample

This is a simple extension that shows how to display user prompts during execution of a command.

## Command definition

The extension contains code files that define commands and their properties starting with the `VisualStudioContribution` class attribute which makes the command available to Visual Studio:

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

The commands are placed in the `Tools` top-level menu.

## Getting the ShellExtensibility helpers

Once the user executes the command, the SDK will route execution to the `ExecuteCommandAsync` method.

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

## Asking the user to confirm a destructive or long-running operation

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

In addition to the built-in `PromptOptions`, we can define a set of custom options using `PromptOptions<T>`. `ShowPromptAsync` will return the value of type `T` that we map to each option label.
In this example, if the user selects the button with the label 'GruvBox Is Groovy', `ShowPrompAsync` will return the enum value `TokenThemeResult.GruvBox`.

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

## Additional Customization

Prompts can be further customized with icons and custom titles. This example uses the built-in `PromptOptions.ErrorConfirm` to create
a prompt with a single 'OK' button and the default error icon. The title is customized by overriding the default `Title` property using `with`.

```csharp
if (string.IsNullOrEmpty(projectName))
{
    this.logger.TraceInformation("User did not provide project name.");

    // Show a confirmation prompt (one 'OK' button) with error icon and title.
    await shell.ShowPromptAsync(
        "Project name is required to proceed. Exiting the configuration process.",
        PromptOptions.ErrorConfirm with { Title = Title },
        cancellationToken);

    return;
}
```

Choose your own icon by providing an `ImageMoniker`.

```csharp
bool confirmConfiguration = await shell.ShowPromptAsync(
    $"The selected system ({selectedSystem}) may require additional resources. Do you want to proceed?",
    PromptOptions.OKCancel with
    {
        Title = Title,
        Icon = ImageMoniker.KnownValues.StatusSecurityWarning,
    },
    cancellationToken);
```

## Input Prompts

Using `InputPromptOptions`, you can ask the user to provide a single-line string response, instead of choosing from a defined list of options.
This example shows a prompt asking the user to provide feedback, and provides a default value they can accept as is, or overwrite.

```csharp
string? feedback = await shell.ShowPromptAsync(
    $"Thank you for configuring {projectName}. Do you have any feedback?",
    new InputPromptOptions
    {
        DefaultText = "Works as expected.",
        Icon = ImageMoniker.KnownValues.Feedback,
        Title = Title,
    },
    cancellationToken);
```

If you don't want to provide `DefaultText`, you can use `InputPromptOptions.Default` as a
starting point. The project-name prompt uses `Validation` to require a name starting
with a letter and containing only letters, numbers, hyphens, or underscores:

```csharp
string? projectName = await shell.ShowPromptAsync(
    "Enter the name of the project to configure?",
    InputPromptOptions.Default with
    {
        Title = Title,
        Validation = new InputValidation(
            @"^[A-Za-z][A-Za-z0-9_-]*$",
            "Start with a letter; use only letters, numbers, hyphens, or underscores."),
    },
    cancellationToken);
```

Until the input matches, the prompt displays the error message and disables OK. Input
prompts always show a dismiss button and can also be dismissed with `Esc`. Dismissal
returns `null`, which this command treats as no project name and does not configure
anything. If the user accepts `DefaultText` using OK or `Enter`, the return value is
the default text.

### Asynchronous validation

The same project-name prompt also sets `ValidationCallback` to reject the reserved
Windows name `CON`. The SDK calls this callback after the regex check passes and
debounces calls while the user types. The short delay stands in for an asynchronous
lookup; the cancellation token cancels a validation request that is no longer needed.
The callback returns an error message to disable OK, or `null` to accept the name:

```csharp
ValidationCallback = async (input, token) =>
{
    // Simulate an asynchronous lookup without relying on an external service.
    await Task.Delay(150, token);
    return string.Equals(input, "CON", StringComparison.OrdinalIgnoreCase)
        ? "CON is a reserved Windows name; choose another project name."
        : null;
},
```

Try `CON` to see the callback error, or `MyProject` to continue. Dismissing the
prompt still returns `null` without configuring a project.

## Usage

Once deployed, the User Prompt Sample commands can be invoked anytime from the Tools menu.

See also, [Create Visual Studio user prompts](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/user-prompt/user-prompts).
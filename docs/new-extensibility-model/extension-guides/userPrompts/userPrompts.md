---
title: User Prompts reference
description: A reference for extensibility user prompts
date: 2022-07-29
---

# User Prompts

User Prompts are a simple UI mechanism for prompting the user during the execution of a [Command Handler](). Prompting the user creates a dialog box with a message, one to three buttons for the choices, and a dismiss button. 

Common examples are requesting confirmation with an OK/Cancel prompt, or asking the user to choose among a small set of options (no more than three).

Only a single prompt can be visible at a time, and the user always has the option of dismissing the prompt without making a selection.

The choices presented to the user are mapped to return values of the type defined in the `TResult` type parameter.

# Parts of a user prompt

TODO: Image

1. Message
2. Choice Buttons
3. Default Choice
4. Dismiss Button

## Creating user prompts

User Prompts can only be created inside of a command handler. To get started, [Create the extension project]() and [Add your first command]().

Inside the [ExecuteCommandAsync]() method, call [IClientContext.ShowPromptAsync&lt;TResult&gt;](). `ShowPromptAsync` takes three parameters:

1. The message of the prompt.
2. An instance of [PromptOptions](), which defines the choices to show the user.
3. A CancellationToken. Triggering the token will close the prompt before the user makes a choice.

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| message   | string | Yes | The text of the message for the prompt. |
| options   | [PromptOptions&lt;TResult&gt;]() | Yes | Defines the user choices, mapping them to return values. |
| cancellationToken | CancellationToken | Yes | When triggered, force closes the prompt. |

## Built-in options

Several sets of pre-defined [PromptOptions]() are available in the SDK.

### OK

| Choice | Default | Return Value |
|--------|---------|--------------|
| "OK"   | Yes | true |
| _Dismissed_ | | false |

### OKCancel

| Choice | Default | Return Value |
|--------|---------|--------------|
| "OK"   | Yes | true |
| "Cancel" | No | false |
| _Dismissed_ | | false |

### RetryCancel

| Choice | Default | Return Value |
|--------|---------|--------------|
| "Retry" | Yes | true |
| "Cancel" | No | false |
| _Dismissed_ | | false |

### Using a built-in option

TODO: Image

Create a prompt with a single "OK" choice.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    // Asking the user to confirm an operation.
    if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel, ct))
    {
      return;
    }
    
    ...
}
```

If the user clicks "OK", `ShowPromptAsync` will return `true` when awaited. If the user clicks the dismiss button, it will return `false`.

### Change the default choice of a built-in option to "Cancel"

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
  // Asking the user to confirm an operation.
  if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel.WithCancelAsDefault(), ct))
  {
    return;
  }
  
  ...
}
```

## Custom options

In addition to the built-in options, you can customize the choices presented to the user and the return value mapped to each.

Instead of using the sets defined in [PromptOptions](), create a new instance of [PromptOptions&lt;TResult&gt;]() and pass it to `ShowPromptAsync`.

Start by creating a value type to define the return values:

```csharp
public enum TokenThemeResult
{
  None,
  Solarized,
  OneDark,
  GruvBox,
}
```

Then create the `PromptOptions&lt;TResult&gt;` instance and pass it to `ShowPromptAsync` along with the required `message` and `cancellationToken` arguments:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
  // Custom prompt
  var themeResult = await context.ShowPromptAsync(
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

  Debug.WriteLine($"Selected Token Theme: {themeResult}");
}
```

The `Choices` collection maps the user choices to values in the `TokenThemeResult` enum. `DismissedReturns` sets the value that is returned if the user clicks the dismiss button. `DefaultChoiceIndex` is a zero-based index into the `Choices` collection that defines the default choice.

## Samples

* [UserPromptSample]()
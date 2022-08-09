---
title: Output Window Reference
description: A reference for output window extensibility
date: 2022-08-01
---

# Output Window Overview

The Output Window in the Visual Studio IDE is a [Tool Window](./../toolWindow/toolWindow.md) that can be used to deliver status, diagnostics/logging, or any other informational text to the user. Unlike [User Prompts](./../userPrompts/userPrompts.md), which might display a message box, the messages written to the Output Window are only displayed if the user has the Output pane visible in the IDE (Output in the View menu) and your Channel selected in the "Show output from:" dropdown menu.

# Getting Started

To get started, follow the [create the project](./../../getting-started/create-your-first-extension.md) section in Getting Started section.

Next, see the [OutputWindowSample](./../../../../New_Extensibility_Model/Samples/OutputWindowSample) sample for a full example of creating an extension that uses the output window.

# Working with the Output Window

This guide is designed to cover the top user scenarios when working with the Output Window:

- [Getting an Output Window Channel](#getting-an-output-window-channel)
- [Writing to the Output Window](#writing-to-the-output-window)

# Getting an Output Window Channel

In order to write to the Output Window, you need an Output Window Channel which can be created by calling `VisualStudioExtensibility.Views().Output.GetChannelAsync()`.

## `OutputWindowExtensibility.GetChannelAsync()`

The `GetChannelAsync()` method has three parameters:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| `identifier` | `string` | yes | A unique identifier for the channel. |
| `displayNameResourceId` | `string` | yes | The name of the [resource](https://docs.microsoft.com/en-us/dotnet/core/extensions/resources) that contains the display name of the output window. This is what will be visible in the "Show output from:" dropdown menu in the Output pane.<br /><br />For example, if you had a [`.resx`](https://docs.microsoft.com/en-us/dotnet/core/extensions/resources) resource file called `MyStrings.resx` with a resource named "OutputWindowDisplayName", you would use `nameof(MyStrings.OutputWindowDisplayName)` for this parameter. |
| `cancellationToken` | [`CancellationToken`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) | yes | The [`CancellationToken`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) for the async operation. |

## Display Name Resource ID Requirements

The current version of the Output Window API requires that the display name for the Output Window Channel be stored in a Resource File:

 - Add a [`.resx` file](https://docs.microsoft.com/en-us/dotnet/core/extensions/resources) ([sample](./../../../../New_Extensibility_Model/Samples/OutputWindowSample/Strings.resx)) and make sure it is configured with the ResXFileCodeGenerator in your project ([sample](./../../../../New_Extensibility_Model/Samples/OutputWindowSample/OutputWindowSample.csproj)).
 - Add an [Extension class](../../inside-the-sdk/extension-anatomy.md#extension-instance) to your project, if it doesn't have one already ([sample](./../../../../New_Extensibility_Model/Samples/OutputWindowSample/OutputWindowSampleExtension.cs))
 - In the Extension class override the `ResourceManager` property to return the ResourceManager corresponding to your .resx file.

## Example

### `.resx` [Resource File](https://docs.microsoft.com/en-us/dotnet/core/extensions/resources)

In this case, `MyStrings.resx`:

```xml
  <data name="OutputWindowDisplayName" xml:space="preserve">
    <value>My Output Window</value>
  </data>
```

### `.csproj` Project File

```xml
	<ItemGroup>
	  <Compile Update="MyStrings.Designer.cs">
	    <DesignTime>True</DesignTime>
	    <AutoGen>True</AutoGen>
	    <DependentUpon>MyStrings.resx</DependentUpon>
	  </Compile>
	</ItemGroup>

	<ItemGroup>
	  <EmbeddedResource Update="MyStrings.resx">
	    <Generator>ResXFileCodeGenerator</Generator>
	    <LastGenOutput>MyStrings.Designer.cs</LastGenOutput>
	  </EmbeddedResource>
	</ItemGroup>
```

### Extension Class

In this case, `MyExtension.cs`:

```csharp
public class MyExtension : Extension
{
	protected override ResourceManager? ResourceManager => MyStrings.ResourceManager;
}
```

**Note:** Make sure that the MyExtension class is in the same namespace as the `MyStrings` resource class, which defaults to the name of the project, unless you have overridden it.

### Extension code:

```csharp
string id = "MyOutputWindow";
string displayNameResourceId = nameof(Strings.OutputWindowDisplayName);
OutputWindow? outputWindow = await this.Extensibility.Views().Output.GetChannelAsync(id, displayNameResourceId, cancellationToken);
```

# Writing to the Output Window

The [`OutputWindow`](./../api/../../api/Microsoft.VisualStudio.Extensibility.md#outputwindow-type) instance obtained in [Getting an Output Window Channel](#getting-an-output-window-channel) has a [`System.IO.TextWriter`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter) property called `Writer`, which supports familiar operations for writing text, such as:
- [`Write()`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter.write)
- [`WriteAsync()`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter.writeasync)
- [`WriteLine()`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter.writeline)
- [`WriteLineAsync()`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter.writelineasync)

## Example

```csharp
if (this.outputWindow != null)
{
    await this.outputWindow.Writer.WriteLineAsync("This is a test of the output window.");
}
```
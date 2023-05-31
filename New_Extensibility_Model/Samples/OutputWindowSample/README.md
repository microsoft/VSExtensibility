---
title: Output Window Sample Extension reference
description: A reference for Output Window Sample extension
date: 2022-08-01
---

# Walkthrough: Output Window Sample Extension

This extension demonstrates the most basic usage of the [Output Window API](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window)

## Summary

This extension adds a [command](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/command/command) to the Tools menu called "Test the Output Window". When invoked, the command will print `"This is a test of the output window."` to the Output pane in a Channel called "MyOutputWindow" (look for the Channel name in the "Show output from:" dropdown in the Output pane).

## TestOutputWindowCommand

[`TestOutputWindowCommand.cs`](TestOutputWindowCommand.cs) contains a command that demonstrates two parts of the Output Window API.

### Getting an Output Window Channel

The `GetOutputWindowAsync()` method creates an Output Window Channel by calling `Extensibility.Views().Output.GetChannelAsync()`. `GetChannelAsync()` takes the name of a resource from the ResourceManager set up in the [`Extension` class](#extension-class).

See [Getting an Output Window Channel](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window#get-an-output-window-channel) for more information.

### Writing to the Output Window

In the `ExecuteCommandAsync()` method, the `Writer` property of the `OutputWindow` instance is used to write a message to the Output pane in the IDE.

See [Writing to the Output Window](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window#write-to-the-output-window) for more information.

## Extension Class

As described in the [Output Window Display Name Resource ID requirements](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/output-window/output-window#display-name-resource-id-requirements), the current version of the Output Window API requires that the display name for the Output Window Channel be stored in a [Resource File](https://learn.microsoft.com/dotnet/core/extensions/resources) (such as a [`.resx`](https://learn.microsoft.com/dotnet/core/extensions/resources) resource file.)

In order for the call to `OutputExtensibility.GetChannelAsync()` to find the display name, the resource file must be associated with the [`Extension` Instance](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/extension-anatomy#extension-instance) by overriding the `ResourceManager` property.

[`OutputWindowSampleExtension.cs`](OutputWindowSampleExtension.cs) demonstrates this functionality.

## Resources File

The [`Strings.resx`](Strings.resx) file is a [Resource File](https://learn.microsoft.com/dotnet/core/extensions/resources) that contains the display name of the Output Window Channel for this extension.

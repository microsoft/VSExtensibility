---
title: Dialogs reference
description: A reference for extensibility dialogs
date: 2023-1-20
---

# Dialogs Overview

Dialogs are a way to prompt a user for information related to usage of a feature or allow customizations of a feature's behaviors. For example, the Tools/Options dialog provides a individual pages that let the user change various feature behaviors such as theming, editors, and document tabs.

Tool windows are single-instance, meaning that only one instance of the Tool Window can be open at a time. When a Tool Window is closed in the IDE, it is only visibly hidden, instead of being fully closed and disposed of like documents. 

# Getting Started

To get started, follow the [create the project](./../../getting-started/create-your-first-extension.md) section in Getting Started section.

Next, see the [DialogExtension](./../../../../New_Extensibility_Model/Samples/DialogExtension) sample for a full example of creating an extension with a dialog.

# Working with dialogs

This guide is designed to cover the top user scenarios when working with dialogs:

- [ShowDialogAsync](#showdialogasync)
- [Creating a dialog](#creating-a-dialog)
- [Customizing the dialog title](#customizing-the-dialog-title)
- [Customizing the dialog buttons](#customizing-the-dialog-buttons)
- [Getting the dialog result](#getting-the-dialog-result)

# ShowDialogAsync

The ShowDialogAsync method several overloads that you should become familiar with:

- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,title,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,options,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,title,options,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-)

# Creating a dialog

Creating a tool window with the new Extensibility Model is as simple as calling the ShowDialogAsync method from the [ShellExtensibility](./../../api/Microsoft.VisualStudio.Extensibility.md/#T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility) helpers and passing in your dialog content.

## Example

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	using var control = new MyDialogControl(null);

	await this.Extensibility.Shell().ShowDialogAsync(control, cancellationToken);
}
```

See the [Remote UI](./../../inside-the-sdk/remote-ui.md) docs for more information on creating a RemoteUserControl.

# Customizing the dialog title

When showing a dialog a custom title string can be provided which will be displayed in the dialog's caption region.

## Example

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	using var control = new MyDialogControl(null);

	await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", cancellationToken);
}
```

# Customizing the dialog buttons

When showing a dialog certain combinations of predefined dialog buttons and default actions can be selected. The predefined button and action combinations can be found in Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption. Additionally, you can create your own combination of buttons and default actions from:

- Microsoft.VisualStudio.RpcContracts.Notifications.DialogButton
- Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult

## Examples

Adding a cancel button:
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	using var control = new MyDialogControl(null);

	await this.Extensibility.Shell().ShowDialogAsync(control, DialogOption.OKCancel. cancellationToken);
}
```

Having no dialog buttons:
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	using var control = new MyDialogControl(null);

	await this.Extensibility.Shell().ShowDialogAsync(control, new DialogOption(DialogButton.None, DialogResult.None), cancellationToken);
}
```

# Getting the dialog result

If you need to know whether a user affirmatively closed a dialog or dismissed it, you can await the call to ShowDialogAsync and it will return a Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult which represents the action taken by the user.

## Example
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	using var control = new MyDialogControl(null);

	DialogResult result = await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", DialogOption.OKCancel, cancellationToken);

	if (result == DialogResult.OK)
	{
		// User clicked the OK button
	}
}
```
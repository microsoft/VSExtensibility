---
title: Create a simple extension
description: A tutorial for creating a simple OOP extension
date: 2022-10-27
---
# Create a simple extension

In [Create your first extension](create-your-first-extension.md), you learned how to use the VisualStudio.Extensibility project template to create an extension project, and learned how to build it and debug it in the experimental instance of Visual Studio.

In this tutorial, you'll learn how to create an extension with a simple command that does something in the Visual Studio editor. In this case, it inserts a newly generated GUID.

Before you begin, you'll need to decide on some specific questions about the design of the extension. One of the questions you always have to answer when creating a Visual Studio extension is when it should be made available. Visual Studio supports a large number of different project types, programming languages, and file types that you'll need to tell Visual Studio what file types your extension makes sense to be used with. In this example, the range of file types is not limited to one programming language, it could be quite large, since many different contexts might involve the generation of GUIDs.  In this tutorial, you'll see how to tell Visual Studio that the GUID extension what file types it's enabled for.

Another question is how users will access the functionality of your extension. Will they click a menu item, either on the main menu or a context menu, which appears as a right-click on some UI element?  Or will there be a toolbar button somewhere, either on the main command bar near the top of the IDE, or in a tool window, that is, one of the smaller windows that can be docked in Visual Studio's main surface. And, when will the menu item or toolbar button appear at all, and when will it appear disabled (grayed out), and when will it be enabled. If it is a toolbar button, you'll also need to get an icon file ready for it, or multiple icon files if it can appear in smaller or larger versions of the button.

The completed sample for this tutorial may be found [here](~/New-Extensibility-Model/Samples.InsertGuidExtension).

The tutorial contains the following steps:

1. [Specify how the Command is hosted](#specify-how-the-command-is-hosted)
1. [Create the Command's Execute method](#create-the-commands-main-execution-method)

## Specify how the Command is hosted

In this step, you'll look at the options for hosting the command (sometimes called parenting the command) and learn how to implement those options. The purpose of hosting the command is to expose it to the user in some way, such as adding a menu item or a command bar button.

The project template or the sample you created in the [Create your first extension](create-your-first-extension.md) tutorial consists of a single C# file that includes a `Command` class already. You can simply update that in place.

1. Rename the file `InsertGuidCommand.cs`, delete the namespace, rename the class `InsertGuidCommand`, delete the old attributes on the `Command` class, and start adding new attributes for the `InsertGuidCommnd` command:

1. Add the `Command` attribute.

   ```csharp
   [Command(
	   "Microsoft.VisualStudio.InsertGuidExtension.InsertGuidCommand",
	   "Insert new guid",
	   placement: CommandPlacement.ExtensionsMenu)]
   ```

The first argument to the `Command` attribute is the `CommandId`, the second is `CommandDisplayName`, which is the menu text, and you specify any other parameters by name because they're optional. `Placement`, specifies where to host the command in the IDE. In this case, the command is placed on the Extensions menu, one of the top-level menus in Visual Studio. You can view the values of `CommandPlacement` in the reference docs, or use IntelliSense to see various choices for placement.

1. Add the `CommandIcon` attribute.

   ```csharp
   [CommandIcon("OfficeWebExtension", IconSettings.IconAndText)]
   ```

The second attribute is the `CommandIcon` attribute. Here, we specify `OfficeWebExtension`. You can specify a known built-in icon, or upload images for the icon as described in [Commands overview](../extension-guides/command/command.md).  The second argument is an enumeration that determines what is actually displayed in the IDE. The option `IconSettings.IconAndText` means show the icon and the `DisplayName` next to each other.

1. Add the `CommandVisibleWhen` attribute. This attribute specifies the conditions that must apply for the item to appear to the user.

   ```csharp
   [CommandVisibleWhen("AnyFile", new string[] { "AnyFile" }, new string[] { "ClientContext:Shell.ActiveEditorContentType=.+" })]
   ```

## Create the Command's main execution method

In this step, you'll implement the Command's `ExecuteCommandAsync` method, which defines what happens when the user chooses the menu item, or presses the command bar button that you designed to host your command.

Copy the following code to implement the method.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		Requires.NotNull(context, nameof(context));
		var newGuidString = Guid.NewGuid().ToString("N", CultureInfo.CurrentCulture);

		using var textView = await context.GetActiveTextViewAsync(cancellationToken);
		if (textView is null)
		{
			this.logger.TraceInformation("There was no active text view when command is executed.");
			return;
		}

		var document = await textView.GetTextDocumentAsync(cancellationToken);
		await this.Extensibility.Editor().EditAsync(
			batch =>
			{
				document.AsEditable(batch).Replace(textView.Selection.Extent, newGuidString);
			},
			cancellationToken);
	}
```

The first line validate the arguments, then we create a new Guid to use later.

Then, we create an `ITextViewSnapshot` (the `textView` object here) by calling the asynchronous method `GetActiveTextViewAsync`. A cancellation token is passed in to preserve the ability to cancel the asynchronous request, but this is not demonstrated in this sample. If we don't get a text view successfully, we'll write to the log and terminate without doing anything else.

Next, we request the document, an instance of `ITextDocumentSnapshot` (here `document`). 

Now we're ready to call the asynchronous method that submits a edit request to Visual Studio's editor. The method we want is `EditAsync`. That's a member of the `EditorExtensibility` class, which allows interaction with the running Visual Studio Editor in the IDE. From that object, we can call `EditAsync`. The `Command` type, which your own `InsertGuidCommand` class inherits from, has a member `Extensibility` that provides access to the `EditorExtensibility` object, so we can get to the `EditorExtensibility` class with a call to `this.Extensibility.Editor()`.

The `EditAsync` method takes an `Action<IEditBatch>` as a parameter. This is called `editorSource`, 

The call to `EditAsync` uses a lambda expression. To break this down a little, you could also write that call as follows:

```csharp
        await this.Extensibility.Editor().EditAsync(
           batch =>
           {
              var editor = document.AsEditable(batch);
              // specify the desired changes here:
              editor.Replace(textView.Selection.Extent, newGuidString);
           },
           cancellationToken);
```

You could think of this call as specifying the code that you want to be run in the Visual Studio editor process. The lambda expression specifies what you want changed in the editor. The `batch` is of type `IEditBatch` and this implies that the lambda expression defined here makes a small set of changes that should be accomplished as a unit, rather than being interrupted by other edits by the user or language service. If the code executes too long, that can lead to unresponsiveness, so it's important to keep changes within this lambda expression limited and understand anything that could lead to delays.

Using the `AsEditable` method on the document, you get a temporary editor object that you can use to specify the desired changes. Think of everything in the lambda expression as a request for Visual Studio to execute rather than as actually executing, because as described in the [Editor overview](), there's a particular protocol for handling these asynchronous edit requests from extensions, and there's a possibility of the changes not being accepted, such as if the user is making changes at the same time that create a conflict.

In practice you can use the same `EditAsync` design pattern, in which most of the code always looks the same, except for the part after the comment "specify your desired changes here".
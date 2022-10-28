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

The completed sample for this tutorial may be found [here]().


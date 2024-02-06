---
title: Breaking Changes
description: Breaking changes for VisualStudio.Extensibility
date: 2024-01-30
---

# Breaking Changes

We work hard to minimize breaking changes between versions to help minimize disruptions to your extension development, especially as VisualStudio.Extensibility matures. Some breaking changes are necessary, however, in order to add support for new features or in response to user feedback. Those changes are listed here. 

# Breaking Changes for Visual Studio 2022 17.9

The following breaking changes apply to Visual Studio 2022 17.9.

## Client Contexts

We've changed the type of the `ClientContexts` property of `Microsft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration` from `string[]?` to `ClientContextCategory[]?`.

```diff
     /// <summary>
     /// Gets or sets the client context categories requested by the command.
     /// </summary>
-    public string[]? ClientContexts { get; set; }
+    public ClientContextCategory[]? ClientContexts { get; set; }
```

### Fix
The simplest fix to address this change is to not manually set the `ClientContexts` property. The default value provides the `Editor` and `Shell`  contexts, which should be adequate for all commands. If you need to set the property manually, you can update your code to use the new `ClientContextCategory` type and recompile, fixing any compilation errors that may occur.

## Editor APIs

In order to simplify the process of working with documents and views, we've updated some of our editor APIs:
1. The `ITextViewSnapshot.GetTextDocumentAsync()` method has been **removed**. Instead, you can use the `ITextViewSnapshot.Document` property.
1. The `ITextViewSnapshot.GetOptionValueAsync()` and `ITextDocumentSnapshot.GetOptionValueAsync()` methods now return an instance of the `EditorOptionValue` class instead of a raw option value.

### Fix

1. Use the `ITextViewSnapshot.Document` property instead of the `ITextViewSnapshot.GetTextDocumentAsync()` method to get the document from a TextView snapshot.
1. Use one of the following patterns to obtain editor option values:

```cs
// Potentially throws
bool useSpaces = (await textView.GetOptionValueAsync(KnownDocumentOptions.ConvertTabsToSpacesOption, cancellationToken)).Value;
```

or 

```cs
// Never throws
bool useSpaces = (await textView.GetOptionValueAsync(KnownDocumentOptions.ConvertTabsToSpacesOption, cancellationToken)).ValueOrDefault(defaultValue: false);
```

## Command Implementation

We've updated the implementation for commands to make improvements and add features. If your extension was built against pre-17.9 version of the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages, your commands will not work on Visual Studio 2022 17.9+.

### Fix

To fix your commands, make sure you've updated your package references for the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages to be the latest 17.9+ version. Then, make sure you've updated your version of Visual Studio to 17.9 or higher.

## Extension Manifest

As part of our work to enable you to create VSIX packages for your extensions, we've made some changes to the extension manifest file. You don't need to manually edit the manifest file, but you will need to update your project to keep your extension working as expected.

### Fix

The fix will depend on whether your extensions are out-of-process or in-process (VSSDK-compatible).

#### Out-of-process extensions

All you need to do for out-of-process extensions is to update the package references for the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages to be the latest 17.9+ version. Rebuild your extension project, fix any compilation errors associated with the other breaking changes on this page, and your extension should work as expected.

#### In-process (VSSDK-compatible) extensions

In order to better support creating VSIX packages for your extensions, we've made some changes to the layout of VSSDK-compatible extension projects. The simplest thing to do would be to create a new in-process extension project, which will have the correct behavior.

Make sure you've updated to the latest Visual Studio 2022 17.9+ version and create a new in-process project, called "VisualStudio.Extensibility Extension with VSSDK Compatibility" in the New Project dialog. Copy your extension code into the new project and fix any compilation errors associated with the updated package references. Once you've rebuilt, your manifest file should have the correct value set automatically.
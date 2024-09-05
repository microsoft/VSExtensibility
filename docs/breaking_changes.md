---
title: Breaking Changes
description: Breaking changes for Visual Studio Extensibility
date: 2024-01-30
---

# Breaking Changes

We work hard to minimize breaking changes between versions to help minimize disruptions to your extension development, especially as VisualStudio.Extensibility matures. Some breaking changes are necessary, however, in order to add support for new features or in response to user feedback. Those changes are listed here.

# Breaking Changes for Visual Studio 2022 17.12
The following breaking changes apply to Visual Studio 2022 17.12

## VisualStudio.Extensibility

These breaking changes are associated with VisualStudio.Extensibility.

### Output Window
User feedback has indicated that the current experience for writing to the Output Window is too complex and confusing. Among the issues we’ve identified are:
- Confusion as to why a resource dictionary is necessary to create and write to an output channel
- Confusion over the requirement that channels have a unique ID, and what those IDs should be
- Unclear naming of functions and objects (window vs. channel, create vs. get)
 
To improve the streamline the experience, we have redesigned the API. Documentation of new API is pending.

You are impacted if you create or write to an output channel in your Gladstone commands. Indicators would be:
- References to <code>Microsoft.VisualStudio.Extensibility.Documents.OutputWindow</code>
- Calls to create a channel, like <code>await Extensibility.Views().Output.GetChannelAsync(…)</code> 

# Breaking Changes for Visual Studio 2022 17.11

The following breaking changes apply to Visual Studio 2022 17.10.

## VisualStudio.Extensibility

These breaking changes are associated with VisualStudio.Extensibility.

### Project Query

The following methods have been marked as <code>[Obsolete]</code> for future removal:

<code>Microsoft.VisualStudio.ProjectSystem.Query.UpdateExtensions.SetBuildPropertyValue(this IAsyncUpdatable<IProjectConfigurationSnapshot> configurations, string name, string value, string storageType)</code>

<code>Microsoft.VisualStudio.ProjectSystem.Query.UpdateExtensions.Delete(this IAsyncUpdatable<IBuildPropertySnapshot> buildProperties)</code>

<code>Microsoft.VisualStudio.ProjectSystem.Query.ProjectConfigurationPropertiesFilterExtensions.BuildPropertiesByName(this IProjectConfigurationSnapshot projectConfiguration, string storageType, params string[] buildPropertyNames)</code>

While this is *not* a breaking change, information has been added for future reference.

# Breaking Changes for Visual Studio 2022 17.10

The following breaking changes apply to Visual Studio 2022 17.10.

## VisualStudio.Extensibility

These breaking changes are associated with VisualStudio.Extensibility.

### Command Shortcuts

We are removing the value for `ModifierKey.Shift` from the [`ModifierKey`](https://learn.microsoft.com/dotnet/api/microsoft.visualstudio.extensibility.commands.modifierkey) enum. The `Shift` key is not a valid modifier key on its own when used for creating shortcuts in Visual Studio; it must be combined with `Control` or `Alt` to form a valid shortcut.

####

If you are using `ModifierKey.Shift` for any of your commands, you can update the shortcut to use `ModifierKey.ControlShift` or `ModifierKey.ControlShiftLeftAlt` instead.

## LSP

These breaking changes are associated with LSP.

### DiagnosticTag Enum

We have updated the Visual Studio-specific values for the [`VSDiagnosticTags`](./lsp/lsp-extensions-specifications.md#vsdiagnostictags) enum from the range [-9,-1] to the range [2147483638,2147483646]. Negative enumeration values are not supported by the LSP protocol, and the old values were causing some issues with 3rd-party LSP servers.

#### Fix

If your server is written in C# and uses the [`VSDiagnosticTags`](./lsp/lsp-extensions-specifications.md#vsdiagnostictags) enum, you need to recompile against version 17.10 or newer of the [Microsoft.VisualStudio.LanguageServer.Protocol.Extensions package](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol.Extensions).

# Breaking Changes for Visual Studio 2022 17.9

The following breaking changes apply to Visual Studio 2022 17.9.

## VisualStudio.Extensibility

These breaking changes are associated with VisualStudio.Extensibility.

### Client Contexts

We've changed the type of the `ClientContexts` property of `Microsft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration` from `string[]?` to `ClientContextCategory[]?`.

```diff
     /// <summary>
     /// Gets or sets the client context categories requested by the command.
     /// </summary>
-    public string[]? ClientContexts { get; set; }
+    public ClientContextCategory[]? ClientContexts { get; set; }
```

#### Fix
The simplest fix to address this change is to not manually set the `ClientContexts` property. The default value provides the `Editor` and `Shell`  contexts, which should be adequate for all commands. If you need to set the property manually, you can update your code to use the new `ClientContextCategory` type and recompile, fixing any compilation errors that may occur.

### Editor APIs

In order to simplify the process of working with documents and views, we've updated some of our editor APIs:
1. The `ITextViewSnapshot.GetTextDocumentAsync()` method has been **removed**. Instead, you can use the `ITextViewSnapshot.Document` property.
1. The `ITextViewSnapshot.GetOptionValueAsync()` and `ITextDocumentSnapshot.GetOptionValueAsync()` methods now return an instance of the `EditorOptionValue` class instead of a raw option value.

#### Fix

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

### Command Implementation

We've updated the implementation for commands to make improvements and add features. If your extension was built against pre-17.9 version of the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages, your commands will not work on Visual Studio 2022 17.9+.

#### Fix

To fix your commands, make sure you've updated your package references for the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages to be the latest 17.9+ version. Then, make sure you've updated your version of Visual Studio to 17.9 or higher.

### Extension Manifest

As part of our work to enable you to create VSIX packages for your extensions, we've made some changes to the extension manifest file. You don't need to manually edit the manifest file, but you will need to update your project to keep your extension working as expected.

#### Fix

The fix will depend on whether your extensions are out-of-process or in-process (VSSDK-compatible).

##### Out-of-process extensions

All you need to do for out-of-process extensions is to update the package references for the Microsoft.VisualStudio.Extensibility.Sdk and Microsoft.VisualStudio.Extensibility.Build packages to be the latest 17.9+ version. Rebuild your extension project, fix any compilation errors associated with the other breaking changes on this page, and your extension should work as expected.

##### In-process (VSSDK-compatible) extensions

In order to better support creating VSIX packages for your extensions, we've made some changes to the layout of VSSDK-compatible extension projects. The simplest thing to do would be to create a new in-process extension project, which will have the correct behavior.

Make sure you've updated to the latest Visual Studio 2022 17.9+ version and create a new in-process project, called "VisualStudio.Extensibility Extension with VSSDK Compatibility" in the New Project dialog. Copy your extension code into the new project and fix any compilation errors associated with the updated package references. Once you've rebuilt, your manifest file should have the correct value set automatically.

# Guidance and Expectations Around Breaking Changes

As VisualStudio.Extensibility matures and we continue to attract new users and extension authors, we want to ensure that we have a customer-focused approach to breaking changes that is consistent across the various feature areas in the SDK. Since one of the principals of VisualStudio.Extensibility is to create easy to use APIs that can be sustained over time, it will take us some back and forth iteration to get some of the APIs down to a state that we're satisfied with. Our goal is to provide extenders with the most up to date APIs to unblock scenarios in their extension, but we also want to reserve some room where our engineers can iterate on the shape of the API as we get feedback from customers. In order to achieve both, we have established the following guidance on how we approach how and when we break APIs for VisualStudio.Extensibility.

## Experimental APIs

Beginning with our 17.9 release, we introduced the concept of Experimental APIs to extenders. You can find a full description of our approach in the [Experimental APIs doc](https://github.com/microsoft/VSExtensibility/blob/main/docs/experimental_apis.md) on our public GitHub repo, but at a high level, we have marked certain VisualStudio.Extensibility types and members with the <code>[Experimental]</code> attribute to signal to extension authors that we expect those APIs to be less stable across releases than those in the rest of the SDK.

Typically, we mark APIs as experimental if they are part of a feature area that is still under active development, or if they have been identified through user feedback as requiring usability enhancements. To prevent surprise, extenders who want to use experimental APIs need to proactively disable the associated build error to opt-into using the feature despite the higher likelihood of breaking changes.

One of the more common questions we get from extenders is about when experimental APIs in VisualStudio.Extensibility will GA, because in most cases they want to make sure their effort migrating existing extensions or writing new ones won’t be interrupted by churn and breaking changes. By using experimental APIs, we can assure extenders that the vast majority of VisualStudio.Extensibility is already essentially GA quality and is as free from unnecessary churn as VSSDK.

### Breaking Changes to Experimental APIs

For experimental APIs:
- Breaking changes can be made as part of LTSC minor version releases of Visual Studio.
    - A list of breaking changes for the release will be shared by Preview 2 of the release.
    - This list will be shared in the Breaking Changes doc in a section labeled explicitly for changes to stable APIs.
        - If upcoming changes are known ahead of time, they can be listed in a special section of the Breaking Changes doc for upcoming changes.
- For removing APIs, we may choose to formally deprecate by marking the type or with the [Obsolete] attribute.
    - Like with breaking changes, any deprecated APIs may be marked as <code>[Obsolete]</code> by Preview 2 of the release in which they’ll be removed.

## Stable APIs

With stable APIs, we want to replicate the stability expectations associated with VSSDK:
- Breaking changes to both VisualStudio.Extensibility APIs and RPC contracts can only be made as part of a major version release of Visual Studio.
    - A list of breaking changes must be available by Preview 1 of the release.
- Any removal of APIs or demotion will be done formally through marking the type or with the [Obsolete] attribute.
- Demotion of stable APIs to experimental is considered a breaking change and will be announced.


---
title: Markdown Linter Extension reference
description: A reference for Markdown Linter extension sample
date: 2022-8-4
---

# Walkthrough: Markdown Linter Extension

This extension shows how multiple components can interact together inside an extension and how different areas of Visual Studio can be extended.

## Summary

Markdown Linter extension showcases samples of:

* Creating a command handler
* Creating text view change and creation listeners
* Introducing local services that are shared across extension parts
* Interacting with output window and Error List.

## Prerequisites

This extension assumes `markdownlint-cli` npm package is installed globally in order to successfully run linter on markdown files.

You can run `npm install -g markdownlint-cli` to install the package before running the sample.

## MarkdownLinterExtension instance

Different to previous samples, this extension implements its own class that inherits from `ExtensionWithCommand` as our extension contains commands and also want to introduce local services.

There are 2 interesting points in the implementation of `MarkdownLinterExtension`:

* `ResourceManager` property points to the resource dictionary that contains localized entries that would be used for creating an output window pane.
* `InitializeServices` method is used to add local services to the dependency injection graph. As noted in [local services section](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/extension-anatomy#local-extension-services), the extension utilizes a scoped `MarkdownDiagnosticsService` as the service instance injects `VisualStudioExtensibility` object.

## MarkdownDiagnosticsService local service

In this example, this local service acts as the central for managing markdown file diagnostics. It is responsible for running markdown linter on the files requested and forward errors to diagnostic service.

For more information on individual APIs used please refer to:

* Views API for output window
* Languages API for diagnostics

## RunLinterOnCurrentFileCommand

One part of the extension is a command that can run markdown linter on the current selected file in Solution Explorer.

The command retrieves the selection from `IClientContext` instance and forwards the request to local `MarkdownDiagnosticsService` service instance.

```csharp
// Get the selected item URIs from IDE context that reprents the state when command was executed.
var selectedItemPaths = new Uri[] { await context.GetSelectedPathAsync(cancellationToken) };

// Enumerate through each selection and run linter on each selected item.
foreach (var selectedItem in selectedItemPaths.Where(p => p.IsFile))
{
    await this.diagnosticsProvider.ProcessFileAsync(selectedItem, cancellationToken);
}
```

## TextViewEventListener

Another part of the extension is an editor component that listens for new editor view creation and changes to open views. This component monitors for events on `.md` files and routes the request to `MarkdownDiagnosticsService` as contents change.

The extension part also utilizes the `AppliesTo` configuration to indicate that it is interested in events from views with `markdown` content type. (The definition of `MarkdownLinterExtensionContributions.MarkdownDocumentType` as a custom content type is required as there is no `markdown` content type in Visual Studio)

```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
    {
        DocumentFilter.FromDocumentType(MarkdownLinterExtensionContributions.MarkdownDocumentType),
    },
};
```

Even though this class implements 2 different contracts, a single instance of it will be created so that state can be shared between different editor components that interact together.
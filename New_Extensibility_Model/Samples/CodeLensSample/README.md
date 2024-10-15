---
title: Code Lens Sample Reference
description: A reference for Code Lens Sample
date: 2023-10-14
---

# Walkthrough: Code Lens Sample

This extension is a sample extension which contributes two Code Lens providers - one that provides clickable Code Lens displaying number of times user clicked on it and another that provides Code Lens displaying the number of words in a method and custom UI displayed when user clicks on the Code Lens. It is a good starting point for learning how to create a Code Lens provider.

## ClickCountCodeLensProvider and ClickableCodeLens

`ClickCountCodeLensProvider` is a part of the extension that provides an invokable Code Lens that allows execution by user clicking on it and indicating number of times it was executed.

`ClickCountCodeLensProvider` utilizes the `AppliesTo` configuration to indicate that it is interested in events from text views whose documents are of `DocumentType.KnownValues.Code`, which are all text based documents containing code.

```csharp
/// <inheritdoc />
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
    {
        DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code),
    },
};
```

`ClickCountCodeLensProvider` utilizes the `CodeLensProviderConfiguration` to declare its display name and that the Code Lens it provides should be placed after other existing Code Lenses with a priority of 500.

```csharp
 public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
    new("Invokable CodeLens Sample Provider")
    {
        Priority = 500,
    };
```

When requested, `ClickCountCodeLensProvider` provides a `ClickableCodeLens` instance:

```csharp
public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
{
    if (codeElement.Kind == CodeElementKind.KnownValues.Method)
    {
        return Task.FromResult<CodeLens?>(new ClickableCodeLens(codeElement, this.Extensibility));
    }

    return Task.FromResult<CodeLens?>(null);
}
```

`ClickableCodeLens` provides `CodeLensLabel` that is being displayed above methods and implements `InvokableCodeLens` abstract class to increment click count on each invocation.
```csharp
public override Task ExecuteAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken cancelToken)
{
    this.clickCount++;
    this.Invalidate();
    return Task.CompletedTask;
}

public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
{
    return Task.FromResult(new CodeLensLabel()
    {
        Text = this.clickCount == 0 ? "Click me" : $"Clicked {this.clickCount} times",
        Tooltip = "Invokable CodeLens Sample Tooltip",
    });
}
```

## WordCountCodeLensProvider and WordCountCodeLens

`WordCountCodeLensProvider` is a part of the extension that provides a visual Code Lens indicating number of words in a method body and that listens for new editor text view creation and changes to open text views to update the word count.

`WordCountCodeLensProvider` utilizes the `AppliesTo` configuration to indicate that it is interested in events from text views whose documents are of `DocumentType.KnownValues.Code`, which are all text based documents containing code.

```csharp
/// <inheritdoc />
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
    {
        DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code),
    },
};
```

`WordCountCodeLensProvider` utilizes the `CodeLensProviderConfiguration` to declare its display name and that the Code Lens it provides should be placed after other existing Code Lenses with a priority of 500.

```csharp
 public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
    new("Invokable CodeLens Sample Provider")
    {
        Priority = 500,
    };
```

When requested, `WordCountCodeLensProvider` provides `WordCountCodeLens` instance:

```csharp
public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
{
    if (codeElement.Kind == CodeElementKind.KnownValues.Method || codeElement.Kind.IsOfKind(CodeElementKind.KnownValues.Type))
    {
        return Task.FromResult<CodeLens?>(new WordCountCodeLens(codeElement, codeElementContext, this.Extensibility, this));
    }

    return Task.FromResult<CodeLens?>(null);
}
```

`WordCountCodeLens` provides `CodeLensLabel` that is being displayed above methods and implements `VisualCodeLens` to provide custom UI displayed when user clicks on the Code Lens.

```csharp
public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
{
    this.wordCountData.WordCount = CountWords(codeElementContext.Range);
    return Task.FromResult(new CodeLensLabel()
    {
        Text = $"Words: {this.wordCountData.WordCount}",
        Tooltip = "Number of words in this code element",
    });
}

public override Task<IRemoteUserControl> GetVisualizationAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken token)
{
    return Task.FromResult<IRemoteUserControl>(new WordCountCodeLensVisual(this.wordCountData));
}
```

## Usage

Once deployed, the Code Lens Sample will add two Code Lenses displayed above each method, one that can be clicked and displays the number of times it was clicked and another that displays the number of words in the method and provides custom UI displayed when user clicks on the Code Lens.

## See also

- [Use Editor extensibility](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/editor/editor)
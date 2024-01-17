---
title: Word Count Margin Sample reference
description: A reference for Word Count Margin Sample
date: 2023-02-10
---

# Walkthrough: Word Count Margin Sample

This extension is a simple extension which adds a margin to the Visual Studio editor status bar, to the left of the built-in line number margin, indicating number of words in the current text document.

## TextViewMarginProvider

`TextViewMarginProvider` is a part of the extension that provides a text view margin indicating number of words to any text view and that listens for new editor text view creation and changes to open text views to update the word count.

`UnitTestRunner` utilizes the `AppliesTo` configuration to indicate that it is interested in events from text views whose documents are of `DocumentType.KnownValues.Text`, which are all text based documents.

```csharp
/// <inheritdoc />
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo =
    [
        DocumentFilter.FromDocumentType(DocumentType.KnownValues.Text),
    ],
};
```

`UnitTestRunner` utilizes the `TextViewMarginProviderConfiguration` to declare that the text view margin it provides should be placed into `ContainerMarginPlacement.KnownValues.BottomRightCorner` container and positioned before (to the left of) built-in Visual Studio `MarginPlacement.KnownValues.RowMargin`.

```csharp
/// <summary>
/// Configures the margin to be placed to the left of built-in Visual Studio line number margin.
/// </summary>
public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration =>
    new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
    {
        Before = [MarginPlacement.KnownValues.RowMargin],
    };
```

## Usage

Once deployed, the Word Count Margin Sample will add a margin on the Visual Studio editor status bar, to the left of built-in line number margin indicating current number of words in the text document.

## See also

- [Use Editor extensibility](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/editor/editor)
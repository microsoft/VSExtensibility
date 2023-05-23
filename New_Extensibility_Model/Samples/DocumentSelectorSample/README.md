---
title: Document Selector Sample reference
description: A reference for Document Selector Sample
date: 2023-02-10
---

# Walkthrough: Document Selector Sample

This extension is a simple extension that shows how to define applicability of an extension part using document selector pattern.
The extension emulates running unit tests on background when user opens any C# file under "tests" folder anywhere in solution.

## UnitTestRunner

`UnitTestRunner` is a part of the extension that listens for new editor text view creation and changes to open text views. This component monitors for events in C# files under "tests" folder anywhere in solution and when open or modified, it emulates running unit tests in these files by writing a message to the Output Window.

`UnitTestRunner` utilizes the `AppliesTo` configuration to indicate that it is interested in events from text views whose documents have .cs extension and are under "tests" folder anywhere in solution by using `**/tests/*.cs` glob pattern

```csharp
/// <inheritdoc />
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
        {
            DocumentFilter.FromGlobPattern("**/tests/*.cs", relativePath: false),
        },
};
```

Even though this class implements 2 different contracts, a single instance of it will be created so that state can be shared between different editor components that interact together.


## Usage

Once deployed, the Document Selector Sample will write `Running unit tests in File.cs` to the Output Window every time you open or modify C# file under "tests" folder anywhere in solution.

## See also

- [Create documents](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/document/documents)

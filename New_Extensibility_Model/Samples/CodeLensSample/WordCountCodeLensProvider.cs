// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// A sample CodeLens provider that shows the number of words in a method or type and provides custom UI when clicked.
/// </summary>
#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.
[VisualStudioContribution]
internal class WordCountCodeLensProvider : ExtensionPart, ICodeLensProvider, ITextViewChangedListener
{
    public event EventHandler<TextViewChangedArgs>? TextViewChanged;

    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code)],
    };

#pragma warning disable CEE0027 // String not localized
    public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
        new("Remote UI CodeLens Sample Provider")
        {
            Priority = 600,
        };
#pragma warning restore CEE0027 // String not localized

    public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
    {
        if (codeElement.Kind == CodeElementKind.KnownValues.Method)
        {
            return Task.FromResult<CodeLens?>(new WordCountCodeLens(codeElement, codeElementContext, this.Extensibility, this));
        }

        return Task.FromResult<CodeLens?>(null);
    }

    public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        this.TextViewChanged?.Invoke(this, args);
        return Task.CompletedTask;
    }
}
#pragma warning restore VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.

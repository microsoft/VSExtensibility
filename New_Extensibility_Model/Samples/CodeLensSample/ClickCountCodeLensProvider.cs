// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// A sample CodeLens provider that provides invokable CodeLens and shows the number of times it has been clicked.
/// </summary>
#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.
[VisualStudioContribution]
internal class ClickCountCodeLensProvider : ExtensionPart, ICodeLensProvider
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = new[]
        {
            DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code),
        },
    };

#pragma warning disable CEE0027 // String not localized
    public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
        new("Invokable CodeLens Sample Provider")
        {
            Priority = 500,
        };
#pragma warning restore CEE0027 // String not localized

    public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
    {
        if (codeElement.Kind == CodeElementKind.KnownValues.Method)
        {
            return Task.FromResult<CodeLens?>(new ClickableCodeLens(codeElement, this.Extensibility));
        }

        return Task.FromResult<CodeLens?>(null);
    }
}
#pragma warning restore VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.

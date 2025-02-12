// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace TaggersSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.

/// <summary>
/// A sample CodeLens provider that shows the identifier of markdown section titles.
/// </summary>
[VisualStudioContribution]
internal class MarkdownCodeLensProvider : ExtensionPart, ICodeLensProvider
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };

    public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
        new("%TaggersSample.MarkdownCodeLensProvider%");

    public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
    {
        if (codeElement.Kind == MarkdownCodeLensTagger.SectionCodeElementKind)
        {
            return Task.FromResult<CodeLens?>(new MarkdownCodeLens(codeElement));
        }

        return Task.FromResult<CodeLens?>(null);
    }
}

﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

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
        AppliesTo = [DocumentFilter.FromDocumentType(TaggerTest.MyMarkdownDocumentType)],
    };

#pragma warning disable CEE0027 // String not localized
    public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
        new("Remote UI CodeLens Sample Provider");
#pragma warning restore CEE0027 // String not localized

    public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
    {
        if (codeElement.Kind == MarkdownCodeLensTagger.SectionCodeElementKind)
        {
            return Task.FromResult<CodeLens?>(new MarkdownCodeLens(codeElement));
        }

        return Task.FromResult<CodeLens?>(null);
    }
}

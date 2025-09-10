// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

[VisualStudioContribution]
internal class MarkdownCodeLensTaggerProvider : TextViewTaggerProvider<CodeLensTag, MarkdownCodeLensTagger>
{
    public override TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(TaggerTest.MyMarkdownDocumentType)],
    };
}

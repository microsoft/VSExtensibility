// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ClassificationSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

[VisualStudioContribution]
internal class CsvTaggerProvider : TextViewTaggerProvider<ClassificationTag, CsvTagger>
{
    [VisualStudioContribution]
    public static DocumentTypeConfiguration CsvDocumentType => new("csv")
    {
        FileExtensions = new[] { ".csv" },
        BaseDocumentType = DocumentType.KnownValues.PlainText,
    };

    public override TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(CsvDocumentType)],
    };
}

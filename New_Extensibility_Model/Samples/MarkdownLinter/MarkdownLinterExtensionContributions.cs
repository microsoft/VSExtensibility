// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// Extension entry point for Markdown Linter sample extension showcasing new
/// out of proc Visual Studio Extensibilty APIs.
/// </summary>
internal static class MarkdownLinterExtensionContributions
{
    [VisualStudioContribution]
    internal static DocumentTypeConfiguration MarkdownDocumentType => new("markdown")
    {
        FileExtensions = new[] { ".md", ".mdk", ".markdown" },
        BaseDocumentType = DocumentType.KnownValues.Text,
    };
}

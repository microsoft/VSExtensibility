// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// Listener for text view lifetime events to start linter on new documents or changed documents.
/// </summary>
[VisualStudioContribution]
internal class TextViewEventListener : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
#pragma warning disable CA2213 // This is an extension scoped service.
    private readonly MarkdownDiagnosticsService diagnosticsProvider;
#pragma warning restore CA2213

    /// <summary>
    /// Initializes a new instance of the <see cref="TextViewEventListener"/> class.
    /// </summary>
    /// <param name="extension">Extension instance.</param>
    /// <param name="extensibility">Extensibility object.</param>
    /// <param name="diagnosticsProvider">Local diagnostics provider service instance.</param>
    public TextViewEventListener(MarkdownLinterExtension extension, VisualStudioExtensibility extensibility, MarkdownDiagnosticsService diagnosticsProvider)
        : base(extension, extensibility)
    {
        this.diagnosticsProvider = Requires.NotNull(diagnosticsProvider, nameof(diagnosticsProvider));
    }

    /// <inheritdoc/>
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = new[]
        {
            DocumentFilter.FromGlobPattern("**/*.md", true),
        },
    };

    /// <inheritdoc />
    public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        return this.diagnosticsProvider.ProcessTextViewAsync(args.AfterTextView, cancellationToken);
    }

    /// <inheritdoc />
    public async Task TextViewClosedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        await this.diagnosticsProvider.ClearEntriesForDocumentAsync(textViewSnapshot.Document.Uri, cancellationToken);
    }

    /// <inheritdoc />
    public Task TextViewOpenedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        return this.diagnosticsProvider.ProcessTextViewAsync(textViewSnapshot, cancellationToken);
    }
}

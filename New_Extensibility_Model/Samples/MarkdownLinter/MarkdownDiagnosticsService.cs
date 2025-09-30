// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Documents;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Helpers;
using Microsoft.VisualStudio.Threading;

/// <summary>
/// An internal service shared across extension components via dependency injection. The service provides
/// a central mechanism to manage markdown diagnostics for documents and can be called from various parts such as
/// commands or editor listeners.
/// </summary>
/// <remarks>For a sample ingestion of this service, see <see cref="TextViewEventListener"/> constructor.</remarks>
internal class MarkdownDiagnosticsService : DisposableObject
{
#pragma warning disable CA2213 // Disposable fields should be disposed, object now owned by this instance.
    private readonly VisualStudioExtensibility extensibility;
#pragma warning restore CA2213 // Disposable fields should be disposed
    private readonly Dictionary<Uri, CancellationTokenSource> documentCancellationTokens;
    private readonly Task initializationTask;
    private readonly LinterUtilities linterUtilities;
    private OutputChannel? outputChannel;
    private DiagnosticsReporter? diagnosticsReporter;

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownDiagnosticsService"/> class.
    /// </summary>
    /// <param name="extensibility">Extensibility object.</param>
    /// <param name="linterUtilities">Service for running the linter on markdown files.</param>
    public MarkdownDiagnosticsService(VisualStudioExtensibility extensibility, LinterUtilities linterUtilities)
    {
        this.extensibility = Requires.NotNull(extensibility, nameof(extensibility));
        this.documentCancellationTokens = new Dictionary<Uri, CancellationTokenSource>();
        this.linterUtilities = Requires.NotNull(linterUtilities, nameof(linterUtilities));
        this.initializationTask = Task.Run(this.InitializeAsync);
    }

    /// <summary>
    /// Processes the specified file for markdown errors and reports to the error list.
    /// </summary>
    /// <param name="documentUri">Document uri to read the contents from.</param>
    /// <param name="cancellationToken">Cancellation token to monitor.</param>
    /// <returns>Task indicating completion of reporting markdown errors to error list.</returns>
    public async Task ProcessFileAsync(Uri documentUri, CancellationToken cancellationToken)
    {
        CancellationTokenSource newCts = new CancellationTokenSource();
        lock (this.documentCancellationTokens)
        {
            if (this.documentCancellationTokens.TryGetValue(documentUri, out var cts))
            {
                _ = cts.CancelAsync();
            }

            this.documentCancellationTokens[documentUri] = newCts;
        }

        // Wait for 1 second to see if any other changes are being sent.
        await Task.Delay(1000, cancellationToken);

        if (newCts.IsCancellationRequested)
        {
            return;
        }

        try
        {
            var diagnostics = await this.linterUtilities.RunLinterOnFileAsync(documentUri, cancellationToken);

            await this.diagnosticsReporter!.ClearDiagnosticsAsync(documentUri, cancellationToken);
            await this.diagnosticsReporter!.ReportDiagnosticsAsync(diagnostics, cancellationToken);
        }
        catch (InvalidOperationException)
        {
            if (this.outputChannel is not null)
            {
                await this.outputChannel.WriteLineAsync(Strings.MissingLinterError);
            }
        }
    }

    /// <summary>
    /// Processes the current version <see cref="ITextViewSnapshot"/> instance for markdown errors and reports to the error list.
    /// </summary>
    /// <param name="textViewSnapshot">Text View instance to read the contents from.</param>
    /// <param name="cancellationToken">Cancellation token to monitor.</param>
    /// <returns>Task indicating completion of reporting markdown errors to error list.</returns>
    public async Task ProcessTextViewAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        CancellationTokenSource newCts = new CancellationTokenSource();
        lock (this.documentCancellationTokens)
        {
            if (this.documentCancellationTokens.TryGetValue(textViewSnapshot.Document.Uri, out var cts))
            {
                _ = cts.CancelAsync();
            }

            this.documentCancellationTokens[textViewSnapshot.Document.Uri] = newCts;
        }

        await this.ProcessDocumentAsync(textViewSnapshot.Document, cancellationToken.CombineWith(newCts.Token).Token);
    }

    /// <summary>
    /// Clears any of the existing entries for the specified document uri.
    /// </summary>
    /// <param name="documentUri">Document uri to clear markdown error entries for.</param>
    /// <param name="cancellationToken">Cancellation token to monitor.</param>
    /// <returns>Task indicating completion.</returns>
    public async Task ClearEntriesForDocumentAsync(Uri documentUri, CancellationToken cancellationToken)
    {
        lock (this.documentCancellationTokens)
        {
            if (this.documentCancellationTokens.TryGetValue(documentUri, out var cts))
            {
                _ = cts.CancelAsync();
                this.documentCancellationTokens.Remove(documentUri);
            }
        }

        await this.diagnosticsReporter!.ClearDiagnosticsAsync(documentUri, cancellationToken);
    }

    /// <inheritdoc />
    protected override void Dispose(bool isDisposing)
    {
        base.Dispose(isDisposing);

        if (isDisposing)
        {
            this.outputChannel?.Dispose();
            this.diagnosticsReporter?.Dispose();
        }
    }

    private async Task ProcessDocumentAsync(ITextDocumentSnapshot documentSnapshot, CancellationToken cancellationToken)
    {
        // Wait for 1 second to see if any other changes are being sent.
        await Task.Delay(1000, cancellationToken);

        if (cancellationToken.IsCancellationRequested)
        {
            return;
        }

        try
        {
            var diagnostics = await this.linterUtilities.RunLinterOnDocumentAsync(documentSnapshot, cancellationToken);

            await this.diagnosticsReporter!.ClearDiagnosticsAsync(documentSnapshot, cancellationToken);
            await this.diagnosticsReporter!.ReportDiagnosticsAsync(diagnostics, cancellationToken);
        }
        catch (InvalidOperationException)
        {
            if (this.outputChannel is not null)
            {
                await this.outputChannel.WriteLineAsync(Strings.MissingLinterError);
            }
        }
    }

    private async Task InitializeAsync()
    {
        this.outputChannel = await this.extensibility.Views().Output.CreateOutputChannelAsync(Strings.MarkdownLinterWindowName, default);
        this.diagnosticsReporter = this.extensibility.Languages().GetDiagnosticsReporter(nameof(MarkdownLinterExtension));
        Assumes.NotNull(this.diagnosticsReporter);
    }
}

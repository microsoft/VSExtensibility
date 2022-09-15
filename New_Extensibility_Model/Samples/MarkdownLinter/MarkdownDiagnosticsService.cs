// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Extensions.MarkdownLinter;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Documents;
using Microsoft.VisualStudio.Extensibility.Editor.Data;
using Microsoft.VisualStudio.Extensibility.Editor.UI;
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

	private OutputWindow? outputWindow;
	private DiagnosticsReporter? diagnosticsReporter;
	private Dictionary<Uri, CancellationTokenSource> documentCancellationTokens;
	private Task initializationTask;

	/// <summary>
	/// Initializes a new instance of the <see cref="MarkdownDiagnosticsService"/> class.
	/// </summary>
	/// <param name="extensibility">Extensibility object.</param>
	public MarkdownDiagnosticsService(VisualStudioExtensibility extensibility)
	{
		this.extensibility = Requires.NotNull(extensibility, nameof(extensibility));
		this.documentCancellationTokens = new Dictionary<Uri, CancellationTokenSource>();
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
				cts.Cancel();
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
			var diagnostics = await LinterUtilities.RunLinterOnFileAsync(documentUri);

			await this.diagnosticsReporter!.ClearDiagnosticsAsync(documentUri, cancellationToken);
			await this.diagnosticsReporter!.ReportDiagnosticsAsync(diagnostics, cancellationToken);
		}
		catch (InvalidOperationException)
		{
			if (this.outputWindow is object)
			{
				await this.outputWindow.Writer.WriteLineAsync(Strings.MissingLinterError);
			}
		}
	}

	/// <summary>
	/// Processes the current version <see cref="ITextView"/> instance for markdown errors and reports to the error list.
	/// </summary>
	/// <param name="textViewSnapshot">Text View instance to read the contents from.</param>
	/// <param name="cancellationToken">Cancellation token to monitor.</param>
	/// <returns>Task indicating completion of reporting markdown errors to error list.</returns>
	public async Task ProcessTextViewAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		var document = await textViewSnapshot.GetTextDocumentAsync(cancellationToken);
		if (document is null)
		{
			return;
		}

		CancellationTokenSource newCts = new CancellationTokenSource();
		lock (this.documentCancellationTokens)
		{
			if (this.documentCancellationTokens.TryGetValue(document.Uri, out var cts))
			{
				cts.Cancel();
			}

			this.documentCancellationTokens[document.Uri] = newCts;
		}

		await this.ProcessDocumentAsync(document, cancellationToken.CombineWith(newCts.Token).Token);
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
				cts.Cancel();
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
			this.outputWindow?.Dispose();
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
			var diagnostics = await LinterUtilities.RunLinterOnDocumentAsync(documentSnapshot);

			await this.diagnosticsReporter!.ClearDiagnosticsAsync(documentSnapshot, cancellationToken);
			await this.diagnosticsReporter!.ReportDiagnosticsAsync(diagnostics, cancellationToken);
		}
		catch (InvalidOperationException)
		{
			if (this.outputWindow is object)
			{
				await this.outputWindow.Writer.WriteLineAsync(Strings.MissingLinterError);
			}
		}
	}

	private async Task InitializeAsync()
	{
		this.outputWindow = await this.extensibility.Views().Output.GetChannelAsync(nameof(MarkdownLinterExtension) + Guid.NewGuid(), nameof(Strings.MarkdownLinterWindowName), default);
		Assumes.NotNull(this.outputWindow);

		this.diagnosticsReporter = this.extensibility.Languages().GetDiagnosticsReporter(nameof(MarkdownLinterExtension));
		Assumes.NotNull(this.diagnosticsReporter);
	}
}

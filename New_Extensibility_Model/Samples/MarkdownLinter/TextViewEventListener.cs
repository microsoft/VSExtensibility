// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Extensions.MarkdownLinter
{
	using System.Threading;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Editor;
	using Microsoft.VisualStudio.Extensibility.Editor.UI;
	using Task = System.Threading.Tasks.Task;

	/// <summary>
	/// Listener for text view lifetime events to start linter on new documents or changed documents.
	/// </summary>
	[ExtensionPart(typeof(ITextViewLifetimeListener))]
	[ExtensionPart(typeof(ITextViewChangedListener))]
	[AppliesTo(ContentType = "text")]
	internal class TextViewEventListener : ExtensionPart, ITextViewLifetimeListener, ITextViewChangedListener
	{
		private readonly MarkdownDiagnosticsService diagnosticsProvider;

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

		/// <inheritdoc />
		public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
		{
			return this.diagnosticsProvider.ProcessTextViewAsync(args.AfterTextView, cancellationToken);
		}

		/// <inheritdoc />
		public async Task TextViewClosedAsync(ITextView textView, CancellationToken cancellationToken)
		{
			var document = await textView.GetTextDocumentAsync(cancellationToken);
			if (document is null || !LinterUtilities.IsValidMarkdownFile(document.Uri.LocalPath))
			{
				return;
			}

			await this.diagnosticsProvider.ClearEntriesForDocumentAsync(document.Uri, cancellationToken);
		}

		/// <inheritdoc />
		public Task TextViewCreatedAsync(ITextView textView, CancellationToken cancellationToken)
		{
			return this.diagnosticsProvider.ProcessTextViewAsync(textView, cancellationToken);
		}
	}
}

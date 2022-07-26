// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

namespace Microsoft.VisualStudio.Gladstone.DocumentSelectorSample
{
	using System.Threading;
	using System.Threading.Tasks;

	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Documents;
	using Microsoft.VisualStudio.Extensibility.Editor;
	using Microsoft.VisualStudio.Extensibility.Editor.UI;

	/// <summary>
	/// A sample demonstrating how to define an editor extension that is only applicable to files matching a file path pattern.
	/// This text view event listener monitors users opening/modifying/closing C# files in "tests" folder and emulates running
	/// unit tests in these files.
	/// </summary>
	[ExtensionPart(typeof(ITextViewLifetimeListener))]
	[ExtensionPart(typeof(ITextViewChangedListener))]
	[AppliesToPattern(Pattern = "**/tests/*.cs")]
	internal class DocumentSelectorSample : ExtensionPart, ITextViewLifetimeListener, ITextViewChangedListener
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentSelectorSample"/> class.
		/// </summary>
		/// <param name="extension">Extension instance.</param>
		/// <param name="extensibility">Extensibility object.</param>
		public DocumentSelectorSample(Extension extension, VisualStudioExtensibility extensibility)
			: base(extension, extensibility)
		{
		}

		/// <inheritdoc />
		public Task TextViewCreatedAsync(ITextView textView, CancellationToken cancellationToken)
		{
			return this.RunUnitTestsAfterDelayAsync(textView, cancellationToken);
		}

		/// <inheritdoc />
		public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
		{
			return this.RunUnitTestsAfterDelayAsync(args.AfterTextView, cancellationToken);
		}

		/// <inheritdoc />
		public async Task TextViewClosedAsync(ITextView textView, CancellationToken cancellationToken)
		{
			await this.StopUnitTestsAsync(textView, cancellationToken);
		}

		private async Task RunUnitTestsAfterDelayAsync(ITextView textView, CancellationToken cancellationToken)
		{
			await Task.Delay(500);
			var document = await textView.GetTextDocumentAsync(cancellationToken);
			await this.WriteToOutputWindowAsync($"Running unit tests in {document.Uri.LocalPath}", cancellationToken);
		}

		private async Task StopUnitTestsAsync(ITextView textView, CancellationToken cancellationToken)
		{
			var document = await textView.GetTextDocumentAsync(cancellationToken);
			await this.WriteToOutputWindowAsync($"Stop running unit tests in {document.Uri.LocalPath}", cancellationToken);
		}

		private async Task WriteToOutputWindowAsync(string message, CancellationToken cancellationToken)
		{
			var channel = await this.Extensibility.Views().Output.GetChannelAsync(nameof(DocumentSelectorSample),
				nameof(Resources.OutputWindowPaneName), cancellationToken);
			Assumes.NotNull(channel);
			await channel.Writer.WriteLineAsync(message);
		}
	}
}

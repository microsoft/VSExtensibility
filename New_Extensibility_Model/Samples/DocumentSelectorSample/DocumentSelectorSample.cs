// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Gladstone.DocumentSelectorSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
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
	public Task TextViewCreatedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		return this.RunUnitTestsAfterDelayAsync(textViewSnapshot, cancellationToken);
	}

	/// <inheritdoc />
	public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
	{
		return this.RunUnitTestsAfterDelayAsync(args.AfterTextView, cancellationToken);
	}

	/// <inheritdoc />
	public async Task TextViewClosedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		await this.StopUnitTestsAsync(textViewSnapshot, cancellationToken);
	}

	private async Task RunUnitTestsAfterDelayAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		await Task.Delay(500);
		var document = await textViewSnapshot.GetTextDocumentAsync(cancellationToken);
		await this.WriteToOutputWindowAsync($"Running unit tests in {document.Uri.LocalPath}", cancellationToken);
	}

	private async Task StopUnitTestsAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		var document = await textViewSnapshot.GetTextDocumentAsync(cancellationToken);
		await this.WriteToOutputWindowAsync($"Stop running unit tests in {document.Uri.LocalPath}", cancellationToken);
	}

	private async Task WriteToOutputWindowAsync(string message, CancellationToken cancellationToken)
	{
		var channel = await this.Extensibility.Views().Output.GetChannelAsync(
			identifier: nameof(DocumentSelectorSample),
			displayNameResourceId: nameof(Resources.OutputWindowPaneName),
			cancellationToken);
		Assumes.NotNull(channel);
		await channel.Writer.WriteLineAsync(message);
	}
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentSelectorSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Documents;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// A sample demonstrating how to define an editor extension that is only applicable to files matching a file path pattern.
/// This text view event listener monitors users opening/modifying/closing C# files in "tests" folder and emulates running
/// unit tests in these files.
/// </summary>
[VisualStudioContribution]
internal class UnitTestRunner : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
	private OutputWindow? outputWindow;

	/// <summary>
	/// Initializes a new instance of the <see cref="UnitTestRunner"/> class.
	/// </summary>
	/// <param name="extension">Extension instance.</param>
	/// <param name="extensibility">Extensibility object.</param>
	public UnitTestRunner(Extension extension, VisualStudioExtensibility extensibility)
		: base(extension, extensibility)
	{
	}

	/// <inheritdoc />
	public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
	{
		AppliesTo = new[]
			{
				DocumentFilter.FromGlobPattern("**/tests/*.cs", relativePath: false),
			},
	};

	/// <inheritdoc />
	public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
	{
		return this.RunUnitTestsAfterDelayAsync(args.AfterTextView, cancellationToken);
	}

	/// <inheritdoc />
	public Task TextViewOpenedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		return this.RunUnitTestsAfterDelayAsync(textViewSnapshot, cancellationToken);
	}

	/// <inheritdoc />
	public Task TextViewClosedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		return this.StopUnitTestsAsync(textViewSnapshot, cancellationToken);
	}

	/// <inheritdoc />
	protected override void Dispose(bool isDisposing)
	{
		base.Dispose(isDisposing);
		this.outputWindow?.Dispose();
	}

	private async Task RunUnitTestsAfterDelayAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		await Task.Delay(500, cancellationToken);
		var document = await textViewSnapshot.GetTextDocumentAsync(cancellationToken);
		await this.WriteToOutputWindowAsync($"Running unit tests in {document.Uri.LocalPath}", cancellationToken);
	}

	private async Task StopUnitTestsAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
	{
		var document = await textViewSnapshot.GetTextDocumentAsync(cancellationToken);
		await this.WriteToOutputWindowAsync($"Stop running unit tests in {document.Uri.LocalPath}", cancellationToken);
	}

	private async Task<OutputWindow> GetOutputWindowAsync(CancellationToken cancellationToken)
	{
		return this.outputWindow ??= await this.Extensibility.Views().Output.GetChannelAsync(
			identifier: nameof(DocumentSelectorSample),
			displayNameResourceId: nameof(Resources.OutputWindowPaneName),
			cancellationToken);
	}

	private async Task WriteToOutputWindowAsync(string message, CancellationToken cancellationToken)
	{
		var channel = await this.GetOutputWindowAsync(cancellationToken);
		Assumes.NotNull(channel);
		await channel.Writer.WriteLineAsync(message);
	}
}

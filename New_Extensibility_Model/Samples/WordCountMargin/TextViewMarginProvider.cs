// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WordCountMarginSample;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

/// <summary>
/// A sample text view margin provider, which adds a margin to the Visual Studio editor status bar, to the left
/// of the built-in line number margin, indicating number of words in the current text document.
/// </summary>
[VisualStudioContribution]
internal class TextViewMarginProvider : ExtensionPart, ITextViewMarginProvider, ITextViewOpenClosedListener, ITextViewChangedListener
{
	private readonly Dictionary<Uri, WordCountData> dataModels = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="TextViewMarginProvider"/> class.
	/// </summary>
	/// <param name="extension">Extension instance.</param>
	/// <param name="extensibility">Extensibility object.</param>
	public TextViewMarginProvider(Extension extension, VisualStudioExtensibility extensibility)
		: base(extension, extensibility)
	{
	}

	/// <summary>
	/// Configures this extension part to be applied to any text view.
	/// </summary>
	public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
	{
		AppliesTo = new[]
		{
			DocumentFilter.FromDocumentType(DocumentType.KnownValues.Text),
		},
	};

	/// <summary>
	/// Configures the margin to be placed to the left of built-in Visual Studio line number margin.
	/// </summary>
	public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration =>
		new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
	{
		Before = new[] { MarginPlacement.KnownValues.RowMargin },
	};

	/// <summary>
	/// Creates a remotable visual element representing the content of the margin.
	/// </summary>
	public async Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
	{
		var documentSnapshot = await textView.GetTextDocumentAsync(cancellationToken).ConfigureAwait(false);
		var dataModel = new WordCountData();
		dataModel.WordCount = CountWords(documentSnapshot);
		this.dataModels[textView.Uri] = dataModel;
		return new MyMarginContent(dataModel);
	}

	/// <inheritdoc />
	public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
	{
		var documentSnapshot = await args.AfterTextView.GetTextDocumentAsync(cancellationToken);
		this.dataModels[args.AfterTextView.Uri].WordCount = CountWords(documentSnapshot);
	}

	/// <inheritdoc />
	public Task TextViewClosedAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
	{
		this.dataModels.Remove(textView.Uri);
		return Task.CompletedTask;
	}

	/// <inheritdoc />
	public Task TextViewOpenedAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	private static int CountWords(ITextDocumentSnapshot documentSnapshot)
	{
		int wordCount = 0;
		for (int i = 1; i < documentSnapshot.Length; i++)
		{
			if (char.IsWhiteSpace(documentSnapshot[i - 1]) && char.IsLetterOrDigit(documentSnapshot[i]))
			{
				wordCount++;
			}
		}

		return wordCount;
	}
}

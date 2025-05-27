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
    private readonly TextViewChangesAggregator textViewChangesAggregator;
    private readonly Dictionary<Uri, WordCountData> dataModels = new();

    public TextViewMarginProvider()
    {
        this.textViewChangesAggregator = new((beforeTextView, afterTextView, cancellationToken) =>
        {
            this.dataModels[afterTextView.Uri].WordCount = CountWords(afterTextView.Document);
            return Task.CompletedTask;
        });
    }

    /// <inheritdoc />
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(DocumentType.KnownValues.Text)],
    };

    /// <inheritdoc />
    public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration =>
        new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
    {
        Before = [MarginPlacement.KnownValues.RowMargin],
    };

    /// <inheritdoc />
    public Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var dataModel = new WordCountData();
        dataModel.WordCount = CountWords(textView.Document);
        this.dataModels[textView.Uri] = dataModel;
        return Task.FromResult<IRemoteUserControl>(new MyMarginContent(dataModel));
    }

    /// <inheritdoc />
    public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        return this.textViewChangesAggregator.TextViewChangedAsync(args, cancellationToken);
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

    protected override void Dispose(bool isDisposing)
    {
        if (isDisposing)
        {
            this.textViewChangesAggregator.Dispose();
        }
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

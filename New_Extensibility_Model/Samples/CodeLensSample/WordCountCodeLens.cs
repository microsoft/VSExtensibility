// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.
internal class WordCountCodeLens : VisualCodeLens
{
    private readonly WordCountData wordCountData;

    public WordCountCodeLens(CodeElement codeElement, CodeElementContext codeElementContext, VisualStudioExtensibility extensibility, WordCountCodeLensProvider wordCountCodeLensProvider)
    {
        this.wordCountData = new WordCountData(this);
        this.wordCountData.WordCount = this.CountWords(codeElementContext.Range);
        wordCountCodeLensProvider.TextViewChanged += this.OnTextViewChanged;
    }

    public override void Dispose()
    {
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        this.wordCountData.WordCount = this.CountWords(codeElementContext.Range);
        return Task.FromResult(new CodeLensLabel()
        {
            Text = $"Occurrences of \"{this.wordCountData.WordToMatch}\": {this.wordCountData.WordCount}",
            Tooltip = "Number of occurrences of a word in the text",
        });
    }

    public override Task<IRemoteUserControl> GetVisualizationAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken token)
    {
        return Task.FromResult<IRemoteUserControl>(new WordCountCodeLensVisual(this.wordCountData, this));
    }

    internal void UpdateWordCount()
    {
        this.Invalidate();
    }

    private int CountWords(TextRange range)
    {
        var rangeText = range.CopyToString();
        var wordToMatch = this.wordCountData.WordToMatch;

        // Use Regex to find all matches of wordToMatch in rangeText
        var matches = Regex.Matches(rangeText, $@"\b{Regex.Escape(wordToMatch)}\b", RegexOptions.IgnoreCase);
        return matches.Count;
    }

    private void OnTextViewChanged(object? sender, TextViewChangedArgs e)
    {
        this.Invalidate();
    }
}
#pragma warning restore VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.

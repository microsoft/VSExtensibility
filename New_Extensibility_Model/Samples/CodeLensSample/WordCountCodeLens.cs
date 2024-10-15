// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
internal class WordCountCodeLens : VisualCodeLens
{
    private WordCountData wordCountData = new();

    public WordCountCodeLens(CodeElement codeElement, CodeElementContext codeElementContext, VisualStudioExtensibility extensibility, WordCountCodeLensProvider wordCountCodeLensProvider)
    {
        this.wordCountData.WordCount = CountWords(codeElementContext.Range);
        wordCountCodeLensProvider.TextViewChanged += this.OnTextViewChanged;
    }

    public override void Dispose()
    {
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        this.wordCountData.WordCount = CountWords(codeElementContext.Range);
        return Task.FromResult(new CodeLensLabel()
        {
            Text = $"Words: {this.wordCountData.WordCount}",
            Tooltip = "Number of words in this code element",
        });
    }

    public override Task<IRemoteUserControl> GetVisualizationAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken token)
    {
        return Task.FromResult<IRemoteUserControl>(new WordCountCodeLensVisual(this.wordCountData));
    }

    private static int CountWords(TextRange range)
    {
        int wordCount = 0;
        for (int i = 1; i < range.Length; i++)
        {
            if (char.IsWhiteSpace(range[i - 1]) && char.IsLetterOrDigit(range[i]))
            {
                wordCount++;
            }
        }

        return wordCount;
    }

    private void OnTextViewChanged(object? sender, TextViewChangedArgs e)
    {
        this.Invalidate();
    }
}
#pragma warning restore VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

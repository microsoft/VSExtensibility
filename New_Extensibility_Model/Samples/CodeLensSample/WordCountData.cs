// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.UI;

[DataContract]
internal class WordCountData : NotifyPropertyChangedObject
{
    private readonly WordCountCodeLens wordCountCodeLens;
    private int wordCount;
    private string wordToMatch = "return";
    private string newWordToMatch = string.Empty;

    public WordCountData(WordCountCodeLens wordCountCodeLens)
    {
        this.CountWordsCommand = new AsyncCommand(this.CountWordsAsync);
        this.wordCountCodeLens = wordCountCodeLens;
    }

    [DataMember]
    public int WordCount
    {
        get => this.wordCount;
        set => this.SetProperty(ref this.wordCount, value);
    }

    [DataMember]
    public string WordToMatch
    {
        get => this.wordToMatch;
        set => this.SetProperty(ref this.wordToMatch, value);
    }

    [DataMember]
    public string NewWordToMatch
    {
        get => this.newWordToMatch;
        set => this.SetProperty(ref this.newWordToMatch, value);
    }

    [DataMember]
    public IAsyncCommand CountWordsCommand
    {
        get;
    }

    private Task CountWordsAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        this.WordToMatch = this.newWordToMatch;
        this.wordCountCodeLens.UpdateWordCount();
        return Task.CompletedTask;
    }
}

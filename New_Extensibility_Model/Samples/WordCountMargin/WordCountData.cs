// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WordCountMarginSample;

using System.Runtime.Serialization;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample data context object to use with the margin content.
/// </summary>
[DataContract]
public class WordCountData : NotifyPropertyChangedObject
{
    private int wordCount;

    /// <summary>
    /// Gets or sets the count of words in the text document.
    /// </summary>
    [DataMember]
    public int WordCount
    {
        get => this.wordCount;
        set => this.SetProperty(ref this.wordCount, value);
    }
}

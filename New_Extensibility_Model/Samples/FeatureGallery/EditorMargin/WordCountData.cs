// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FeatureGallery.EditorMargin;

using System.Runtime.Serialization;
using Microsoft.VisualStudio.Extensibility.UI;

[DataContract]
public class WordCountData : NotifyPropertyChangedObject
{
    private int wordCount;

    [DataMember]
    public int WordCount
    {
        get => this.wordCount;
        set => this.SetProperty(ref this.wordCount, value);
    }
}

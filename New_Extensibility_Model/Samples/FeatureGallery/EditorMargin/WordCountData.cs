// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.EditorMargin;
#else
namespace FeatureGallery.EditorMargin;
#endif

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

    [DataMember]
    public string Background
#if INPROC
        => "LightSkyBlue";
#else
        => "LightPink";
#endif
}

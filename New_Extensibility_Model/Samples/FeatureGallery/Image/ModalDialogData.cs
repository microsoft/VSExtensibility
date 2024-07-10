// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.Image;
#else
namespace FeatureGallery.Image;
#endif

using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.UI;

[DataContract]
internal class ModalDialogData
{
    [DataMember]
    public string StringImage { get; } = "DefaultText";

    [DataMember]
    public string StringImageFromCatalog { get; } = "KnownMonikers.ClearWindowContent";

    [DataMember]
    public ImageMoniker StringImageId { get; } = "ae27a6b0-e345-4288-96df-5eaf394ee369;1935";

    [DataMember]
    public ImageMoniker MonikerImage { get; } = ImageMoniker.Custom("KnownMonikers.ClearWindowContent");

    [DataMember]
    public ImageMoniker MonikerImageFromCatalog { get; } = ImageMoniker.KnownValues.Import;
}

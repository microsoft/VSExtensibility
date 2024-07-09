// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;

[DataContract]
internal class ImageTest : TestData
{
    public ImageTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [DataMember]
    public override string ButtonText => "Images";

    [DataMember]
    public override string Description => "This command opens a modal dialog showing 7 images in red borders.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
#pragma warning disable CA2000 // Dispose objects before losing scope. ModalDialogControl is passed to Visual Studio which will take care of disposing it
        await this.Extensibility.Shell().ShowDialogAsync(new Image.ModalDialogControl(), cancellationToken);
#pragma warning restore CA2000 // Dispose objects before losing scope
    }
}

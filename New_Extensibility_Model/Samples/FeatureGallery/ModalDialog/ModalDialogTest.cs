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
internal class ModalDialogTest : TestData
{
    public ModalDialogTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [DataMember]
    public override string ButtonText => "Modal dialog";

    [DataMember]
    public override string Description => "This command opens a modal dialog where random colors can be added or removed from a list. The `Add color` and `Remove` buttons have localized text.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
#pragma warning disable CA2000 // Dispose objects before losing scope. ModalDialogControl is passed to Visual Studio which will take care of disposing it
        await this.Extensibility.Shell().ShowDialogAsync(new ModalDialog.ModalDialogControl(), cancellationToken);
#pragma warning restore CA2000 // Dispose objects before losing scope
    }
}

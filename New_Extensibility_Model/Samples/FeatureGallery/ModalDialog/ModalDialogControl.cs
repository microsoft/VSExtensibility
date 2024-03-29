// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.ModalDialog;
#else
namespace FeatureGallery.ModalDialog;
#endif

using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as tool window UI content.
/// </summary>
internal class ModalDialogControl : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModalDialogControl" /> class.
    /// </summary>
    public ModalDialogControl()
        : base(new ModalDialogData())
    {
#if INPROC
        this.ResourceDictionaries.AddEmbeddedResource("InProcFeatureGallery.ModalDialog.XamlResources.xaml");
#else
        this.ResourceDictionaries.AddEmbeddedResource("FeatureGallery.ModalDialog.XamlResources.xaml");
#endif
    }
}

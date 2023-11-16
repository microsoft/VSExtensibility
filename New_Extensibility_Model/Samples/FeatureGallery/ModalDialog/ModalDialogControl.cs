// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FeatureGallery.ModalDialog;

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
    }
}

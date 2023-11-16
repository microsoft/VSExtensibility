// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FeatureGallery;

using System.Threading;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as tool window UI content.
/// </summary>
internal class MainToolWindowControl : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainToolWindowControl" /> class.
    /// </summary>
    /// <param name="dataContext">
    /// Data context of the remote control which can be referenced from xaml through data binding.
    /// </param>
    public MainToolWindowControl(object? dataContext)
        : base(dataContext)
    {
    }
}

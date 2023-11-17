// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.EditorMargin;
#else
namespace FeatureGallery.EditorMargin;
#endif

using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as the margin content.
/// </summary>
internal class WordCountControl : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WordCountControl" /> class.
    /// </summary>
    /// <param name="dataContext">
    /// Data context of the remote control which can be referenced from xaml through data binding.
    /// </param>
    public WordCountControl(object? dataContext)
        : base(dataContext)
    {
    }
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System.Threading;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as tool window UI content.
/// </summary>
internal class MyToolWindowControl : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MyToolWindowControl" /> class.
    /// </summary>
    /// <param name="dataContext">
    /// Data context of the remote control which can be referenced from xaml through data binding.
    /// </param>
    public MyToolWindowControl(object? dataContext)
        : base(dataContext)
    {
    }
}

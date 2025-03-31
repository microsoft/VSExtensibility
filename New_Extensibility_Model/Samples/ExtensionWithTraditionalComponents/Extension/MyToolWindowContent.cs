// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionWithTraditionalComponents;

using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A remote user control to use as tool window UI content.
/// </summary>
internal class MyToolWindowContent : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MyToolWindowContent" /> class.
    /// </summary>
    public MyToolWindowContent()
        : base(dataContext: new MyToolWindowData())
    {
    }
}

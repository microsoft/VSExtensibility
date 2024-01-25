// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionPublisher;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.UI;

internal class MyToolWindowContent : RemoteUserControl
{
    public MyToolWindowContent(DataBinding dataBinding)
    : base(dataBinding)
    {
    }
}

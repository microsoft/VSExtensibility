// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynIntegrationExtension;

using Microsoft.VisualStudio.Extensibility.UI;
using RoslynMessageHandler;

internal class AssemblyInfoPopup : RemoteUserControl
{
    public AssemblyInfoPopup(FindAssemblyResponse response)
        : base(dataContext: new AssemblyInfoPopupData(response))
    {
    }
}

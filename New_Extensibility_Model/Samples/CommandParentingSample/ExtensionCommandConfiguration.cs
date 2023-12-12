// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CommandParentingSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

internal static class ExtensionCommandConfiguration
{
    [VisualStudioContribution]
    public static ToolbarConfiguration ToolBar => new("%CommandParentingSample.ToolBar.DisplayName%")
    {
        Children =
        [
            ToolbarChild.Command<SampleCommand>(),
        ],
    };
}

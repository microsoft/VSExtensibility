// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CommandParentingSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

[VisualStudioContribution]
internal class SampleCommand : Command
{
    public SampleCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%CommandParentingSample.SampleCommand.DisplayName%")
    {
        Placements = new[]
        {
            // File in project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 521, priority: 0),

            // Project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 518, priority: 0),

            // Solution context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 537, priority: 0),
        },
    };

    /// <inheritdoc />
    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

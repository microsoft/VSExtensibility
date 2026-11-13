// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExternalSettingsSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

[VisualStudioContribution]
internal sealed class ChangeBackingStoreCommand : Command
{
    private readonly SampleSettingsStore store;

    public ChangeBackingStoreCommand(SampleSettingsStore store)
    {
        this.store = store;
    }

    /// <inheritdoc/>
    public override CommandConfiguration CommandConfiguration => new("%ExternalSettingsSample.ChangeBackingStoreCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
    };

    /// <inheritdoc/>
    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        this.store.ChangeGreetingExternally();
        return Task.CompletedTask;
    }
}

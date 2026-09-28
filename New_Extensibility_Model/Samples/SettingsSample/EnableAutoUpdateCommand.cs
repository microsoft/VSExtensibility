// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

/// <summary>
/// Enables automatic updates for the sample text tool window.
/// </summary>
[VisualStudioContribution]
public class EnableAutoUpdateCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%SettingsSample.EnableAutoUpdateCommand.DisplayName%")
    {
        Description = "%SettingsSample.EnableAutoUpdateCommand.Description%",
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        EnabledWhen = ActivationConstraint.Setting(SettingDefinitions.AutoUpdateSetting, false),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Settings().WriteAsync(
            batch => batch.WriteSetting(SettingDefinitions.AutoUpdateSetting, true),
            Resources.AutoUpdateSettingWriteDescription,
            cancellationToken);
    }
}

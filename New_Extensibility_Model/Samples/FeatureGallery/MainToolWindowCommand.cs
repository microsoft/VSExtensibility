// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

/// <summary>
/// A sample command for showing a tool window.
/// </summary>
[VisualStudioContribution]
public class MainToolWindowCommand : Command
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainToolWindowCommand" /> class.
    /// </summary>
    public MainToolWindowCommand()
    {
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration =>
#if INPROC
        new("%InProcFeatureGallery.MainToolWindowCommand.DisplayName%")
#else
        new("%FeatureGallery.MainToolWindowCommand.DisplayName%")
#endif
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Shell().ShowToolWindowAsync<MainToolWindow>(activate: true, cancellationToken);
    }
}

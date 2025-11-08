// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AsyncPackageAndMEF;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Extensibility.VSSdkCompatibility;

[VisualStudioContribution]
internal class InteractWithMEFComponentCommand : Command
{
    private readonly MefInjection<MyMEFComponent> myMefComponentInjection;

    public InteractWithMEFComponentCommand(MefInjection<MyMEFComponent> myMefComponentInjection)
    {
        this.myMefComponentInjection = myMefComponentInjection;
    }

    public override CommandConfiguration CommandConfiguration => new(displayName: "%AsyncPackageAndMEF.InteractWithMEFComponentCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var myMefComponent = await this.myMefComponentInjection.GetServiceAsync();
        await myMefComponent.SayHelloAsync(this.Extensibility, cancellationToken);
    }
}

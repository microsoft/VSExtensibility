// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AsyncPackageAndMEF;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.VSSdkCompatibility;

[VisualStudioContribution]
internal class InteractWithAsyncPackageCommand : Command
{
    private readonly AsyncServiceProviderInjection<MyService, MyService> myServiceInjection;

    public InteractWithAsyncPackageCommand(AsyncServiceProviderInjection<MyService, MyService> myServiceInjection)
    {
        this.myServiceInjection = myServiceInjection;
    }

    public override CommandConfiguration CommandConfiguration => new(displayName: "%AsyncPackageAndMEF.InteractWithAsyncPackageCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var myService = await this.myServiceInjection.GetServiceAsync();
        await myService.SayHelloAsync(this.Extensibility, cancellationToken);
    }
}

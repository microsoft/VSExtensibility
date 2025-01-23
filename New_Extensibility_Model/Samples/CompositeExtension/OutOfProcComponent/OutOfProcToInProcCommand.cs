// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutOfProcComponent;

using System;
using System.Threading;
using System.Threading.Tasks;
using CompositeExtension;
using Microsoft;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

[VisualStudioContribution]
internal class OutOfProcToInProcCommand : Command
{
    public override CommandConfiguration CommandConfiguration => new("%OutOfProcComponent.OutOfProcToInProcCommand%")
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    public override Task InitializeAsync(CancellationToken cancellationToken)
    {
        return base.InitializeAsync(cancellationToken);
    }

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var inProcService = await this.Extensibility.ServiceBroker.GetProxyAsync<IOutOfProcService>(IInProcService.Configuration.ServiceDescriptor, cancellationToken);
        try
        {
            Assumes.NotNull(inProcService);
            await inProcService.DoSomethingAsync(cancellationToken);
        }
        finally
        {
            (inProcService as IDisposable)?.Dispose();
        }
    }
}

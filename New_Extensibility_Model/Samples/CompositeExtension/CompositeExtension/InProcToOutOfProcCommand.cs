// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CompositeExtension;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Threading;
using OutOfProcComponent;

[VisualStudioContribution]
internal class InProcToOutOfProcCommand : Command
{
    public override CommandConfiguration CommandConfiguration => new("%CompositeExtension.InProcToOutOfProcCommand%")
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
        var outOfProcService = await this.Extensibility.ServiceBroker.GetProxyAsync<IOutOfProcService>(IOutOfProcService.Configuration.ServiceDescriptor, cancellationToken);
        try
        {
            Assumes.NotNull(outOfProcService);
            await outOfProcService.DoSomethingAsync(cancellationToken);
        }
        finally
        {
            (outOfProcService as IDisposable)?.Dispose();
        }
    }
}

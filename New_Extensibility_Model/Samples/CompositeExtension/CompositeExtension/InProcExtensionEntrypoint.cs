// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CompositeExtension;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

[VisualStudioContribution]
internal class InProcExtensionEntrypoint : Extension
{
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        RequiresInProcessHosting = true,
    };

    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        serviceCollection.ProfferBrokeredService(InProcService.BrokeredServiceConfiguration, IInProcService.Configuration.ServiceDescriptor);
        base.InitializeServices(serviceCollection);
    }
}

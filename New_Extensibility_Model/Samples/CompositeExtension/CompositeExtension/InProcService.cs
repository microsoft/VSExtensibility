// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CompositeExtension;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Shell;

[VisualStudioContribution]
internal class InProcService : IInProcService
{
    private readonly VisualStudioExtensibility extensibility;

    public InProcService(VisualStudioExtensibility extensibility)
    {
        this.extensibility = extensibility;
    }

    [VisualStudioContribution]
    public static BrokeredServiceConfiguration BrokeredServiceConfiguration
        => new(IInProcService.Configuration.ServiceName, IInProcService.Configuration.ServiceVersion, typeof(InProcService))
        {
            ServiceAudience = BrokeredServiceAudience.Local | BrokeredServiceAudience.Public,
        };

    public async Task DoSomethingAsync(CancellationToken cancellationToken)
    {
        await this.extensibility.Shell().ShowPromptAsync("Hello from out-of-proc! (Showing this message from (in-proc)", PromptOptions.OK, cancellationToken);
    }
}

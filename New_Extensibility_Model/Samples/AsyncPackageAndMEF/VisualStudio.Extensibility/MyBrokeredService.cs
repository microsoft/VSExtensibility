// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AsyncPackageAndMEF;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Shell;

[VisualStudioContribution]
internal class MyBrokeredService : IMyBrokeredService
{
    private readonly VisualStudioExtensibility extensibility;

    private ProgressReporter? progressReporter;

    public MyBrokeredService(VisualStudioExtensibility extensibility)
    {
        this.extensibility = extensibility;
    }

    [VisualStudioContribution]
    public static BrokeredServiceConfiguration BrokeredServiceConfiguration
        => new(IMyBrokeredService.Configuration.ServiceName, IMyBrokeredService.Configuration.ServiceVersion, typeof(MyBrokeredService))
        {
            ServiceAudience = BrokeredServiceAudience.Local,
        };

    public async Task StartReportingProgressAsync(string message, CancellationToken cancellationToken)
    {
        if (this.progressReporter is not null)
        {
            throw new InvalidOperationException("Progress reporting has not been started.");
        }

        this.progressReporter = await this.extensibility.Shell().StartProgressReportingAsync(message, cancellationToken);
    }

    public Task StopReportingProgressAsync(CancellationToken cancellationToken)
    {
        if (this.progressReporter is null)
        {
            throw new InvalidOperationException("Progress reporting has not been started.");
        }

        this.progressReporter?.Dispose();
        this.progressReporter = null;
        return Task.CompletedTask;
    }
}

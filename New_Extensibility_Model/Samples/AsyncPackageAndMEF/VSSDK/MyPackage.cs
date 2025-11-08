// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AsyncPackageAndMEF;

using System.Runtime.InteropServices;
using System.Threading;
using Microsoft;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.ServiceBroker;

[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(MyPackage.PackageGuidString)]
[ProvideService(typeof(MyService), IsAsyncQueryable = true)]
public sealed class MyPackage : AsyncPackage
{
    public const string PackageGuidString = "ac1de0e2-bc69-4a63-bb7e-15f3274448c7";

    protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        this.AddService(
            typeof(MyService),
            (container, cancellationToken, serviceType) => Task.FromResult<object>(new MyService()),
            promote: true);

        this.DoSomethingAsync()
            .FileAndForget("AsyncPackageAndMEF/MyPackage/DoSomething");

        return Task.CompletedTask;
    }

    private async Task DoSomethingAsync()
    {
        var serviceBrokerContainer = await this.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
        var serviceBroker = serviceBrokerContainer.GetFullAccessServiceBroker();
        IMyBrokeredService? myBrokeredServiceProxy = null;
        try
        {
            myBrokeredServiceProxy = await serviceBroker.GetProxyAsync<IMyBrokeredService>(IMyBrokeredService.Configuration.ServiceDescriptor, this.DisposalToken);

            Assumes.NotNull(myBrokeredServiceProxy);
            await myBrokeredServiceProxy.StartReportingProgressAsync("Doing some work", this.DisposalToken);

            // Simulate doing some work.
            await Task.Delay(10000, this.DisposalToken);

            await myBrokeredServiceProxy.StopReportingProgressAsync(this.DisposalToken);
        }
        finally
        {
            (myBrokeredServiceProxy as IDisposable)?.Dispose();
        }
    }
}

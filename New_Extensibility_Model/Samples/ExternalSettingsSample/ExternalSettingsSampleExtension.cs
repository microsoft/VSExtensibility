// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExternalSettingsSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

[VisualStudioContribution]
public class ExternalSettingsSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            id: "ExternalSettingsSample.96b40862-41df-471f-883a-b767c03f5d35",
            version: this.ExtensionAssemblyVersion,
            publisherName: "Microsoft",
            displayName: "External Settings Sample Extension",
            description: "A setting backed by an in-memory store"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<SampleSettingsStore>();
        base.InitializeServices(serviceCollection);
    }
}

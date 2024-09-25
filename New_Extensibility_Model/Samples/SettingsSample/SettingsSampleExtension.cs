// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the SettingsSample.
/// </summary>
[VisualStudioContribution]
public class SettingsSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "SettingsSampleExtension.4ca466cb-dc8d-4216-8323-b5c45f8e0da5",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Settings Sample Extension",
                description: "Sample extension demonstrating settings"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

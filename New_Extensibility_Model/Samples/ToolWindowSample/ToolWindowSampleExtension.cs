// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the ToolWindowSample.
/// </summary>
[VisualStudioContribution]
public class ToolWindowSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "ToolWindowSampleExtension.4ca466cb-dc8d-4216-8323-b5c45f8e0da5",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Tool Window Sample Extension",
                description: "Sample extension demonstrating tool windows"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

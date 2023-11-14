// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

using System.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the OutputWindowSampleExtension.
/// </summary>
[VisualStudioContribution]
public class OutputWindowSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "OutputWindowSample.f739efb2-fdb2-4ecf-b857-d8e11fd1e5d3",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Output Window Sample Extension",
                description: "Sample extension demonstrating writing to the output window"),
    };

    /// <inheritdoc />
    protected override ResourceManager? ResourceManager => Strings.ResourceManager;

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

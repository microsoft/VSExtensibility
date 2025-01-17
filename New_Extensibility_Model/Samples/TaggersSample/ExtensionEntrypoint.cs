// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace TaggersSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the TaggersSample extension.
/// </summary>
[VisualStudioContribution]
public class ExtensionEntrypoint : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "TaggersSample.a72bbd16-4fca-45b9-8607-528a725b4e0f",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Taggers Sample Extension",
                description: "Sample extension demonstrating contributing a tagger"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

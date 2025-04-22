// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ClassificationSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the ClassificationSample extension.
/// </summary>
[VisualStudioContribution]
public class ExtensionEntrypoint : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "ClassificationSample.2e2edd6e-ccf8-4303-a159-068724c63ab0",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Classification Sample Extension",
                description: "Sample extension demonstrating contributing a classification tagger"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentSelectorSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the DocumentSelectorSample.
/// </summary>
[VisualStudioContribution]
public class DocumentSelectorSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "DocumentSelectorSampleExtension.541ed9b9-4dfa-4e0a-8184-65c09ea44343",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Document Selector Sample Extension",
                description: "Sample extension demonstrating document selectors"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

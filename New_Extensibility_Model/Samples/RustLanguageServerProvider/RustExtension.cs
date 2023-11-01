// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RustLanguageServerProviderExtension;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the VisualStudio.Extensibility extension.
/// </summary>
[VisualStudioContribution]
internal class RustExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "RustLspExtension.003741dc-9931-47c3-ad95-8804705cfbb9",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "RustLspExtension",
                description: "Rust Language Server Extension"),
    };

    /// <inheritdoc />
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);

        // You can configure dependency injection here by adding services to the serviceCollection.
    }
}

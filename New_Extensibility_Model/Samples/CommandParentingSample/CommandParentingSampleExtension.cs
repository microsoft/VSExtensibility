// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CommandParentingSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the CommandParentingSample.
/// </summary>
[VisualStudioContribution]
public class CommandParentingSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "CommandParentingSample.c30b7870-76bc-4ef6-93e8-15b9a54c9e2b",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Command Parenting Sample Extension",
                description: "Sample extension demonstrating command parenting"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

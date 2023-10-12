// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace InsertGuid;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the InsertGuid extension.
/// </summary>
[VisualStudioContribution]
public class InsertGuidExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "InsertGuid.c5481000-68da-416d-b337-32122a638980",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Insert Guid Sample Extension",
                description: "Sample extension demonstrating inserting text in the current document"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

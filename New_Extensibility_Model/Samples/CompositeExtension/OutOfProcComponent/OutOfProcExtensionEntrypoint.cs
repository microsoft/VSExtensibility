// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutOfProcComponent;

using CompositeExtension;
using Microsoft;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Threading;

/// <summary>
/// Extension entry point for the InsertGuid extension.
/// </summary>
[VisualStudioContribution]
internal class OutOfProcExtensionEntrypoint : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        // The following is irrelevant since OutOfProcComponent is being packaged as part of
        // CompositeExtension which has its own vsixmanifest.
        Metadata = new(
                id: "CompositeExtension.ac598512-71dd-4adf-81a3-80bf24a9a4dd",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Composite Extension",
                description: "Shows how to implement an extension with both in-proc and out-of-proc components."),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        serviceCollection.ProfferBrokeredService<OutOfProcService>();
        base.InitializeServices(serviceCollection);
    }
}

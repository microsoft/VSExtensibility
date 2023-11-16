// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the ToolWindowSample.
/// </summary>
[VisualStudioContribution]
public class FeatureGalleryExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
#if INPROC
        RequiresInProcessHosting = true,
#else
        Metadata = new(
                id: "FeatureGalleryExtension.f83f7a5e-61aa-4bb6-8f25-1cd2764e0123",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "VisualStudio.Extensibility Feature Gallery",
                description: "An extension demonstrating multiple Visual Studio extension points."),
#endif
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

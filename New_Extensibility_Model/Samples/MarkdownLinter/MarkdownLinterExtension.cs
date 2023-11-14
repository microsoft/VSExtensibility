// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using System.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// Extension entry point for Markdown Linter sample extension showcasing new
/// out of proc Visual Studio Extensibilty APIs.
/// </summary>
[VisualStudioContribution]
public class MarkdownLinterExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "MarkdownLinter.0cf26ba2-edd5-4419-8646-a55d0a83f7d8",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Markdown Linter Sample Extension",
                description: "Sample markdown linter extension"),
    };

    /// <inheritdoc />
    protected override ResourceManager? ResourceManager => Strings.ResourceManager;

    /// <summary>
    /// Initialize local services owned by the extension. These services can be shared
    /// by various parts such as commands, editor listeners using dependency injection.
    /// </summary>
    /// <param name="serviceCollection">Service collection to add services to.</param>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);

        // As of now, any instance that ingests VisualStudioExtensibility is required to be added as a scoped
        // service.
        serviceCollection.AddScoped<MarkdownDiagnosticsService>();
    }
}

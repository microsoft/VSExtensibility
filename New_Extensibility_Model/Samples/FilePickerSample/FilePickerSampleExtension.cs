// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilePickerSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the FilePickerSample.
/// </summary>
[VisualStudioContribution]
public class FilePickerSampleExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "FilePickerCommandSample.e9bc432a-5be1-43e8-b7d8-bc7b7024326d",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "File Picker Sample Extension",
                description: "Sample extension demonstrating the file picker prompt capabilities"),
    };

    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}

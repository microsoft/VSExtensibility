// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionWithTraditionalComponents;

using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the InsertGuid extension.
/// </summary>
[VisualStudioContribution]
internal class ExtensionEntrypoint : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        // The following is irrelevant since OutOfProcComponent is being packaged as part of
        // CompositeExtension which has its own vsixmanifest.
        Metadata = new(
                id: "ExtensionWithTraditionalComponents.1ccd148a-fa3a-414b-929b-85537d7a48b0",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Extension with Traditional Components",
                description: "Shows how to implement an out-of-process extension that packages traditional content."),
    };
}

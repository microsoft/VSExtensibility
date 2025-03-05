// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace EncodeDecodeBase64;

using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the EncodeDecodeBase64 extension.
/// </summary>
[VisualStudioContribution]
internal class EncodeDecodeBase64Extension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "EncodeDecodeBase64.87525EE0-4B75-4DF5-BB0E-C9EA1A5D2E15",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Encode or Decode Base64 Sample Extension",
                description: "Sample extension demonstrating encoding and decoding base64 text in the current document"),
    };
}

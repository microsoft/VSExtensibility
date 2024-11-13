// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// A sample demonstrating how to extend CodeLens.
/// </summary>
[VisualStudioContribution]
internal class ExtensionEntrypoint : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            "C43CCA96-C391-42B0-95A5-5B1090909605.CodeLensSample",
            this.ExtensionAssemblyVersion,
            "Microsoft",
            "Codelens Sample",
            "Sample extension demonstrating the CodeLens capabilities."),
    };
}

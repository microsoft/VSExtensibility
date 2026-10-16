// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynIntegrationExtension;

using Microsoft.VisualStudio.Extensibility;

[VisualStudioContribution]
internal class FindAssemblyExtension : Extension
{
    /// <inheritdoc />
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            id: "204ba5d8-59a5-4798-a2d1-a4f60eb4f44c.FindAssemblyExtension",
            version: this.ExtensionAssemblyVersion,
            publisherName: "Microsoft",
            displayName: "Roslyn Integration Sample",
            description: "Find the assembly defining a symbol using VisualStudio.Extensibility integration with Roslyn."),
    };
}

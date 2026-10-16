// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynMessageHandler;

using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis.Extensions;

#pragma warning disable VSEXTPREVIEW_LANGUAGES_QUERY // Roslyn integration is experimental.

public sealed class FindAssemblyMessage(DocumentPosition position)
{
    [JsonPropertyName("position")]
    public DocumentPosition Position { get; } = position;
}

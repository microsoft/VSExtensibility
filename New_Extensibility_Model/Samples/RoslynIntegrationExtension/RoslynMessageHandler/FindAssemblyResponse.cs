// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynMessageHandler;

using System.Text.Json.Serialization;

public class FindAssemblyResponse(string? symbolType, string? assemblyName, string? assemblyVersion, string? assemblyPath)
{
    [JsonPropertyName("symbolType")]
    public string? SymbolType { get; } = symbolType;

    [JsonPropertyName("assemblyName")]
    public string? AssemblyName { get; } = assemblyName;

    [JsonPropertyName("assemblyVersion")]
    public string? AssemblyVersion { get; } = assemblyVersion;

    [JsonPropertyName("assemblyPath")]
    public string? AssemblyPath { get; } = assemblyPath;
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynIntegrationExtension;

using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.UI;
using RoslynMessageHandler;

[DataContract]
internal class AssemblyInfoPopupData(FindAssemblyResponse response) : NotifyPropertyChangedObject
{
    [DataMember]
    public string? SymbolType { get; } = response.SymbolType;

    [DataMember]
    public string? AssemblyName { get; } = response.AssemblyName;

    [DataMember]
    public string? AssemblyVersion { get; } = response.AssemblyVersion;

    [DataMember]
    public string? AssemblyPath { get; } = response.AssemblyPath;

    [DataMember]
    public bool ShowAssemblyEnabled => this.AssemblyPath is not null;

    [DataMember]
    public AsyncCommand ShowAssemblyCommand { get; } = new AsyncCommand((assemblyPath, cancellationToken) =>
    {
        Process.Start("explorer.exe", $"/select, \"{assemblyPath}\"");
        return Task.CompletedTask;
    });
}

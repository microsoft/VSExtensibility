// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace UploaderExtension.Processor;

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.ProjectSystem.Query;

public static class PathCapture
{
    public static async Task<(string VsixPath, string PublishManifestPath)> CaptureAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        string projectPath = await GetProjectPathAsync(clientContext, cancellationToken);
        string relVsixPath = await GetVsixPathAsync(clientContext, cancellationToken);

        string absVsixPath = VsixPathGenerator(projectPath, relVsixPath);
        string absPublishManifest = PublishManifestPathGenerator(projectPath);

        return (absVsixPath, absPublishManifest);
    }

    private static async Task<string> GetProjectPathAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        try
        {
            IQueryResults<IProjectSnapshot> queryResultsMainPath = await clientContext.Extensibility.Workspaces().QueryProjectsAsync(
                q => q.With(p => p.Path),
                cancellationToken);

            IProjectSnapshot result = queryResultsMainPath.FirstOrDefault()
                ?? throw new ApplicationException("Project not found.");

            return result.Path;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.ToString());
        }
    }

    private static async Task<string> GetVsixPathAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        try
        {
#pragma warning disable VSEXTPREVIEW_PROJECTQUERY_PROPERTIES_BUILDPROPERTIES // Type is for evaluation purposes only and is subject to change or removal in future updates.
            IQueryResults<IProjectSnapshot> queryResults = await clientContext.Extensibility.Workspaces().QueryProjectsAsync(
                project => project.With(p => p.ActiveConfigurations
                .With(config => config.BuildPropertiesByName(
                    PersistenceStorageType.ProjectFile,
                    "TargetVsixContainer"))),
                cancellationToken);

            IProjectSnapshot projectQueryResult = queryResults.FirstOrDefault()
                ?? throw new InvalidOperationException("Project not found.");

            IProjectConfigurationSnapshot activeConfig = projectQueryResult.ActiveConfigurations.FirstOrDefault()
                ?? throw new InvalidOperationException("None active configurations.");

            IBuildPropertySnapshot projectProperty = activeConfig.BuildProperties.FirstOrDefault()
                ?? throw new InvalidOperationException("TargetVsixContainer not found.");

            return projectProperty.Value!;
#pragma warning restore VSEXTPREVIEW_PROJECTQUERY_PROPERTIES_BUILDPROPERTIES // Type is for evaluation purposes only and is subject to change or removal in future updates.
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Unexpected error, no project found.");
        }
    }

    private static string VsixPathGenerator(string absMainPath, string relVsixPath)
    {
        try
        {
            string directoryName = Path.GetDirectoryName(absMainPath)
                ?? throw new ArgumentNullException("Directory name is null.");

            string vsixPath = Path.Combine(directoryName, relVsixPath);

            return vsixPath;
        }
        catch (Exception)
        {
            throw new InvalidOperationException($"An error occurred while finding the path to the TargetVsixContainer.");
        }
    }

    private static string PublishManifestPathGenerator(string absMainPath)
    {
        string directoryName = Path.GetDirectoryName(absMainPath)
            ?? throw new ArgumentNullException("Directory name is null.");

        // Create folder
        string absPublishManifestPath = Path.Combine(directoryName, "Properties");
        Directory.CreateDirectory(absPublishManifestPath);
        string jsonPath = Path.Combine(absPublishManifestPath, "publishManifest.json");

        return jsonPath;
    }
}

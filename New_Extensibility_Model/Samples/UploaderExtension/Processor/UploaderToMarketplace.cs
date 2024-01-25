// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson;

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ReadVsixToJson.Models;

internal static class UploaderToMarketplace
{
    public static async Task UploadAsync(ReadVsixToJsonRequest request)
    {
        // Create instance of VsixManifestReader (reader), to pass 2 fields stored in it.
        VsixManifestReader vsixReader = new VsixManifestReader();
        VsixManifestModel vsixManifestModel = vsixReader.Read(request.PathToVsix!);

        // Create instance of PublishManifestModelBuilder to call method that populates OutPut model
        PublishManifestModel outputModel = new PublishManifestModel(request, vsixManifestModel);

        // Create instance of JsonBuilder class to call method that creates JSON file
        WriteJsonObject(outputModel, request.PathToPublishManifest!);

        // Create instance of UploaderToMarketplace to call on method that Uploads the extension
        await RunProcessToUploadExtAsync(request);
    }

    private static async Task RunProcessToUploadExtAsync(ReadVsixToJsonRequest request)
    {
        try
        {
            string vsixPublisherPath = GetVsixPublisherPath();

            ProcessStartInfo startinfo = new ProcessStartInfo(vsixPublisherPath);
            startinfo.ArgumentList.Add("publish");
            startinfo.ArgumentList.Add("-payload");
            startinfo.ArgumentList.Add(request.PathToVsix ?? throw new ArgumentNullException("Vsix path is null."));
            startinfo.ArgumentList.Add("-publishManifest");
            startinfo.ArgumentList.Add(request.PathToPublishManifest ?? throw new ArgumentNullException("Json path is null."));
            startinfo.ArgumentList.Add("-personalAccessToken");
            startinfo.ArgumentList.Add(request.PersonalAccessToken ?? throw new ArgumentNullException("PAT is null."));
            startinfo.UseShellExecute = false;
            startinfo.CreateNoWindow = true;
            startinfo.RedirectStandardOutput = true;
            startinfo.RedirectStandardError = true;

            var process = Process.Start(startinfo);

            if (process != null)
            {
                await process.WaitForExitAsync();
                int exitCode = process.ExitCode;

                if (exitCode != 0)
                {
                    string standardErrorText = await process.StandardError.ReadToEndAsync();
                    string standardOutputText = await process.StandardOutput.ReadToEndAsync();

                    throw new ApplicationException($"Extension was not uploaded. Error message: {standardErrorText}." +
                        $"{standardOutputText}");
                }
            }
            else
            {
                throw new ApplicationException("Process that starts VsixPublisher.exe resulted null.");
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Exception: {ex.ToString()}");
        }
    }

    private static string GetVsixPublisherPath()
    {
        Assembly assemblyLocation = Assembly.GetEntryAssembly()
            ?? throw new ArgumentNullException("No directory found.");
        string absAssemblyPath = assemblyLocation.Location;

        string absVsixPublishExe = Path.GetFullPath(Path.Combine(absAssemblyPath, @"..\..\..\..\..\VSSDK\VisualStudioIntegration\Tools\Bin\VsixPublisher.exe"));

        return absVsixPublishExe;
    }

    private static void WriteJsonObject(PublishManifestModel model, string fileName)
    {
        // Passing the model to a Json Object:
        JObject modelToJson = (JObject)JToken.FromObject(model);

        // Writing the Json Object to a New File:
        using StreamWriter streamWriter = File.CreateText(fileName);
        using var jsonWriter = new JsonTextWriter(streamWriter);
        jsonWriter.Formatting = Formatting.Indented;
        modelToJson.WriteTo(jsonWriter);
    }
}

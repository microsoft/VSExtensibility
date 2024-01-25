// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionPublisher;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using ExtensionPublisher.Processor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Extensibility.UI;
using Newtonsoft.Json;
using ReadVsixToJson;
using ReadVsixToJson.Models;

[DataContract]

public class DataBinding : INotifyPropertyChanged
{
    // Categories taken from http://json.schemastore.org/vsix-publish
    private static readonly string[] Categories =
    {
            "ajax", "build", "coding", "connected services", "data", "database", "documentation", "extension sdk", "framework and libraries", "lightswitch", "lightswitch controls",
            "lightswitch templates", "modeling", "office", "other", "other templates", "performance", "process templates", "programming languages", "reporting", "scaffolding",
            "security", "setup and deployment", "sharepoint", "sharepoint controls", "sharepoint templates", "silverlight controls", "source control", "start pages", "team development",
            "testing", "visual studio extensions", "wcf", "web", "windows forms templates", "windows forms controls", "workflow", "wpf templates", "wpf controls", "xna",
    };

    private readonly VisualStudioExtensibility extensibility;

    private bool internalIsSubmitEnable = true;

    private bool internalIsIndeterminate = false;

    private bool internalQna = false;

    private bool internalPrivate = false;

    private string internalPriceOption = "Free";

    private string internalRepo = string.Empty;

    private string internalExtensionDescription = string.Empty;

    private IReadOnlyList<MyCategory> internalMyCategories = Categories.Select(c => new MyCategory(c)).ToList();

    public DataBinding(VisualStudioExtensibility extensibility)
    {
        this.extensibility = extensibility;

        this.SubmitUpload = new AsyncCommand(async (parameter, clientContext, cancellationToken) =>
        {
            this.IsIndeterminate = true;
            this.IsSubmitEnable = false;

            await this.UploadExtensionAsync(clientContext, cancellationToken);

            this.IsIndeterminate = false;
            this.IsSubmitEnable = true;
        });
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [DataMember]
    public IReadOnlyList<MyCategory> MyCategories
    {
        get
        {
            return this.internalMyCategories;
        }

        set
        {
            this.internalMyCategories = value;
            this.OnPropertyChanged(nameof(this.MyCategories));
        }
    }

    [DataMember]
    public IReadOnlyList<string> PriceOptions { get; } = new[] { "Free", "Paid", "Trial" };

    [DataMember]
    public string PriceOption
    {
        get
        {
            return this.internalPriceOption;
        }

        set
        {
            this.internalPriceOption = value;
            this.OnPropertyChanged(nameof(this.PriceOption));
        }
    }

    [DataMember]
    public bool Qna
    {
        get
        {
            return this.internalQna;
        }

        set
        {
            this.internalQna = value;
            this.OnPropertyChanged(nameof(this.Qna));
        }
    }

    [DataMember]
    public bool Private
    {
        get
        {
            return this.internalPrivate;
        }

        set
        {
            this.internalPrivate = value;
            this.OnPropertyChanged(nameof(this.Private));
        }
    }

    [DataMember]
    public string? PersonalAccessToken { get; set; }

    [DataMember]
    public string? Repo
    {
        get
        {
            return this.internalRepo;
        }

        set
        {
            this.internalRepo = value ?? throw new ApplicationException("Missing extension's GitHub repository.");
            this.OnPropertyChanged(nameof(this.Repo));
        }
    }

    [DataMember]
    public string? ExtensionDescription
    {
        get
        {
            return this.internalExtensionDescription;
        }

        set
        {
            this.internalExtensionDescription = value ?? throw new ArgumentNullException("Missing extension's description.");
            this.OnPropertyChanged(nameof(this.ExtensionDescription));
        }
    }

    [DataMember]
    public AsyncCommand SubmitUpload { get; }

    [DataMember]
    public bool IsSubmitEnable
    {
        get
        {
            return this.internalIsSubmitEnable;
        }

        set
        {
            this.internalIsSubmitEnable = value;
            this.OnPropertyChanged(nameof(this.IsSubmitEnable));
        }
    }

    [DataMember]
    public bool IsIndeterminate
    {
        get
        {
            return this.internalIsIndeterminate;
        }

        set
        {
            this.internalIsIndeterminate = value;
            this.OnPropertyChanged(nameof(this.IsIndeterminate));
        }
    }

    public void OnPropertyChanged(string propertyName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public async Task InitializeAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        await this.GetDataFromPublishManifestAsync(clientContext, cancellationToken);
    }

    private static async Task EmitMessageAsync(
        string message,
        VisualStudioExtensibility extensibility,
        CancellationToken cancellationToken)
    {
        await extensibility.Shell().ShowPromptAsync(message, PromptOptions.OK, cancellationToken);
    }

    private async Task<string> GenerateReadmePathAsync(
        string publishManifestPath, CancellationToken cancellationToken, string extensionDescription)
    {
        return await Task.Run<string>(
            () =>
            {
                for (int i = 0; i < 2; i++)
                {
                    publishManifestPath = Path.GetDirectoryName(publishManifestPath)
                        ?? throw new ArgumentNullException("Assembly path is null.");
                }

                string absPathToReadme = Path.Combine(publishManifestPath, "Readme.md");

                if (File.Exists(absPathToReadme))
                {
                    return absPathToReadme;
                }
                else
                {
                    string readmeDescription = extensionDescription;
                    File.WriteAllText(absPathToReadme, readmeDescription);

                    return absPathToReadme;
                }
            },
            cancellationToken);
    }

    // Return a list instead for size management.
    private async Task<List<string>> ReadCategoriesAsync(
        IReadOnlyList<MyCategory> uiCategories,
        CancellationToken cancellationToken)
    {
        int counter = 0;
        List<string> selectedCategories = new List<string>();
        foreach (MyCategory category in uiCategories)
        {
            if (category.IsSelected)
            {
                if (counter < 3)
                {
                    selectedCategories.Add(category.Description);
                    counter++;
                }
                else
                {
                   await this.extensibility.Shell().ShowPromptAsync(
                       string.Format("More than 3 categories selected."),
                       PromptOptions.OK,
                       cancellationToken);
                }
            }
        }

        return selectedCategories;
    }

    private async Task UploadExtensionAsync(
        IClientContext clientContext,
        CancellationToken cancellationToken)
    {
        try
        {
            (string vsixPath, string publishManifestPath) = await PathCapture.CaptureAsync(clientContext, cancellationToken);

            List<string> readCategories = await this.ReadCategoriesAsync(
                    this.MyCategories,
                    cancellationToken);

            string extensionDescription = this.ExtensionDescription ??
                throw new ApplicationException("Description to generate Readme was not provided.");

            ReadVsixToJsonRequest request = new ReadVsixToJsonRequest
            {
                PathToVsix = vsixPath,
                PathToPublishManifest = publishManifestPath,
                Categories = readCategories,
                PriceCategory = this.PriceOption,
                Private = this.Private,
                Qna = this.Qna,
                PersonalAccessToken = this.PersonalAccessToken,
                Overview = await this.GenerateReadmePathAsync(publishManifestPath, cancellationToken, extensionDescription),
                Repo = this.Repo,
            };

            await UploaderToMarketplace.UploadAsync(request);

            await EmitMessageAsync($"Your extension was successfully uploaded.", this.extensibility, cancellationToken);
        }
        catch (Exception ex)
        {
            string message = ex.Message;
            await EmitMessageAsync(message, this.extensibility, cancellationToken);
        }
    }

    private async Task GetDataFromPublishManifestAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        PublishManifestModel modelPreviousJson = await this.BuildModelForPublishManifestAsync(clientContext, cancellationToken);
        if (modelPreviousJson != null)
        {
            this.Qna = modelPreviousJson.Qna ?? this.internalQna;
            this.Private = modelPreviousJson.Private ?? this.internalPrivate;
            this.PriceOption = modelPreviousJson.PriceCategory ?? this.internalPriceOption;
            this.Repo = modelPreviousJson.Repo ?? this.internalRepo;

            string readmePath = modelPreviousJson.Overview ?? string.Empty;
            this.ExtensionDescription = File.ReadAllText(readmePath);

            if (modelPreviousJson.Categories != null)
            {
                this.MyCategories = Categories.Select(c => new MyCategory(c, modelPreviousJson.Categories)).ToList();
            }
        }
        else
        {
            return;
        }
    }

    private async Task<PublishManifestModel> BuildModelForPublishManifestAsync(
        IClientContext clientContext, CancellationToken cancellationToken)
    {
        (string vsixPath, string publishManifestPath) = await PathCapture.CaptureAsync(clientContext, cancellationToken);

        try
        {
            string publishManifestContent = File.ReadAllText(publishManifestPath);
            PublishManifestModel modelForReading = JsonConvert.DeserializeObject<PublishManifestModel>(publishManifestContent)
                ?? throw new ArgumentNullException("Publish Manifest does not exists.");
            return modelForReading;
        }
        catch (FileNotFoundException)
        {
            return null!;
        }
    }
}

[DataContract]
public class MyCategory
{
    public MyCategory(string description)
    {
        this.Description = description;
        this.IsSelected = false;
    }

    public MyCategory(string description, List<string> savedCategories)
    {
        this.Description = description;
        this.IsSelected = false;

        foreach (string category in savedCategories)
        {
            if (description == category)
            {
                this.IsSelected = true;
            }
        }
    }

    [DataMember]
    public string Description { get; }

    [DataMember]
    public bool IsSelected { get; set; }
}

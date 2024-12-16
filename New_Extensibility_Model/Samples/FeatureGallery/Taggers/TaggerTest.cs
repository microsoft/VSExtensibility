// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.RpcContracts.Documents;

[DataContract]
internal class TaggerTest : TestData
{
#if INPROC
    public const string FileExtension = "myinprocmd";
#else
    public const string FileExtension = "mymd";
#endif

    public TaggerTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [VisualStudioContribution]
    public static DocumentTypeConfiguration MyMarkdownDocumentType => new(FileExtension)
    {
        FileExtensions = ["." + FileExtension],
        BaseDocumentType = DocumentType.KnownValues.Text,
    };

    [DataMember]
    public override string ButtonText => "Taggers and CodeLens";

    [DataMember]
    public override string Description => "This command opens a markdown file. Every title in the file should be highlighted and have a CodeLens showing its ID on top of it. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + "." + FileExtension);
        bool keepFile = false;

        using var file = new StreamWriter(File.Create(filePath));
        try
        {
            await file.WriteAsync("""
                # Title 1

                ## Title 2
                Some text.
                Some more text.

                # Title 3
                Even more text.
                """);
            file.Close();

            var textDocumentSnapshot = await this.Extensibility.Documents().OpenTextDocumentAsync(new(filePath), cancellationToken);

            if (!await this.Extensibility.Shell().ShowPromptAsync("Press OK to close and delete the file.", PromptOptions.OKCancel, cancellationToken))
            {
                keepFile = true;
            }
        }
        finally
        {
            if (!keepFile)
            {
                await this.Extensibility.Documents().CloseDocumentAsync(new(filePath), SaveDocumentOption.NoSave, cancellationToken);
                File.Delete(filePath);
            }
        }
    }
}

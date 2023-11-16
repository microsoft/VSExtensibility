// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using System.IO;
using Microsoft.VisualStudio.RpcContracts.Documents;
using Microsoft.VisualStudio.Extensibility.Shell;

[DataContract]
internal class DocumentEditingTest : TestData
{
    public DocumentEditingTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [DataMember]
    public override string ButtonText => "Edit a document";

    [DataMember]
    public override string Description => "This command opens a new file and writes a random GUID in it. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".md");
        File.Create(filePath).Close();
        bool keepFile = false;
        try
        {
            var textDocumentSnapshot = await this.Extensibility.Documents().OpenTextDocumentAsync(new(filePath), cancellationToken);

            await this.Extensibility.Editor().EditAsync(
                batch => textDocumentSnapshot.AsEditable(batch).Insert(0, Guid.NewGuid().ToString()),
                cancellationToken);

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

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.RpcContracts.Documents;

[DataContract]
internal class EditorMarginTest : TestData
{
    public EditorMarginTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [DataMember]
    public override string ButtonText => "Editor margin";

    [DataMember]
    public override string Description => "This command opens a text document with a custom editor margin counting the words in the document. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".txt");
        bool keepFile = false;

        using var file = new StreamWriter(File.Create(filePath));
        try
        {
            await file.WriteAsync("""
                using System;

                public class Class1
                {
                    public Class1()
                    {
                    }
                }
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

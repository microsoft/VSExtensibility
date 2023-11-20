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
#if INPROC
    public const string FileExtension = "mywords";
#else
    public const string FileExtension = "words";
#endif

    public EditorMarginTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [VisualStudioContribution]
    public static DocumentTypeConfiguration WordsDocumentType => new(FileExtension)
    {
        FileExtensions = new[] { "." + FileExtension },
        BaseDocumentType = DocumentType.KnownValues.Text,
    };

    [DataMember]
    public override string ButtonText => "Editor margin";

    [DataMember]
    public override string Description => $"This command opens a text document with a custom editor margin, in the bottom-right corner, counting the words in the document. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + "." + FileExtension);
        bool keepFile = false;

        using var file = new StreamWriter(File.Create(filePath));
        try
        {
            await file.WriteAsync("""
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis knostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute
                irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat
                cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
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

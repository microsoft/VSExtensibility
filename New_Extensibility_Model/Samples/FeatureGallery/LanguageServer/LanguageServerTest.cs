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
using Microsoft.VisualStudio.Extensibility.LanguageServer;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.RpcContracts.Documents;

[DataContract]
internal class LanguageServerTest : TestData
{
#if INPROC
    public const string FileExtension = "todo";
#else
    public const string FileExtension = "todos";
#endif

    public LanguageServerTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [VisualStudioContribution]
#pragma warning disable VSEXTPREVIEW_LSP // Type is for evaluation purposes only and is subject to change or removal in future updates.
    public static DocumentTypeConfiguration TodosDocumentType => new(FileExtension)
    {
        FileExtensions = ["." + FileExtension],
        BaseDocumentType = LanguageServerProvider.LanguageServerBaseDocumentType,
    };
#pragma warning restore VSEXTPREVIEW_LSP // Type is for evaluation purposes only and is subject to change or removal in future updates.

    [DataMember]
    public override string ButtonText => "Language Server";

    [DataMember]
    public override string Description => $"This command opens a new file, green squiggles (warning diagnostics) will be generated for each line containing `TODO:`. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + "." + FileExtension);
        bool keepFile = false;

        using var file = new StreamWriter(File.Create(filePath));
        try
        {
            await file.WriteAsync("""
                TODO: My first todo.
                Some other text.
                TODO: My second reminder.
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

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
internal class ClassificationsTest : TestData
{
#if INPROC
    public const string FileExtension = "myinprocsv";
#else
    public const string FileExtension = "mycsv";
#endif

    public ClassificationsTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [VisualStudioContribution]
    public static DocumentTypeConfiguration MyCsvDocumentType => new(FileExtension)
    {
        FileExtensions = ["." + FileExtension],
        BaseDocumentType = DocumentType.KnownValues.Text,
    };

    [DataMember]
    public override string ButtonText => "Classifications";

    [DataMember]
    public override string Description => "This command opens a csv file. The headers, fields, commas and quotes should have different colors. A prompt will ask to close the file.";

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + "." + FileExtension);
        bool keepFile = false;

        using var file = new StreamWriter(File.Create(filePath));
        try
        {
            await file.WriteAsync("""
                Foo,"Bar",Baz
                F1o,"B""1""r",B1z
                F2o,"B2r",B2z
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

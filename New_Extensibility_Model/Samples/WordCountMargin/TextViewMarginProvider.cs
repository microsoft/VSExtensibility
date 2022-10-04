using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Editor.Data;
using Microsoft.VisualStudio.Extensibility.Editor.UI;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

namespace Extension2
{
    [ExtensionPart(typeof(ITextViewLifetimeListener))]
    [ExtensionPart(typeof(ITextViewChangedListener))]
    [ExtensionPart(typeof(ITextViewMarginProvider))]
    [AppliesTo(DocumentType = "text")]
    [TextViewMargin(Name = "WordCountMargin", MarginContainer = PredefinedMarginNames.BottomRightCorner)]
    [Order(Before = PredefinedMarginNames.RowMargin)]
    internal class MyTextViewMarginProvider : ExtensionPart, ITextViewMarginProvider, ITextViewLifetimeListener, ITextViewChangedListener
    {
        private Dictionary<int, WordCountData> dataModels = new();

        public MyTextViewMarginProvider(ExtensionCore container, VisualStudioExtensibility extensibilityObject) : base(container, extensibilityObject)
        {
        }

        public async Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
        {
            var documentSnapshot = await textView.GetTextDocumentAsync(cancellationToken).ConfigureAwait(false);
            var dataModel = new WordCountData();
            dataModel.WordCount = CountWords(documentSnapshot);
            dataModels[textView.RpcContract.Id] = dataModel;
            return new MyMarginContent(dataModel);
        }

        public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
        {
            var documentSnapshot = await args.AfterTextView.GetTextDocumentAsync(cancellationToken);
            dataModels[args.AfterTextView.RpcContract.Id].WordCount = CountWords(documentSnapshot);
        }

        public Task TextViewClosedAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
        {
            this.dataModels.Remove(textView.RpcContract.Id);
            return Task.CompletedTask;
        }

        public Task TextViewCreatedAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private static int CountWords(ITextDocumentSnapshot documentSnapshot)
        {
            int wordCount = 0;
            for (int i = 1; i < documentSnapshot.Length; i++)
            {
                if (char.IsWhiteSpace(documentSnapshot[i-1]) && char.IsLetterOrDigit(documentSnapshot[i]))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}

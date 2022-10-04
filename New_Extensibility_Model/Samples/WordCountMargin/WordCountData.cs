using System.Runtime.Serialization;

using Microsoft.VisualStudio.Extensibility.UI;


namespace Extension2
{
    [DataContract]
    public class WordCountData: NotifyPropertyChangedObject
    {
        private int wordCount;

        [DataMember]
        public int WordCount
        {
            get => this.wordCount;
            set => this.SetProperty(ref this.wordCount, value);
        }
    }
}

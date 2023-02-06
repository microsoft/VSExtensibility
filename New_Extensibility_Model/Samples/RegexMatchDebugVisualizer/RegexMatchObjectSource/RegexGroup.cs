namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

using System.Runtime.Serialization;

[DataContract]
internal class RegexGroup : RegexCapture
{
	[DataMember]
	public bool Success { get; set; }

	[DataMember]
	public RegexCapture[]? Captures { get; set; }
}

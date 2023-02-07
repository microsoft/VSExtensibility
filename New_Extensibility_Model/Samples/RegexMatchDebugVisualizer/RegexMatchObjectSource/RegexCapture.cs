namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

using System.Runtime.Serialization;

[DataContract]
internal class RegexCapture
{
	[DataMember]
	public int Index { get; set; }

	[DataMember]
	public int Length { get; set; }

	[DataMember]
	public string? Value { get; set; }

	[DataMember]
	public string? Name { get; set; }

#if VISUALIZER
	[DataMember]
	public string Range => $"{this.Index}-{this.Index + this.Length}";
#endif
}

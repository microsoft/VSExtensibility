namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

using System.Runtime.Serialization;

[DataContract]
internal class RegexMatch : RegexGroup
{
	[DataMember]
	public RegexGroup[]? Groups { get; set; }
}

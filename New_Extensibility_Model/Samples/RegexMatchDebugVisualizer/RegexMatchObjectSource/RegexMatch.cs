// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer.ObjectSource;

using System.Runtime.Serialization;

[DataContract]
internal class RegexMatch : RegexGroup
{
	[DataMember]
	public RegexGroup[]? Groups { get; set; }
}

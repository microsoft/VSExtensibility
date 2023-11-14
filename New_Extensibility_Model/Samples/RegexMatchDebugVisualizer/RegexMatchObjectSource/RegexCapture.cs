// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer.ObjectSource;

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

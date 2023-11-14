// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer.ObjectSource;

using System.Runtime.Serialization;

[DataContract]
internal class RegexGroup : RegexCapture
{
    [DataMember]
    public bool Success { get; set; }

    [DataMember]
    public RegexCapture[]? Captures { get; set; }
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamVisualizer;

using System.Runtime.Serialization;

/// <summary>
/// ViewModel class representing a row of binary data.
/// </summary>
[DataContract]
public class HexEditorRow
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HexEditorRow"/> class.
    /// </summary>
    /// <param name="index">The index of this row.</param>
    /// <param name="data">The bytes making up this row of data, in their hex representation.</param>
    /// <param name="ascii">The bytes making up this row of data, in their Ascii representation.</param>
    public HexEditorRow(int index, string data, string ascii)
    {
        this.Index = index;
        this.Data = data;
        this.Ascii = ascii;
    }

    /// <summary>
    /// Gets the index of this row.
    /// </summary>
    [DataMember]
    public int Index { get; }

    /// <summary>
    /// Gets the index of this row in hex format.
    /// </summary>
    [DataMember]
    public string HexIndex => $"{this.Index:X8}h";

    /// <summary>
    /// Gets the bytes making up this row of data, in their hex representation.
    /// </summary>
    [DataMember]
    public string Data { get; }

    /// <summary>
    /// Gets the bytes making up this row of data, in their Ascii representation.
    /// </summary>
    [DataMember]
    public string Ascii { get; }
}

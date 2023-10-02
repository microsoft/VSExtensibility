// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamVisualizer;

using System.IO;
using System.Runtime.Serialization;
using System.Windows;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// ModelView class representing the data contained by a <see cref="MemoryStream"/>.
/// </summary>
[DataContract]
public class MemoryStreamData : NotifyPropertyChangedObject
{
	private long length;
	private long position;
	private Visibility loadingVisibility = Visibility.Visible;

	/// <summary>
	/// Gets or sets the length of the <see cref="MemoryStream"/>.
	/// </summary>
	[DataMember]
	public long Length
	{
		get => this.length;
		set
		{
			if (this.SetProperty(ref this.length, value))
			{
				this.RaiseNotifyPropertyChangedEvent(nameof(this.HexLength));
			}
		}
	}

	/// <summary>
	/// Gets the length of the <see cref="MemoryStream"/> in hex format.
	/// </summary>
	[DataMember]
	public string HexLength => $"{this.length:X}h";

	/// <summary>
	/// Gets or sets the current position of the <see cref="MemoryStream"/>.
	/// </summary>
	[DataMember]
	public long Position
	{
		get => this.position;
		set
		{
			if (this.SetProperty(ref this.position, value))
			{
				this.RaiseNotifyPropertyChangedEvent(nameof(this.HexPosition));
			}
		}
	}

	/// <summary>
	/// Gets the current position of the <see cref="MemoryStream"/> in hex format.
	/// </summary>
	[DataMember]
	public string HexPosition => $"{this.position:X}h";

	/// <summary>
	/// Gets the data currently contained in the <see cref="MemoryStream"/>.
	/// </summary>
	[DataMember]
	public ObservableList<HexEditorRow> Data { get; } = new();

	/// <summary>
	/// Gets or sets whether the loading bar should be visible.
	/// </summary>
	[DataMember]
	public Visibility LoadingVisibility
	{
		get => this.loadingVisibility;
		set => this.SetProperty(ref this.loadingVisibility, value);
	}
}

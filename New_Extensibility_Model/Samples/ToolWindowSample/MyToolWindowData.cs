// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowSample;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample data context object to use with tool window UI content.
/// </summary>
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
	private bool hasError;
	private string message = "My custom message";

	/// <summary>
	/// Initializes a new instance of the <see cref="MyToolWindowData" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	public MyToolWindowData(VisualStudioExtensibility extensibility)
	{
		Requires.NotNull(extensibility, nameof(extensibility));

		this.Context = new ClientContext(new Dictionary<string, object?>(), extensibility);
		this.ShowMessageCommand = new AsyncCommand(this.ShowMessageAsync);
	}

	/// <summary>
	/// Gets the async command used to show a message prompt.
	/// </summary>
	[DataMember]
	public IAsyncCommand ShowMessageCommand
	{
		get;
	}

	/// <summary>
	/// Gets or sets a value indicating whether there is an error in the data context.
	/// </summary>
	[DataMember]
	public bool HasError
	{
		get => this.hasError;
		set => this.SetProperty(ref this.hasError, value);
	}

	/// <summary>
	/// Gets or sets the message to display in the message prompt.
	/// </summary>
	[DataMember]
	public string Message
	{
		get => this.message;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				this.HasError = true;
			}
			else
			{
				this.HasError = false;
			}

			this.SetProperty(ref this.message, value);
		}
	}

	private ClientContext Context
	{
		get;
	}

	private async Task ShowMessageAsync(object? commandParameter, CancellationToken cancellationToken)
	{
		await this.Context.ShowPromptAsync(this.Message, PromptOptions.OK, cancellationToken);
	}
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowSample;

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
    private readonly VisualStudioExtensibility extensibility;
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
        this.extensibility = Requires.NotNull(extensibility, nameof(extensibility));

        this.ShowMessageCommand = new AsyncCommand(this.ShowMessageAsync);
        this.ClearCommand = new AsyncCommand(this.ClearAsync);
        this.DefaultTextCommand = new AsyncCommand(this.DefaultTextAsync);
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
    /// Gets the async command used to clear the message text box.
    /// </summary>
    [DataMember]
    public IAsyncCommand ClearCommand
    {
        get;
    }

    /// <summary>
    /// Gets the async command used to set the message to a default value.
    /// </summary>
    [DataMember]
    public IAsyncCommand DefaultTextCommand
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

    private async Task ShowMessageAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        await this.extensibility.Shell().ShowPromptAsync(this.Message, PromptOptions.OK, cancellationToken);
    }

    private Task ClearAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        this.Message = string.Empty;
        return Task.CompletedTask;
    }

    private Task DefaultTextAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        this.Message = "Hello world";
        return Task.CompletedTask;
    }
}

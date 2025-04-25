// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace UserPromptSample;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;

/// <summary>
/// AdvancedConfigurationCommand handler.
/// </summary>
[VisualStudioContribution]
internal class AdvancedConfigurationCommand : Command
{
    private readonly TraceSource logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="AdvancedConfigurationCommand"/> class.
    /// </summary>
    /// <param name="traceSource">Trace source instance to utilize.</param>
    public AdvancedConfigurationCommand(TraceSource traceSource)
    {
        // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
        // other services here as well.
        this.logger = Requires.NotNull(traceSource, nameof(traceSource));
    }

    internal enum Systems
    {
        CoreSystem,
        AuxiliarySystem,
        MonitoringSystem,
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new(displayName: "%UserPromptSample.AdvancedConfigurationCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override Task InitializeAsync(CancellationToken cancellationToken)
    {
        // Use InitializeAsync for any one-time setup or initialization.
        return base.InitializeAsync(cancellationToken);
    }

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        const string Title = "Configuration Assistant";
        ShellExtensibility shell = this.Extensibility.Shell();

        // Show a prompt that accepts string input from the user, with a custom title.
        string? projectName = await shell.ShowPromptAsync(
            "Enter the name of the project to configure?",
            InputPromptOptions.Default with { Title = Title },
            cancellationToken);

        if (string.IsNullOrEmpty(projectName))
        {
            this.logger.TraceInformation("User did not provide project name.");

            // Show a confirmation prompt (one 'OK' button) with error icon and title.
            await shell.ShowPromptAsync(
                "Project name is required to proceed. Exiting the configuration process.",
                PromptOptions.ErrorConfirm with { Title = Title },
                cancellationToken);

            return;
        }

        // Show a prompt that accepts one of a predefined set of choices from the user, with a custom title and icon.
        Systems selectedSystem = await shell.ShowPromptAsync(
            "Select the system to configure:",
            new PromptOptions<Systems>
            {
                Choices =
                {
                    { "Core", Systems.CoreSystem },
                    { "Auxiliary", Systems.AuxiliarySystem },
                    { "Monitoring", Systems.MonitoringSystem },
                    { "SomeOtherThing", Systems.CoreSystem },
                    { "Some Fifth Thing", Systems.CoreSystem },
                },
                DismissedReturns = Systems.CoreSystem,
                Title = Title,
                Icon = ImageMoniker.KnownValues.Settings,
            },
            cancellationToken);

        // Show a prompt that accepts a boolean response from the user ('OK' or 'Cancel'), with a custom title and icon.
        bool confirmConfiguration = await shell.ShowPromptAsync(
            $"The selected system ({selectedSystem}) may require additional resources. Do you want to proceed?",
            PromptOptions.OKCancel with
            {
                Title = Title,
                Icon = ImageMoniker.KnownValues.StatusSecurityWarning,
            },
            cancellationToken);

        if (!confirmConfiguration)
        {
            this.logger.TraceInformation($"User canceled configuration for project ({projectName}) system ({selectedSystem}).");
            await shell.ShowPromptAsync(
                "Configuration process canceled.",
                PromptOptions.ErrorConfirm with { Title = Title },
                cancellationToken);

            return;
        }

        // Show a confirmation prompt with an alert icon and title.
        await shell.ShowPromptAsync(
            "Configuration completed successfully! Thank you for using the Configuration Assistant.",
            PromptOptions.AlertConfirm with { Title = Title },
            cancellationToken);

        const string feedbackPrompt = "Everything looks great!";

        // Show a prompt that accepts string input from the user, with a default value, custom title and custom icon.
        string? feedback = await shell.ShowPromptAsync(
            $"Thank you for configuring {projectName}. Do you have any feedback?",
            new InputPromptOptions
            {
                DefaultText = feedbackPrompt,
                Icon = ImageMoniker.KnownValues.Feedback,
                Title = Title,
            },
            cancellationToken);

        this.logger.TraceInformation($"Feedback received: {feedback}");
    }
}

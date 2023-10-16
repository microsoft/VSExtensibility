// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;
using Microsoft.VisualStudio.RpcContracts.ProgressReporting;

/// <summary>
/// A command to execute linter on all markdown files in a solution.
/// </summary>
/// <remarks>
/// This command utilizes <see cref="CommandEnabledWhenAttribute"/> to describe when commmand state is enabled.
/// </remarks>
[VisualStudioContribution]
internal class RunLinterOnSolutionCommand : Command
{
    private readonly TraceSource logger;

#pragma warning disable CA2213 // This is an extension scoped service.
    private readonly MarkdownDiagnosticsService diagnosticsProvider;
#pragma warning restore CA2213

    /// <summary>
    /// Initializes a new instance of the <see cref="RunLinterOnSolutionCommand"/> class.
    /// </summary>
    /// <param name="traceSource">Logger instance that can be used to log extension actions.</param>
    /// <param name="diagnosticsProvider">Local diagnostics provider service instance.</param>
    public RunLinterOnSolutionCommand(TraceSource traceSource, MarkdownDiagnosticsService diagnosticsProvider)
    {
        this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        this.diagnosticsProvider = Requires.NotNull(diagnosticsProvider, nameof(diagnosticsProvider));

        this.logger.TraceEvent(TraceEventType.Information, 0, $"Initializing {nameof(RunLinterOnSolutionCommand)} instance.");
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%MarkdownLinter.RunLinterOnSolutionCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu() },
        Icon = new(ImageMoniker.Custom("MarkdownIcon"), IconSettings.IconAndText),
        EnabledWhen = ActivationConstraint.SolutionState(SolutionState.FullyLoaded),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        try
        {
            var markdownFiles = await this.Extensibility.Workspaces().QueryProjectsAsync(
                query => query.Get(project => project.Files).With(file => file.Path).Where(file => file.Extension == ".md"),
                cancellationToken);

            List<Uri> filesToProcess = new List<Uri>(markdownFiles.Select(f => new Uri(f.Path)));
            if (filesToProcess.Count == 0)
            {
                return;
            }

            if (await this.Extensibility.Shell().ShowPromptAsync(
                string.Format(Strings.Culture, Strings.MarkdownSolutionAnalysisPrompt, filesToProcess.Count),
                PromptOptions.OKCancel,
                cancellationToken))
            {
                await this.ProcessFilesAsync(filesToProcess, cancellationToken);
            }
        }
        catch (InvalidOperationException ex)
        {
            this.logger.TraceEvent(TraceEventType.Error, 0, ex.ToString());
        }
    }

    private static ProgressStatus CreateProgressStatus(int current, int max)
    {
        return new ProgressStatus((int)((current / (double)max) * 100));
    }

    private async System.Threading.Tasks.Task<ProgressReporter> ProcessFilesAsync(List<Uri> filesToProcess, CancellationToken cancellationToken)
    {
        using ProgressReporter progress = await this.Extensibility.Shell().StartProgressReportingAsync(
            Strings.MarkdownAnalysisMessage,
            new ProgressReporterOptions(isWorkCancellable: true),
            cancellationToken);

        for (int i = 0; i < filesToProcess.Count; i++)
        {
            progress.CancellationToken.ThrowIfCancellationRequested();
            progress.Report(CreateProgressStatus(i, filesToProcess.Count));

            // Adding an artificial delay for demonstration purposes.
            await Task.Delay(2000);
            await this.diagnosticsProvider.ProcessFileAsync(filesToProcess[i], cancellationToken);
        }

        return progress;
    }
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample
{
    using System.Diagnostics;
    using System.Text;
    using Microsoft;
    using Microsoft.VisualStudio.Extensibility;
    using Microsoft.VisualStudio.Extensibility.Commands;
    using Microsoft.VisualStudio.Extensibility.Shell;
    using Microsoft.VisualStudio.ProjectSystem.Query;

    /// <summary>
    /// ShowActiveProjectCommand handler.
    /// </summary>
    [VisualStudioContribution]
    internal class ShowActiveProjectCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowActiveProjectCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public ShowActiveProjectCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.ShowActiveProjectCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%VSProjectQueryAPISample.Command1.DisplayName%" as a constructor parameter.
            Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
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
            var activeProject = await context.GetActiveProjectAsync(cancellationToken);
            if (activeProject == null)
            {
                await this.Extensibility.Shell().ShowPromptAsync("There is no active project defined.", PromptOptions.OK, cancellationToken);
            }
            else
            {
                var newResult = await activeProject.AsQueryable()
                    .With(p => p.Name)
                    .With(p => p.Path)
                    .ExecuteQueryAsync();

                var displayMessageSb = new StringBuilder();
                displayMessageSb.AppendLine("The name of the current active project is: " + newResult.First().Name);
                displayMessageSb.AppendLine("The path of the current active project is: " + newResult.First().Path);

                await this.Extensibility.Shell().ShowPromptAsync(displayMessageSb.ToString(), PromptOptions.OK, cancellationToken);
            }
        }
    }
}

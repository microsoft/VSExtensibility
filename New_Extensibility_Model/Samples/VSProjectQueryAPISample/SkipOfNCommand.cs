// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Text;
    using Microsoft;
    using Microsoft.VisualStudio.Extensibility;
    using Microsoft.VisualStudio.Extensibility.Commands;
    using Microsoft.VisualStudio.Extensibility.Shell;
    using Microsoft.VisualStudio.ProjectSystem.Query;

    /// <summary>
    /// SkipOfNCommand handler.
    /// </summary>
    [VisualStudioContribution]
    internal class SkipOfNCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipOfNCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public SkipOfNCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.SkipOfNCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%VSProjectQueryAPISample.SkipOfNCommand.DisplayName%" as a constructor parameter.
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
            WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();

            var result = await querySpace.QueryProjectsAsync(
                        project => project.With(p => p.Name)
                        .Skip(1),
                        cancellationToken);

            StringBuilder message = new StringBuilder($"\n \n === Skipping one === \n");

            foreach (var project in result)
            {
                _ = message.Append(CultureInfo.CurrentCulture, $"{project.Name}\n");
            }

            await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
        }
    }
}

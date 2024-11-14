// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample
{
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft;
    using Microsoft.VisualStudio.Extensibility;
    using Microsoft.VisualStudio.Extensibility.Commands;
    using Microsoft.VisualStudio.Extensibility.Shell;
    using Microsoft.VisualStudio.ProjectSystem.Query;

    /// <summary>
    /// RenameFile handler.
    /// </summary>
    [VisualStudioContribution]
    internal class RenameFileCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameFileCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public RenameFileCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.RenameFileCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%VSProjectQueryAPISample.RenameFile.DisplayName%" as a constructor parameter.
            Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
        };

        /// <inheritdoc />
        public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
        {
            WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();
            StringBuilder sb = new StringBuilder("Renamed file at ");

            IQueryResults<IProjectSnapshot> consoleApp1QueryResults = await querySpace.QueryProjectsAsync(
                    project => project.Where(p => p.Name == "ConsoleApp1")
                    .With(project => project.Files
                    .With(f => f.FileName)
                    .With(f => f.Path)),
                    cancellationToken);

            var filePath = consoleApp1QueryResults.First().Files.First().Path;
            sb.Append(filePath);

            await querySpace.UpdateProjectsAsync(
                project => project.Where(project => project.Name == "ConsoleApp1"),
                project => project.RenameFile(filePath, "newName.cs"),
                cancellationToken);

            sb.Append(" to newName.cs");

            await this.Extensibility.Shell().ShowPromptAsync(sb.ToString(), PromptOptions.OK, cancellationToken);
        }
    }
}

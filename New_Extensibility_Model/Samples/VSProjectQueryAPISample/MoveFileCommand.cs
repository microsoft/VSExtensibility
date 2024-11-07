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
    /// MoveFile handler.
    /// </summary>
    [VisualStudioContribution]
    internal class MoveFileCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public MoveFileCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.MoveFileCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%VSProjectQueryAPISample.MoveFile.DisplayName%" as a constructor parameter.
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
            // Move File Workaround
            WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();
            StringBuilder sb = new StringBuilder("Move file from ");

            // Query the source project to retrieve the path of the file to be moved.
            IQueryResults<IProjectSnapshot> consoleApp1QueryResults = await querySpace.QueryProjectsAsync(
                    project => project.Where(p => p.Name == "ConsoleApp1")
                    .With(project => project.Path)
                    .With(project => project.Files
                    .With(f => f.FileName)
                    .With(f => f.Path)),
                    cancellationToken);

            var sourceFilePath = consoleApp1QueryResults.First().Files.First().Path;
            sb.Append(sourceFilePath + " to ");

            // Query the destination project to retrieve its path.
            IQueryResults<IProjectSnapshot> destinationFilePaths = await querySpace.QueryProjectsAsync(
                project => project.Where(p => p.Name == "ConsoleApp2")
                .With(project => project.Path),
                cancellationToken);

            var destinationProject = Directory.GetParent(destinationFilePaths.First().Path!)!.ToString();

            sb.Append(destinationProject);

            // Add the source file to the destination project.
            await querySpace.UpdateProjectsAsync(
                project => project.Where(project => project.Name == "ConsoleApp2"),
                project => project.AddFileFromCopy(sourceFilePath, destinationProject),
                cancellationToken);

            // Query the source project to retrieve the file to be deleted.
            IQueryResults<IProjectSnapshot> sourceFileQueryResults = await querySpace.QueryProjectsAsync(
                project => project
                .Where(project => project.Name == "ConsoleApp1")
                .With(project => project.Files
                .Where(file => file.Path == sourceFilePath)
                .With(file => file.FileName)),
                cancellationToken);

            IAsyncQueryable<IFileSnapshot> file = sourceFileQueryResults.First().Files;

            // Action query to delete the source file from the source project.
            await file.AsUpdatable().Delete().ExecuteAsync();

            await this.Extensibility.Shell().ShowPromptAsync(sb.ToString(), PromptOptions.OK, cancellationToken);
        }
    }
}

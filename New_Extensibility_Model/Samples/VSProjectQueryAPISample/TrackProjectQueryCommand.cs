// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample
{
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft;
    using Microsoft.VisualStudio.Extensibility;
    using Microsoft.VisualStudio.Extensibility.Commands;
    using Microsoft.VisualStudio.ProjectSystem.Query;

    /// <summary>
    /// TrackProjectQueryCommand handler.
    /// </summary>
    [VisualStudioContribution]
    internal class TrackProjectQueryCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackProjectQueryCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public TrackProjectQueryCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.TrackProjectQueryCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%VSProjectQueryAPISample.TrackProjectQueryCommand.DisplayName%" as a constructor parameter.
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
            WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();

            var projects = await querySpace.QueryProjectsAsync(
                project => project.With(project => project.Name),
                cancellationToken);

            var singleProject = projects.FirstOrDefault();

            if (singleProject is null)
            {
                return;
            }

#pragma warning disable VSEXTPREVIEW_PROJECTQUERY_TRACKING
            var unsubscriber = await singleProject
                .Files
                .With(f => f.FileName)
                .TrackUpdatesAsync(new TrackerObserver(), CancellationToken.None);
#pragma warning restore VSEXTPREVIEW_PROJECTQUERY_TRACKING

        }

#pragma warning disable VSEXTPREVIEW_PROJECTQUERY_TRACKING
        private class TrackerObserver : IObserver<IQueryTrackUpdates<IFileSnapshot>>
#pragma warning restore VSEXTPREVIEW_PROJECTQUERY_TRACKING
        {
            public void OnCompleted()
            {
                // no -op;
            }

            public void OnError(Exception error)
            {
                // no -op;
            }

#pragma warning disable VSEXTPREVIEW_PROJECTQUERY_TRACKING
            public void OnNext(IQueryTrackUpdates<IFileSnapshot> value)
#pragma warning restore VSEXTPREVIEW_PROJECTQUERY_TRACKING
            {
                // no - op
            }

            public override int GetHashCode()
            {
                return -2022;
            }
        }
    }
}

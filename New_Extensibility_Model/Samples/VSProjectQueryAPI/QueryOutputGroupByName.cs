using Microsoft.VisualStudio.ProjectSystem.Query;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;

namespace ProjectQueryAPISample {
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class QueryOutputGroupByName {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 4130;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("0d5d40cd-a6d9-4389-a18a-0326601107ad");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOutputGroupByName"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private QueryOutputGroupByName(AsyncPackage package, OleMenuCommandService commandService) {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static QueryOutputGroupByName Instance {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider {
            get {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package) {
            // Switch to the main thread - the call to AddCommand in QueryOutputGroupByName's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new QueryOutputGroupByName(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e) {
            ThreadHelper.ThrowIfNotOnUIThread();
            StringBuilder message = new StringBuilder();
            ThreadHelper.JoinableTaskFactory.Run(async () => {
                var queryService = await this.package.GetServiceAsync<IProjectSystemQueryService, IProjectSystemQueryService>();
                var querySpace = queryService.QueryableSpace;

                //// Querying Output Groups
                var result = querySpace.Projects
                    .With(p => p.Name)
                    .With(p => p.ActiveConfigurations
                        .With(c => c.Name)
                        .With(c => c.OutputGroupsByName("Built", "XmlSerializer", "SourceFiles", "RandomNameShouldntBePickedUp")
                        .With(g => g.Name)))
                    .QueryAsync(CancellationToken.None);

                message.Append($"\n \n === Querying by Name === \n");

                await foreach (var project in result) 
                {
                    message.Append($"{project.Value.Name}\n");

                    foreach (var config in project.Value.ActiveConfigurations) 
                    {
                        message.Append($" \t {config.Name}\n");

                        foreach (var group in config.OutputGroups) 
                        {
                            message.Append($"\t \t {group.Name}\n");
                        }
                    }
                }

                MessageBox.Show(message.ToString());
            });
        }
    }
}

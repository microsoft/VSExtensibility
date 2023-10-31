namespace RustLanguageServerProviderExtension
{
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Editor;
	using Microsoft.VisualStudio.Extensibility.LanguageServer;
	using Microsoft.VisualStudio.RpcContracts.LanguageServerProvider;
	using Nerdbank.Streams;
	using System.Diagnostics;
	using System.IO.Pipelines;
	using System.Reflection;

	[VisualStudioContribution]
	internal class RustLanguageServerProvider : LanguageServerProvider
	{
		public RustLanguageServerProvider(ExtensionCore container, VisualStudioExtensibility extensibilityObject)
			: base(container, extensibilityObject)
		{
		}

		[VisualStudioContribution]
		public static DocumentTypeConfiguration RustDocumentType => new("rust")
		{
			FileExtensions = new[] { ".rs", ".rust" },
			BaseDocumentType = LanguageServerBaseDocumentType,
		};

		/// <inheritdoc/>
		public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration => new(
			"%RustLspExtension.RustLanguageServerProvider.DisplayName%",
			new[]
			{
				DocumentFilter.FromDocumentType(RustDocumentType),
			});

		/// <inheritdoc/>
		public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
		{
			ProcessStartInfo info = new ProcessStartInfo();
			info.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, @"rust-analyzer.exe");
			info.RedirectStandardInput = true;
			info.RedirectStandardOutput = true;
			info.UseShellExecute = false;
			info.CreateNoWindow = true;

			Process process = new Process();
			process.StartInfo = info;

			if (process.Start())
			{
				return Task.FromResult<IDuplexPipe?>(new DuplexPipe(
					PipeReader.Create(process.StandardOutput.BaseStream),
					PipeWriter.Create(process.StandardInput.BaseStream)));
			}

			return Task.FromResult<IDuplexPipe?>(null);
		}

		/// <inheritdoc/>
		public override Task OnServerInitializationResultAsync(ServerInitializationResult serverInitializationResult, LanguageServerInitializationFailureInfo? initializationFailureInfo, CancellationToken cancellationToken)
		{
			if (serverInitializationResult == ServerInitializationResult.Failed)
			{
				// Log telemetry for failure and disable the server from being activated again.
				this.Enabled = false;
			}

			return base.OnServerInitializationResultAsync(serverInitializationResult, initializationFailureInfo, cancellationToken);
		}
	}
}

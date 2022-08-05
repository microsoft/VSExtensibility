// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Extensions.MarkdownLinter
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;
	using Microsoft.VisualStudio.RpcContracts.DiagnosticManagement;
	using Microsoft.VisualStudio.Threading;

	/// <summary>
	/// Helper class for running linter on a string or file.
	/// </summary>
	internal static class LinterUtilities
	{
		private static Regex linterOutputRegex = new Regex(@"(?<File>[^:]+):(?<Line>\d*)(:(?<Column>\d*))? (?<Error>.*)/(?<Description>.*)", RegexOptions.Compiled);

		/// <summary>
		/// Runs markdown linter on a file path and returns diagnostic entries.
		/// </summary>
		/// <param name="filePath">File path to run markdown linter on.</param>
		/// <returns>an enumeration of <see cref="Diagnostic"/> entries for warnings in the markdown file.</returns>
		public static async Task<IEnumerable<Diagnostic>> RunLinterOnFileAsync(string filePath)
		{
			using var linter = new Process();
			var lineQueue = new AsyncQueue<string>();

			linter.StartInfo = new ProcessStartInfo()
			{
				FileName = "node.exe",
				Arguments = $"\"{Environment.ExpandEnvironmentVariables("%APPDATA%\\npm\\node_modules\\markdownlint-cli\\markdownlint.js")}\" \"{filePath}\"",
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true,
			};

			linter.EnableRaisingEvents = true;
			linter.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
			{
				if (e.Data is object)
				{
					lineQueue.Enqueue(e.Data);
				}
				else
				{
					lineQueue.Complete();
				}
			});

			try
			{
				linter.Start();
				linter.BeginErrorReadLine();
			}
			catch (Win32Exception ex)
			{
				throw new InvalidOperationException(message: ex.Message, innerException: ex);
			}

			return await ProcessLinterQueueAsync(lineQueue);
		}

		/// <summary>
		/// Runs markdown linter on a given text and returns diagnostic entries.
		/// </summary>
		/// <param name="content">Content to run markdown linter on.</param>
		/// <returns>an enumeration of <see cref="Diagnostic"/> entries for warnings in the markdown file.</returns>
		public static async Task<IEnumerable<Diagnostic>> RunLinterOnTextAsync(string content)
		{
			using var linter = new Process();
			var lineQueue = new AsyncQueue<string>();

			linter.StartInfo = new ProcessStartInfo()
			{
				FileName = "cmd.exe",
				Arguments = $"/k \"{Environment.ExpandEnvironmentVariables("%APPDATA%\\npm\\markdownlint.cmd")}\" -s",
				RedirectStandardError = true,
				RedirectStandardInput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
			};

			linter.EnableRaisingEvents = true;
			linter.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
			{
				if (e.Data is object)
				{
					lineQueue.Enqueue(e.Data);
				}
				else
				{
					lineQueue.Complete();
				}
			});

			try
			{
				linter.Start();
				linter.BeginErrorReadLine();
				linter.StandardInput.AutoFlush = true;
				await linter.StandardInput.WriteAsync(content);
				linter.StandardInput.Close();
			}
			catch (Win32Exception ex)
			{
				throw new InvalidOperationException(message: ex.Message, innerException: ex);
			}

			return await ProcessLinterQueueAsync(lineQueue);
		}

		private static async Task<IEnumerable<Diagnostic>> ProcessLinterQueueAsync(AsyncQueue<string> lineQueue)
		{
			Requires.NotNull(lineQueue, nameof(lineQueue));

			List<Diagnostic> diagnostics = new List<Diagnostic>();

			while (!(lineQueue.IsCompleted && lineQueue.IsEmpty))
			{
				string? line = null;
				try
				{
					line = await lineQueue.DequeueAsync();
				}
				catch (OperationCanceledException)
				{
					break;
				}

				var diagnostic = line is object ? GetDiagnosticFromLinterOutput(line) : null;
				if (diagnostic is object)
				{
					diagnostics.Add(diagnostic);
				}
				else
				{
					// Something went wrong so break and return the current set.
					break;
				}
			}

			return diagnostics;
		}

		private static Diagnostic? GetDiagnosticFromLinterOutput(string outputLine)
		{
			Requires.NotNull(outputLine, nameof(outputLine));
			var match = linterOutputRegex.Match(outputLine);
			if (!match.Success)
			{
				return null;
			}

			int line = int.Parse(match.Groups["Line"].Value, CultureInfo.InvariantCulture) - 1;
			int column = match.Groups.ContainsKey("Column") && !string.IsNullOrEmpty(match.Groups["Column"].Value) ? (int.Parse(match.Groups["Column"].Value, CultureInfo.InvariantCulture) - 1) : -1;

			string error = match.Groups["Error"].Value;

			return new Diagnostic(
				message: match.Groups["Description"].Value,
				code: match.Groups["Error"].Value,
				DiagnosticSeverity.Warning,
				range: new RpcContracts.Utilities.Range(startLine: line, startColumn: column));
		}
	}
}

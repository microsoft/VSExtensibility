// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Languages;
using Microsoft.VisualStudio.RpcContracts;
using Microsoft.VisualStudio.RpcContracts.DiagnosticManagement;
using Microsoft.VisualStudio.Threading;

/// <summary>
/// Helper class for running linter on a string or file.
/// </summary>
internal static class LinterUtilities
{
    private static Regex linterOutputRegex = new Regex(@"(?<File>[^:]+):(?<Line>\d*)(:(?<Column>\d*))? (?<Error>.*)/(?<Description>.*)", RegexOptions.Compiled);

    /// <summary>
    /// Runs markdown linter on a file uri and returns diagnostic entries.
    /// </summary>
    /// <param name="fileUri">File uri to run markdown linter on.</param>
    /// <returns>an enumeration of <see cref="DocumentDiagnostic"/> entries for warnings in the markdown file.</returns>
    public static async Task<IEnumerable<DocumentDiagnostic>> RunLinterOnFileAsync(Uri fileUri)
    {
        using var linter = new Process();
        var lineQueue = new AsyncQueue<string>();

        linter.StartInfo = new ProcessStartInfo()
        {
            FileName = "node.exe",
            Arguments = $"\"{Environment.ExpandEnvironmentVariables("%APPDATA%\\npm\\node_modules\\markdownlint-cli\\markdownlint.js")}\" \"{fileUri.LocalPath}\"",
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

        var markdownDiagnostics = await ProcessLinterQueueAsync(lineQueue);
        return CreateDocumentDiagnosticsForClosedDocument(fileUri, markdownDiagnostics);
    }

    /// <summary>
    /// Runs markdown linter on a given text document and returns diagnostic entries.
    /// </summary>
    /// <param name="textDocument">Document to run markdown linter on.</param>
    /// <returns>an enumeration of <see cref="DocumentDiagnostic"/> entries for warnings in the markdown file.</returns>
    public static async Task<IEnumerable<DocumentDiagnostic>> RunLinterOnDocumentAsync(ITextDocumentSnapshot textDocument)
    {
        using var linter = new Process();
        var lineQueue = new AsyncQueue<string>();

        var content = textDocument.Text.CopyToString();

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

        var markdownDiagnostics = await ProcessLinterQueueAsync(lineQueue);
        return CreateDocumentDiagnosticsForOpenDocument(textDocument, markdownDiagnostics);
    }

    /// <summary>
    /// Checks if the given path is a valid markdown file.
    /// </summary>
    /// <param name="localPath">Local file path to verify.</param>
    /// <returns>true if file is a markdown file, false otherwise.</returns>
    public static bool IsValidMarkdownFile(string localPath)
    {
        return localPath is object && Path.GetExtension(localPath).Equals(".md", StringComparison.OrdinalIgnoreCase);
    }

    private static IEnumerable<DocumentDiagnostic> CreateDocumentDiagnosticsForOpenDocument(ITextDocumentSnapshot document, IEnumerable<MarkdownDiagnosticInfo> diagnostics)
    {
        foreach (var diagnostic in diagnostics)
        {
            var startindex = document.Lines[diagnostic.Range.StartLine].Text.Start.Offset;
            if (diagnostic.Range.StartColumn >= 0)
            {
                startindex += diagnostic.Range.StartColumn;
            }

            var endIndex = document.Lines[diagnostic.Range.EndLine].Text.Start.Offset;
            if (diagnostic.Range.EndColumn >= 0)
            {
                endIndex += diagnostic.Range.EndColumn;
            }

            yield return new DocumentDiagnostic(new TextRange(document, startindex, endIndex - startindex), diagnostic.Message)
            {
                ErrorCode = diagnostic.ErrorCode,
                Severity = DiagnosticSeverity.Warning,
                ProviderName = "Markdown Linter",
            };
        }
    }

    private static IEnumerable<DocumentDiagnostic> CreateDocumentDiagnosticsForClosedDocument(Uri fileUri, IEnumerable<MarkdownDiagnosticInfo> diagnostics)
    {
        foreach (var diagnostic in diagnostics)
        {
            yield return new DocumentDiagnostic(fileUri, diagnostic.Range, diagnostic.Message)
            {
                ErrorCode = diagnostic.ErrorCode,
                Severity = DiagnosticSeverity.Warning,
                ProviderName = "Markdown Linter",
            };
        }
    }

    private static async Task<IEnumerable<MarkdownDiagnosticInfo>> ProcessLinterQueueAsync(AsyncQueue<string> lineQueue)
    {
        Requires.NotNull(lineQueue, nameof(lineQueue));

        List<MarkdownDiagnosticInfo> diagnostics = new List<MarkdownDiagnosticInfo>();

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

    private static MarkdownDiagnosticInfo? GetDiagnosticFromLinterOutput(string outputLine)
    {
        Requires.NotNull(outputLine, nameof(outputLine));
        var match = linterOutputRegex.Match(outputLine);
        if (!match.Success)
        {
            return null;
        }

        int line = int.Parse(match.Groups["Line"].Value, CultureInfo.InvariantCulture) - 1;
        int column = match.Groups.ContainsKey("Column") && !string.IsNullOrEmpty(match.Groups["Column"].Value) ? (int.Parse(match.Groups["Column"].Value, CultureInfo.InvariantCulture) - 1) : -1;

        return new MarkdownDiagnosticInfo(
            range: new Microsoft.VisualStudio.RpcContracts.Utilities.Range(startLine: line, startColumn: column),
            message: match.Groups["Description"].Value,
            errorCode: match.Groups["Error"].Value);
    }
}

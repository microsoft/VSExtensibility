// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Extensions.MarkdownLinter
{
	using Microsoft.VisualStudio.Extensibility.Languages;

	using Range = Microsoft.VisualStudio.RpcContracts.Utilities.Range;

	/// <summary>
	/// Class that contains diagnostic information found by the Markdown linter.
	/// Holds information to be converted to a <see cref="DocumentDiagnostic"/>.
	/// </summary>
	public class MarkdownDiagnosticInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MarkdownDiagnosticInfo"/> class.
		/// </summary>
		/// <param name="range">Range where the diagnostic exists.</param>
		/// <param name="message">Message to be presented with the diagnostic.</param>
		/// <param name="errorCode">Unique error code of this type of diagnostic.</param>
		public MarkdownDiagnosticInfo(Range range, string message, string errorCode)
		{
			this.Range = range;
			this.Message = message;
			this.ErrorCode = errorCode;
		}

		/// <summary>
		/// Gets the range of the diagnostic.
		/// </summary>
		public Range Range { get; }

		/// <summary>
		/// Gets the error message of the diagnostic.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Gets the error code of the diagnostic.
		/// </summary>
		public string ErrorCode { get; }
	}
}

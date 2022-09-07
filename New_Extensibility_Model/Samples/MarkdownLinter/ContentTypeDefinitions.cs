// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.VisualStudio.Extensibility.Editor;

[assembly: DocumentTypeDefinition("markdown")]
[assembly: DocumentTypeBaseDefinition("markdown", baseDocumentTypeName: "code++")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".md")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".mdk")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".markdown")]

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson;

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using ReadVsixToJson.Models;

public class VsixManifestReader
{
    private VsixManifestModel? model;

    public VsixManifestModel Read(string vsixPath)
    {
        try
        {
            using ZipPackage? package = ZipPackage.Open(vsixPath, FileMode.Open, FileAccess.Read) as ZipPackage;
            if (package != null)
            {
                PackagePart extensionManifestPart = package.GetPart(new Uri("/extension.vsixmanifest", UriKind.Relative));
                using Stream vsixManifestStream = extensionManifestPart.GetStream();

                XDocument vsixTree = XDocument.Load(vsixManifestStream, LoadOptions.None);

                XNamespace nameSpace = "http://schemas.microsoft.com/developer/vsx-schema/2011";

                XElement identityElement = vsixTree.Descendants(nameSpace + "Identity").First();

                this.model = new VsixManifestModel();

                if (identityElement != null)
                {
                    XAttribute publisherAttribute = identityElement.Attribute("Publisher")
                        ?? throw new ArgumentException("Publisher was not found inside the VsixManifest.");
                    string publisher = publisherAttribute.Value;

                    this.model.Publisher = publisher;
                }

                Identity identity = new Identity();
                identity.InternalName = (string?)vsixTree.Descendants(nameSpace + "DisplayName").First();
                this.model.Identity = identity;
            }

            return this.model!;
        }
        catch (FileNotFoundException ex)
        {
            throw new ArgumentException($"VsixTargetContainer was not found. Verify your extension has been built and try again.\n" +
                $"Error: {ex.ToString}");
        }
    }
}

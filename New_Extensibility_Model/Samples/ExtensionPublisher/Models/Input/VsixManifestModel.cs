// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson.Models;

public class VsixManifestModel
{
    public Identity? Identity { get; set; }

    public string? Publisher { get; set; }
}

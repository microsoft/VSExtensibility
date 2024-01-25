// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson.Models;
using System.Collections.Generic;

public class ReadVsixToJsonRequest
{
    public string? PathToVsix { get; set; }

    public string? PathToPublishManifest { get; set; }

    public List<string>? Categories { get; set; }

    public string? Schema { get; set; } = "http://json.schemastore.org/vsix-publish";

    public string? Overview { get; set; }

    public string? PriceCategory { get; set; }

    public bool Private { get; set; }

    public bool Qna { get; set; }

    public string? Repo { get; set; }

    // PAT
    public string? PersonalAccessToken { get; set; }
}

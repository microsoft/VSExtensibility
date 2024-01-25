// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson.Models;

using System.Collections.Generic;
using Newtonsoft.Json;

public class PublishManifestModel
{
    public PublishManifestModel()
    {
    }

    public PublishManifestModel(ReadVsixToJsonRequest request, VsixManifestModel vsixManifestModel)
    {
        this.Identity = vsixManifestModel.Identity;
        this.Publisher = vsixManifestModel.Publisher;
        this.Schema = request.Schema;
        this.PriceCategory = request.PriceCategory;
        this.Categories = request.Categories;
        this.Private = request.Private;
        this.Qna = request.Qna;
        this.Repo = request.Repo;
        this.Overview = request.Overview;
    }

    [JsonProperty("$schema")]
    public string? Schema { get; set; }

    [JsonProperty("priceCategory")]
    public string? PriceCategory { get; set; }

    [JsonProperty("categories")]
    public List<string>? Categories { get; set; }

    [JsonProperty("private")]
    public bool? Private { get; set; }

    [JsonProperty("qna")]
    public bool? Qna { get; set; }

    [JsonProperty("repo")]
    public string? Repo { get; set; }

    [JsonProperty("identity")]
    public Identity? Identity { get; set; }

    [JsonProperty("publisher")]
    public string? Publisher { get; set; }

    [JsonProperty("overview")]
    public string? Overview { get; set; }
}

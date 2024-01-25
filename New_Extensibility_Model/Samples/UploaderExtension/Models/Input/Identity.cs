// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReadVsixToJson.Models;
using Newtonsoft.Json;

public class Identity
{
    [JsonProperty("internalName")]
    public string? InternalName { get; set; }
}

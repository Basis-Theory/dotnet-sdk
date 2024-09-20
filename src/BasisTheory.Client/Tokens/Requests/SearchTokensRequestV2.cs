using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record SearchTokensRequestV2
{
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

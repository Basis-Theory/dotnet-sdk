using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record SearchTokensRequest
{
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

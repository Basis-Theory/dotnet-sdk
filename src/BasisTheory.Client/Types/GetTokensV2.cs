using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record GetTokensV2
{
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsCardholderAuthenticationInfo
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("data")]
    public string? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

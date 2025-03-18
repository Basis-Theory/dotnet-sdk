using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record PaymentData
{
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("header")]
    public Header? Header { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

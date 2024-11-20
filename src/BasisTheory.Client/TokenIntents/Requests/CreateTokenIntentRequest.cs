using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CreateTokenIntentRequest
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("data")]
    public required object Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

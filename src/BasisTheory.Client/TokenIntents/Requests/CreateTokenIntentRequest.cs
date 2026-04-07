using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record CreateTokenIntentRequest
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("data")]
    public required object Data { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

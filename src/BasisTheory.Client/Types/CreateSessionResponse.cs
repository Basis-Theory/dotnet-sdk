using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateSessionResponse
{
    [JsonPropertyName("session_key")]
    public string? SessionKey { get; set; }

    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

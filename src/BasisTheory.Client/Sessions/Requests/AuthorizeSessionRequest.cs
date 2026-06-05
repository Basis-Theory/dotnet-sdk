using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record AuthorizeSessionRequest
{
    [JsonPropertyName("nonce")]
    public required string Nonce { get; set; }

    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    [JsonPropertyName("permissions")]
    public IEnumerable<string>? Permissions { get; set; }

    [JsonPropertyName("rules")]
    public IEnumerable<AccessRule>? Rules { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record UpdateTokenRequest
{
    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("privacy")]
    public UpdatePrivacy? Privacy { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("search_indexes")]
    public IEnumerable<string>? SearchIndexes { get; set; }

    [JsonPropertyName("fingerprint_expression")]
    public string? FingerprintExpression { get; set; }

    [JsonPropertyName("mask")]
    public object? Mask { get; set; }

    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    [JsonPropertyName("deduplicate_token")]
    public bool? DeduplicateToken { get; set; }

    [JsonPropertyName("containers")]
    public IEnumerable<string>? Containers { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

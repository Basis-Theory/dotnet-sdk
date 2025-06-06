using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateTokenRequest
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    [JsonPropertyName("privacy")]
    public Privacy? Privacy { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, string?>? Metadata { get; set; }

    [JsonPropertyName("search_indexes")]
    public IEnumerable<string>? SearchIndexes { get; set; }

    [JsonPropertyName("fingerprint_expression")]
    public string? FingerprintExpression { get; set; }

    [JsonPropertyName("mask")]
    public object? Mask { get; set; }

    [JsonPropertyName("deduplicate_token")]
    public bool? DeduplicateToken { get; set; }

    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    [JsonPropertyName("containers")]
    public IEnumerable<string>? Containers { get; set; }

    [JsonPropertyName("token_intent_id")]
    public string? TokenIntentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

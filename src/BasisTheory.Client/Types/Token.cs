using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record Token
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, string?>? Metadata { get; set; }

    [JsonPropertyName("enrichments")]
    public TokenEnrichments? Enrichments { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("card")]
    public CardDetails? Card { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    [JsonPropertyName("fingerprint_expression")]
    public string? FingerprintExpression { get; set; }

    [JsonPropertyName("mask")]
    public object? Mask { get; set; }

    [JsonPropertyName("privacy")]
    public Privacy? Privacy { get; set; }

    [JsonPropertyName("search_indexes")]
    public IEnumerable<string>? SearchIndexes { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("containers")]
    public IEnumerable<string>? Containers { get; set; }

    [JsonPropertyName("aliases")]
    public IEnumerable<string>? Aliases { get; set; }

    [JsonPropertyName("authentication")]
    public TokenAuthentication? Authentication { get; set; }

    [JsonPropertyName("_extras")]
    public TokenExtras? Extras { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CreateTokenIntentResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("card")]
    public CardDetails? Card { get; set; }

    [JsonPropertyName("authentication")]
    public TokenAuthentication? Authentication { get; set; }

    [JsonPropertyName("_extras")]
    public TokenIntentExtras? Extras { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

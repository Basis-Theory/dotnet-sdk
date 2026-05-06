using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.AccountUpdater;

[Serializable]
public record AccountUpdaterRealTimeRequest
{
    /// <summary>
    /// Card Token identifier
    /// </summary>
    [JsonPropertyName("token_id")]
    public required string TokenId { get; set; }

    /// <summary>
    /// The 4-digit expiration year of the account number. Not required if the card token already stores this value.
    /// </summary>
    [JsonPropertyName("expiration_year")]
    public int? ExpirationYear { get; set; }

    /// <summary>
    /// The 2-digit expiration month of the account number. Not required if the card token already stores this value.
    /// </summary>
    [JsonPropertyName("expiration_month")]
    public int? ExpirationMonth { get; set; }

    /// <summary>
    /// Whether deduplication should be enabled when creating the new token. Uses the value of the Deduplicate Tokens setting on the tenant if not set.
    /// </summary>
    [JsonPropertyName("deduplicate_token")]
    public bool? DeduplicateToken { get; set; }

    /// <summary>
    /// Tenant merchant identifier
    /// </summary>
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

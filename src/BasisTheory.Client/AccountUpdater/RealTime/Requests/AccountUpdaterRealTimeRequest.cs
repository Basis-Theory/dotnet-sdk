using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.AccountUpdater;

[Serializable]
public record AccountUpdaterRealTimeRequest
{
    /// <summary>
    /// Tenant merchant the request acts as. The card token is read within this merchant's scope and the updated token is associated with it. Responds 404 if the merchant does not exist in the tenant.
    /// </summary>
    [JsonIgnore]
    public string? BtMerchantId { get; set; }

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
    /// Tenant merchant whose provider configuration is used for this request. Selects configuration only; it does not scope token access or associate the new token with the merchant. Takes precedence over merchant_id; defaults to the BT-MERCHANT-ID header merchant, then the tenant-level configuration.
    /// </summary>
    [JsonPropertyName("configuration_merchant_id")]
    public string? ConfigurationMerchantId { get; set; }

    /// <summary>
    /// Deprecated: use configuration_merchant_id instead. Legacy alias kept for backward compatibility with lower precedence. Selects configuration only.
    /// </summary>
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

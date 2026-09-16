using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.AccountUpdater;

[Serializable]
public record CreateAccountUpdaterJobRequest
{
    /// <summary>
    /// Tenant merchant the job acts as. Tokens in the file are read within this merchant's scope and new tokens are associated with it. Responds 404 if the merchant does not exist in the tenant.
    /// </summary>
    [JsonIgnore]
    public string? BtMerchantId { get; set; }

    /// <summary>
    /// Whether deduplication should be enabled when creating new tokens. Uses the value of the Deduplicate Tokens setting on the tenant if not set.
    /// </summary>
    [JsonPropertyName("deduplicate_tokens")]
    public bool? DeduplicateTokens { get; set; }

    /// <summary>
    /// Tenant merchant whose provider configuration is used for this job. Selects configuration only; it does not scope token access or associate tokens with the merchant. Takes precedence over merchant_id; defaults to the BT-MERCHANT-ID header merchant, then the tenant-level configuration.
    /// </summary>
    [JsonPropertyName("configuration_merchant_id")]
    public string? ConfigurationMerchantId { get; set; }

    /// <summary>
    /// Deprecated: use configuration_merchant_id instead. Legacy alias kept for backward compatibility with lower precedence. Selects configuration only.
    /// </summary>
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    /// <summary>
    /// Version of the result CSV format. Version '1' returns base columns. Version '1.1' adds new_fingerprint and new_brand columns. Version '1.2' adds the new_last4 column on top of 1.1.
    /// </summary>
    [JsonPropertyName("result_version")]
    public CreateAccountUpdaterJobRequestResultVersion? ResultVersion { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

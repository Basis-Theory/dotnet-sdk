using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.AccountUpdater;

[Serializable]
public record CreateAccountUpdaterJobRequest
{
    /// <summary>
    /// Whether deduplication should be enabled when creating new tokens. Uses the value of the Deduplicate Tokens setting on the tenant if not set.
    /// </summary>
    [JsonPropertyName("deduplicate_tokens")]
    public bool? DeduplicateTokens { get; set; }

    /// <summary>
    /// Tenant merchant identifier
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

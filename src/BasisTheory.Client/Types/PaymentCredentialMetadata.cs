using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Credential metadata. Never contains card numbers, SPT values, or MPP payloads.
/// </summary>
[Serializable]
public record PaymentCredentialMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("allowance_id")]
    public required string AllowanceId { get; set; }

    [JsonPropertyName("payment_method_id")]
    public required string PaymentMethodId { get; set; }

    [JsonPropertyName("rail")]
    public required string Rail { get; set; }

    [JsonPropertyName("provider")]
    public required PaymentCredentialMetadataProvider Provider { get; set; }

    [JsonPropertyName("format")]
    public required PaymentCredentialMetadataFormat Format { get; set; }

    /// <summary>
    /// Safe provider-native references for support. Never contains a spendable credential.
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public object? ProviderIds { get; set; }

    [JsonPropertyName("amount")]
    public required SharedPaymentAmount Amount { get; set; }

    /// <summary>
    /// Merchant the spend was authorized against, taken from the allowance or from the credential request. Absent on credentials minted before merchant was recorded.
    /// </summary>
    [JsonPropertyName("merchant")]
    public SharedPaymentMerchant? Merchant { get; set; }

    /// <summary>
    /// Credential lifecycle status. Only `created` exists today — the service has no settlement visibility, so a credential is never observed being spent.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = "created";

    [JsonPropertyName("expires_at")]
    public required DateTime ExpiresAt { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

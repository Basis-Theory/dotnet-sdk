using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record ApplePayMerchantCertificates
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("merchant_certificate_expiration_date")]
    public DateTime? MerchantCertificateExpirationDate { get; set; }

    [JsonPropertyName("merchant_certificate_fingerprint")]
    public string? MerchantCertificateFingerprint { get; set; }

    [JsonPropertyName("payment_processor_certificate_expiration_date")]
    public DateTime? PaymentProcessorCertificateExpirationDate { get; set; }

    [JsonPropertyName("payment_processor_certificate_fingerprint")]
    public string? PaymentProcessorCertificateFingerprint { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

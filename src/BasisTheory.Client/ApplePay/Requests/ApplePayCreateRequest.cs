using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record ApplePayCreateRequest
{
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    [JsonPropertyName("apple_payment_data")]
    public ApplePayMethodToken? ApplePaymentData { get; set; }

    [JsonPropertyName("merchant_registration_id")]
    public string? MerchantRegistrationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

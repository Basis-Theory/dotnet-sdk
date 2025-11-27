using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.ApplePay.Merchant;

[Serializable]
public record ApplePayMerchantCertificatesRegisterRequest
{
    [JsonPropertyName("merchant_certificate_data")]
    public string? MerchantCertificateData { get; set; }

    [JsonPropertyName("merchant_certificate_password")]
    public string? MerchantCertificatePassword { get; set; }

    [JsonPropertyName("payment_processor_certificate_data")]
    public string? PaymentProcessorCertificateData { get; set; }

    [JsonPropertyName("payment_processor_certificate_password")]
    public string? PaymentProcessorCertificatePassword { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.GooglePay.Merchant;

[Serializable]
public record GooglePayMerchantCertificatesRegisterRequest
{
    [JsonPropertyName("merchant_certificate_data")]
    public string? MerchantCertificateData { get; set; }

    [JsonPropertyName("merchant_certificate_password")]
    public string? MerchantCertificatePassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

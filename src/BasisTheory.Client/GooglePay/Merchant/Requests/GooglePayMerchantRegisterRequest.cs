using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.GooglePay;

[Serializable]
public record GooglePayMerchantRegisterRequest
{
    [JsonPropertyName("merchant_identifier")]
    public string? MerchantIdentifier { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

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

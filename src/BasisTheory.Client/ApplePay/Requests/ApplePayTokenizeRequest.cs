using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ApplePayTokenizeRequest
{
    [JsonPropertyName("apple_payment_method_token")]
    public ApplePayMethodToken? ApplePaymentMethodToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

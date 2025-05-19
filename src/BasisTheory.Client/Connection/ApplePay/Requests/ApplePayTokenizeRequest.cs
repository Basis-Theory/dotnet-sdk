using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Connection;

public record ApplePayTokenizeRequest
{
    [JsonPropertyName("apple_payment_method_token")]
    public ApplePayMethodToken? ApplePaymentMethodToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

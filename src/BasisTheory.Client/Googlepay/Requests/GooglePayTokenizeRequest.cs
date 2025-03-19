using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record GooglePayTokenizeRequest
{
    [JsonPropertyName("google_payment_method_token")]
    public GooglePaymentMethodToken? GooglePaymentMethodToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

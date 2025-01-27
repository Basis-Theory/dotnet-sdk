using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Connections;

public record GooglePayTokenizeRequest
{
    [JsonPropertyName("google_payment_method_token")]
    public GooglePaymentMethodToken? GooglePaymentMethodToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

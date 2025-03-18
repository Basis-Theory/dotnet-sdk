using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplePayMethodToken
{
    [JsonPropertyName("paymentData")]
    public PaymentData? PaymentData { get; set; }

    [JsonPropertyName("transactionIdentifier")]
    public string? TransactionIdentifier { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

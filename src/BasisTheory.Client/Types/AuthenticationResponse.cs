using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AuthenticationResponse
{
    [JsonPropertyName("merchant_identifier")]
    public string? MerchantIdentifier { get; set; }

    [JsonPropertyName("authentication_data")]
    public string? AuthenticationData { get; set; }

    [JsonPropertyName("transaction_amount")]
    public string? TransactionAmount { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record BankVerificationRequest
{
    [JsonPropertyName("token_id")]
    public required string TokenId { get; set; }

    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record BankVerificationRequest
{
    [JsonPropertyName("token_id")]
    public required string TokenId { get; set; }

    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

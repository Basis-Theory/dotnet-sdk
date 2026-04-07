using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record CreateNetworkTokenRequest
{
    [JsonPropertyName("data")]
    public Card? Data { get; set; }

    [JsonPropertyName("token_id")]
    public string? TokenId { get; set; }

    [JsonPropertyName("token_intent_id")]
    public string? TokenIntentId { get; set; }

    [JsonPropertyName("cardholder_info")]
    public CardholderInfo? CardholderInfo { get; set; }

    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

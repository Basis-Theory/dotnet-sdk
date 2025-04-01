using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateNetworkTokenRequest
{
    [JsonPropertyName("data")]
    public Card? Data { get; set; }

    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    [JsonPropertyName("cardholder_info")]
    public CardholderInfo? CardholderInfo { get; set; }

    [JsonPropertyName("containers")]
    public IEnumerable<string>? Containers { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

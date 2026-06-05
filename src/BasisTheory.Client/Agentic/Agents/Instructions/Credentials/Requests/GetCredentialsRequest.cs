using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

[Serializable]
public record GetCredentialsRequest
{
    [JsonPropertyName("products")]
    public IEnumerable<Product>? Products { get; set; }

    [JsonPropertyName("merchant")]
    public required AgenticMerchant Merchant { get; set; }

    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    [JsonPropertyName("delivery_method")]
    public DeliveryMethod? DeliveryMethod { get; set; }

    [JsonPropertyName("shipping_address")]
    public ShippingAddress? ShippingAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

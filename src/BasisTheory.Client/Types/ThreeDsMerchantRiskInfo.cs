using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsMerchantRiskInfo
{
    [JsonPropertyName("delivery_email")]
    public string? DeliveryEmail { get; set; }

    [JsonPropertyName("delivery_time_frame")]
    public string? DeliveryTimeFrame { get; set; }

    [JsonPropertyName("gift_card_amount")]
    public string? GiftCardAmount { get; set; }

    [JsonPropertyName("gift_card_count")]
    public string? GiftCardCount { get; set; }

    [JsonPropertyName("gift_card_currency")]
    public string? GiftCardCurrency { get; set; }

    [JsonPropertyName("pre_order_purchase")]
    public bool? PreOrderPurchase { get; set; }

    [JsonPropertyName("pre_order_date")]
    public string? PreOrderDate { get; set; }

    [JsonPropertyName("reordered_purchase")]
    public bool? ReorderedPurchase { get; set; }

    [JsonPropertyName("shipping_method")]
    public string? ShippingMethod { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

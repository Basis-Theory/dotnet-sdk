using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record ThreeDsCardholderInfo
{
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    [JsonPropertyName("account_type")]
    public string? AccountType { get; set; }

    [JsonPropertyName("account_info")]
    public ThreeDsCardholderAccountInfo? AccountInfo { get; set; }

    [JsonPropertyName("authentication_info")]
    public ThreeDsCardholderAuthenticationInfo? AuthenticationInfo { get; set; }

    [JsonPropertyName("prior_authentication_info")]
    public ThreeDsPriorAuthenticationInfo? PriorAuthenticationInfo { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone_number")]
    public ThreeDsCardholderPhoneNumber? PhoneNumber { get; set; }

    [JsonPropertyName("mobile_phone_number")]
    public ThreeDsCardholderPhoneNumber? MobilePhoneNumber { get; set; }

    [JsonPropertyName("work_phone_number")]
    public ThreeDsCardholderPhoneNumber? WorkPhoneNumber { get; set; }

    [JsonPropertyName("billing_shipping_address_match")]
    public string? BillingShippingAddressMatch { get; set; }

    [JsonPropertyName("billing_address")]
    public ThreeDsAddress? BillingAddress { get; set; }

    [JsonPropertyName("shipping_address")]
    public ThreeDsAddress? ShippingAddress { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

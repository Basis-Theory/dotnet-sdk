using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsCardholderAccountInfo
{
    [JsonPropertyName("account_age")]
    public string? AccountAge { get; set; }

    [JsonPropertyName("account_last_changed")]
    public string? AccountLastChanged { get; set; }

    [JsonPropertyName("account_change_date")]
    public string? AccountChangeDate { get; set; }

    [JsonPropertyName("account_created_date")]
    public string? AccountCreatedDate { get; set; }

    [JsonPropertyName("account_pwd_last_changed")]
    public string? AccountPwdLastChanged { get; set; }

    [JsonPropertyName("account_pwd_change_date")]
    public string? AccountPwdChangeDate { get; set; }

    [JsonPropertyName("purchase_count_half_year")]
    public string? PurchaseCountHalfYear { get; set; }

    [JsonPropertyName("transaction_count_day")]
    public string? TransactionCountDay { get; set; }

    [JsonPropertyName("payment_account_age")]
    public string? PaymentAccountAge { get; set; }

    [JsonPropertyName("transaction_count_year")]
    public string? TransactionCountYear { get; set; }

    [JsonPropertyName("payment_account_created")]
    public string? PaymentAccountCreated { get; set; }

    [JsonPropertyName("shipping_address_first_used")]
    public string? ShippingAddressFirstUsed { get; set; }

    [JsonPropertyName("shipping_address_usage_date")]
    public string? ShippingAddressUsageDate { get; set; }

    [JsonPropertyName("shipping_account_name_match")]
    public bool? ShippingAccountNameMatch { get; set; }

    [JsonPropertyName("suspicious_activity_observed")]
    public bool? SuspiciousActivityObserved { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

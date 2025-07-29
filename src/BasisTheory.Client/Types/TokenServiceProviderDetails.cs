using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record TokenServiceProviderDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("tsp")]
    public string? Tsp { get; set; }

    [JsonPropertyName("auth_method")]
    public string? AuthMethod { get; set; }

    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    [JsonPropertyName("eci_indicator")]
    public string? EciIndicator { get; set; }

    [JsonPropertyName("assurance_details")]
    public AssuranceDetails? AssuranceDetails { get; set; }

    [JsonPropertyName("transaction_id")]
    public string? TransactionId { get; set; }

    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("transaction_amount")]
    public long? TransactionAmount { get; set; }

    [JsonPropertyName("cardholder_name")]
    public string? CardholderName { get; set; }

    [JsonPropertyName("device_manufacturer_identifier")]
    public string? DeviceManufacturerIdentifier { get; set; }

    [JsonPropertyName("payment_data_type")]
    public string? PaymentDataType { get; set; }

    [JsonPropertyName("merchant_token_identifier")]
    public string? MerchantTokenIdentifier { get; set; }

    [JsonPropertyName("authentication_responses")]
    public IEnumerable<AuthenticationResponse>? AuthenticationResponses { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

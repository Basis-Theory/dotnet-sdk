using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[Serializable]
public record CreatePaymentCredentialRequestCredentialMppPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Billing address included in an MPP Card credential. Required when the card challenge sets billingRequired to true.
    /// </summary>
    [JsonPropertyName("billing_address")]
    public CreatePaymentCredentialRequestCredentialMppPayloadBillingAddress? BillingAddress { get; set; }

    /// <summary>
    /// Cardholder name included in the MPP Card credential when available.
    /// </summary>
    [JsonPropertyName("cardholder_full_name")]
    public string? CardholderFullName { get; set; }

    [JsonPropertyName("challenge")]
    public required CreatePaymentCredentialRequestCredentialMppPayloadChallenge Challenge { get; set; }

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

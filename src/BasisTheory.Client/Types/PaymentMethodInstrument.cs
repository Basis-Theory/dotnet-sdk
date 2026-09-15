using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record PaymentMethodInstrument : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The set a payment method can actually carry today. `stablecoin_wallet` and `bnpl_account` are listed on ConnectionInstrument and can be enumerated, but no rail funds them yet, so sourcing one fails before a payment method exists. `other` is an instrument the provider offers that Basis Theory could not classify.
    /// </summary>
    [JsonPropertyName("type")]
    public required PaymentMethodInstrumentType Type { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// Shaped by `type`; empty for `other`.
    /// </summary>
    [JsonPropertyName("display")]
    public required PaymentMethodInstrumentDisplay Display { get; set; }

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

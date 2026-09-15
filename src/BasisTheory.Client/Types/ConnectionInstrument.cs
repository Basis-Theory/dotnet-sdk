using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// A funding instrument the connection can reach. This is a read-through projection of provider state, not a Basis Theory resource, so `instrument_id` is the provider's own identifier and is only as stable as the provider makes it.
/// </summary>
[Serializable]
public record ConnectionInstrument : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("instrument_id")]
    public required string InstrumentId { get; set; }

    /// <summary>
    /// `other` is the mandatory catch-all. An instrument we cannot classify is still listed — dropping it silently would hide a card the consumer can see in their own wallet.
    /// </summary>
    [JsonPropertyName("type")]
    public required ConnectionInstrumentType Type { get; set; }

    [JsonPropertyName("is_default")]
    public required bool IsDefault { get; set; }

    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>
    /// Non-sensitive identifying data, shaped by `type`. Empty for `other`. Never contains a PAN, a CVC, or a key.
    /// </summary>
    [JsonPropertyName("display")]
    public object? Display { get; set; }

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

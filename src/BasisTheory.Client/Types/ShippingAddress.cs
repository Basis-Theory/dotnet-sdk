using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record ShippingAddress : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("line1")]
    public required string Line1 { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

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

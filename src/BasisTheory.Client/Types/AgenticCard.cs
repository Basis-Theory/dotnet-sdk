using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record AgenticCard : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("brand")]
    public AgenticCardBrand? Brand { get; set; }

    [JsonPropertyName("bin")]
    public string? Bin { get; set; }

    [JsonPropertyName("last4")]
    public string? Last4 { get; set; }

    [JsonPropertyName("expiration_month")]
    public int? ExpirationMonth { get; set; }

    [JsonPropertyName("expiration_year")]
    public int? ExpirationYear { get; set; }

    /// <summary>
    /// Card funding type (e.g. credit, debit, prepaid)
    /// </summary>
    [JsonPropertyName("funding")]
    public string? Funding { get; set; }

    /// <summary>
    /// Card issuer information
    /// </summary>
    [JsonPropertyName("issuer")]
    public AgenticCardIssuer? Issuer { get; set; }

    /// <summary>
    /// Card issuer country details
    /// </summary>
    [JsonPropertyName("issuer_country")]
    public AgenticCardIssuerCountry? IssuerCountry { get; set; }

    /// <summary>
    /// Card segment (e.g. consumer, commercial)
    /// </summary>
    [JsonPropertyName("segment")]
    public string? Segment { get; set; }

    /// <summary>
    /// Card type
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("display")]
    public CardDisplay? Display { get; set; }

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

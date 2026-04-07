using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record CardDetailsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("funding")]
    public string? Funding { get; set; }

    [JsonPropertyName("segment")]
    public string? Segment { get; set; }

    [JsonPropertyName("issuer")]
    public CardIssuerDetails? Issuer { get; set; }

    [JsonPropertyName("binRange")]
    public IEnumerable<CardBinRange>? BinRange { get; set; }

    [JsonPropertyName("additional")]
    public IEnumerable<AdditionalCardDetail>? Additional { get; set; }

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

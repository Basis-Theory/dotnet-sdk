using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record CardNetworkInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("visa")]
    public VisaConfig? Visa { get; set; }

    [JsonPropertyName("mastercard")]
    public MastercardConfig? Mastercard { get; set; }

    [JsonPropertyName("amex")]
    public AmexConfig? Amex { get; set; }

    [JsonPropertyName("discover")]
    public DiscoverConfig? Discover { get; set; }

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

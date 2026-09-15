using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record SharedPaymentRailBaseAgenticToken : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required SharedPaymentRailBaseAgenticTokenProvider Provider { get; set; }

    /// <summary>
    /// Provider-native reference identifiers for this rail. Informational; use for support and correlation, not as a stable contract.
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public Dictionary<string, string>? ProviderIds { get; set; }

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

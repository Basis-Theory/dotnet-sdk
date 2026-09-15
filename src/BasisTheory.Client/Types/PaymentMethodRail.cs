using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record PaymentMethodRail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rail")]
    public string? Rail { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>
    /// Provider-native reference identifiers for this rail. Informational; use for support and correlation, not as a stable contract.
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public Dictionary<string, string>? ProviderIds { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("error")]
    public SharedPaymentRailError? Error { get; set; }

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

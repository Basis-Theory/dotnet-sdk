using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record CreateConnectionRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// Omit to use the provider's default grant method.
    /// </summary>
    [JsonPropertyName("grant_method")]
    public string? GrantMethod { get; set; }

    [JsonPropertyName("principal")]
    public ConnectionPrincipal? Principal { get; set; }

    /// <summary>
    /// Exact provider-native permission strings to request. Omit to use the grant method's defaults. Validated against the provider's own vocabulary, not against a Basis Theory enum.
    /// </summary>
    [JsonPropertyName("permissions")]
    public IEnumerable<string>? Permissions { get; set; }

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

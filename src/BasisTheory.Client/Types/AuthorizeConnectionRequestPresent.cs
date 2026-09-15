using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Present or rotate a credential for a grant method that has no ceremony — a restricted API key an administrator generated, for instance. Secrets are accepted here rather than on create so that a failed write never leaves Basis Theory holding a live credential with no resource to reference it.
/// </summary>
[Serializable]
public record AuthorizeConnectionRequestPresent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Provider-shaped. Validated by the provider adapter. Never logged, never returned, never published.
    /// </summary>
    [JsonPropertyName("credential")]
    public object Credential { get; set; } = new Dictionary<string, object?>();

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

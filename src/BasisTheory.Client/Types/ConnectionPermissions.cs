using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Requested and granted are different things and are never merged. A provider may grant a subset of what was asked for, and some providers cannot report their grant at all.
/// </summary>
[Serializable]
public record ConnectionPermissions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Namespace the permission strings belong to. Basis Theory does not normalize provider permissions into its own enum, so this is what makes three strings and seventy-six interpretable in one field.
    /// </summary>
    [JsonPropertyName("vocabulary")]
    public required string Vocabulary { get; set; }

    [JsonPropertyName("requested")]
    public IEnumerable<string> Requested { get; set; } = new List<string>();

    [JsonPropertyName("granted")]
    public IEnumerable<string> Granted { get; set; } = new List<string>();

    /// <summary>
    /// False when the provider gives us no way to read the grant back — a pasted API key, for instance. `granted` is then our best assertion rather than an observation, and `status_details.cause` is `unverified`.
    /// </summary>
    [JsonPropertyName("granted_verified")]
    public required bool GrantedVerified { get; set; }

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

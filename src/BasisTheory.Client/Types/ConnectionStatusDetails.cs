using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// `status` alone does not tell an integrator what to do. `action` is the contract with their UI and `actor` says who must perform it. Both are derived on read.
/// </summary>
[Serializable]
public record ConnectionStatusDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("action")]
    public required ConnectionStatusDetailsAction Action { get; set; }

    [JsonPropertyName("actor")]
    public required ConnectionStatusDetailsActor Actor { get; set; }

    /// <summary>
    /// Absent when the connection is healthy and unremarkable.
    /// </summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    [JsonPropertyName("since")]
    public DateTime? Since { get; set; }

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

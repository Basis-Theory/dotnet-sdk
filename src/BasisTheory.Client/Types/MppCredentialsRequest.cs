using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record MppCredentialsRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("challenge")]
    public required MppChallenge Challenge { get; set; }

    /// <summary>
    /// Mutually exclusive with card_id
    /// </summary>
    [JsonPropertyName("source")]
    public MppSource? Source { get; set; }

    /// <summary>
    /// Mutually exclusive with source
    /// </summary>
    [JsonPropertyName("card_id")]
    public string? CardId { get; set; }

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

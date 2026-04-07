using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record PendingProxy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("destination_url")]
    public string? DestinationUrl { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string>? Configuration { get; set; }

    [JsonPropertyName("require_auth")]
    public bool? RequireAuth { get; set; }

    [JsonPropertyName("request_transforms")]
    public IEnumerable<ProxyTransform>? RequestTransforms { get; set; }

    [JsonPropertyName("response_transforms")]
    public IEnumerable<ProxyTransform>? ResponseTransforms { get; set; }

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

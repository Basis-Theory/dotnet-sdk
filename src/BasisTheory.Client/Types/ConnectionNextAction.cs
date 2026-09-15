using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Present only while a ceremony is outstanding. A grant method whose ceremony is `none` never returns this field, and its absence together with `status_details.action: none` means there is nothing to do.
/// </summary>
[Serializable]
public record ConnectionNextAction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public string Type { get; set; } = "redirect";

    /// <summary>
    /// Why the principal is being sent to the provider. Open by design: a provider may introduce a ceremony purpose without a breaking change to this schema.
    /// </summary>
    [JsonPropertyName("purpose")]
    public required string Purpose { get; set; }

    [JsonPropertyName("uri")]
    public required string Uri { get; set; }

    [JsonPropertyName("uri_type")]
    public string UriType { get; set; } = "WEB_URI";

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("poll_after_seconds")]
    public int? PollAfterSeconds { get; set; }

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

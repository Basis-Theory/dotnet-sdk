using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record AllowanceVerificationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required AllowanceVerificationResponseStatus Status { get; set; }

    [JsonPropertyName("rail")]
    public required AllowanceVerificationResponseRail Rail { get; set; }

    [JsonPropertyName("provider")]
    public required AllowanceVerificationResponseProvider Provider { get; set; }

    [JsonPropertyName("next_action")]
    public object? NextAction { get; set; }

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

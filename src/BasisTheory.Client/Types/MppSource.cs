using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record MppSource : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required MppSourceType Type { get; set; }

    /// <summary>
    /// Token ID (required for token, network_token, apple_pay, google_pay)
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Enrollment ID (VIC only, mutually exclusive with id)
    /// </summary>
    [JsonPropertyName("enrollment_id")]
    public string? EnrollmentId { get; set; }

    /// <summary>
    /// Required for VIC with token id
    /// </summary>
    [JsonPropertyName("consumer")]
    public Consumer? Consumer { get; set; }

    /// <summary>
    /// Agent ID (VIC only)
    /// </summary>
    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

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

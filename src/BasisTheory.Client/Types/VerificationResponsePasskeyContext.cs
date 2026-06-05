using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Visa passkey/FIDO context for device binding or authentication
/// </summary>
[Serializable]
public record VerificationResponsePasskeyContext : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    [JsonPropertyName("action")]
    public VerificationResponsePasskeyContextAction? Action { get; set; }

    [JsonPropertyName("platform_type")]
    public VerificationResponsePasskeyContextPlatformType? PlatformType { get; set; }

    [JsonPropertyName("auth_preferences")]
    public VerificationResponsePasskeyContextAuthPreferences? AuthPreferences { get; set; }

    [JsonPropertyName("display_context")]
    public VerificationResponsePasskeyContextDisplayContext? DisplayContext { get; set; }

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

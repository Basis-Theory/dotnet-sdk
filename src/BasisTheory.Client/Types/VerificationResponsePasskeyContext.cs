using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

/// <summary>
/// Visa passkey/FIDO context for device binding or authentication
/// </summary>
[Serializable]
public record VerificationResponsePasskeyContext
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

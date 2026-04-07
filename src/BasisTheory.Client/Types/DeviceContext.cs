using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record DeviceContext
{
    [JsonPropertyName("screen_height")]
    public required int ScreenHeight { get; set; }

    [JsonPropertyName("screen_width")]
    public required int ScreenWidth { get; set; }

    [JsonPropertyName("user_agent_string")]
    public required string UserAgentString { get; set; }

    [JsonPropertyName("language_code")]
    public required string LanguageCode { get; set; }

    [JsonPropertyName("time_zone")]
    public required string TimeZone { get; set; }

    [JsonPropertyName("java_script_enabled")]
    public required bool JavaScriptEnabled { get; set; }

    [JsonPropertyName("client_device_id")]
    public required string ClientDeviceId { get; set; }

    [JsonPropertyName("client_reference_id")]
    public required string ClientReferenceId { get; set; }

    [JsonPropertyName("platform_type")]
    public required DeviceContextPlatformType PlatformType { get; set; }

    [JsonPropertyName("color_depth")]
    public int? ColorDepth { get; set; }

    [JsonPropertyName("accept_header")]
    public string? AcceptHeader { get; set; }

    /// <summary>
    /// Auto-filled from request IP if not provided
    /// </summary>
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("session_context")]
    public DeviceContextSessionContext? SessionContext { get; set; }

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

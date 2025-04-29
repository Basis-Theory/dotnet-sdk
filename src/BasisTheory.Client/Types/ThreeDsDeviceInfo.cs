using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsDeviceInfo
{
    [JsonPropertyName("browser_accept_header")]
    public string? BrowserAcceptHeader { get; set; }

    [JsonPropertyName("browser_ip")]
    public string? BrowserIp { get; set; }

    [JsonPropertyName("browser_javascript_enabled")]
    public bool? BrowserJavascriptEnabled { get; set; }

    [JsonPropertyName("browser_java_enabled")]
    public bool? BrowserJavaEnabled { get; set; }

    [JsonPropertyName("browser_language")]
    public string? BrowserLanguage { get; set; }

    [JsonPropertyName("browser_color_depth")]
    public string? BrowserColorDepth { get; set; }

    [JsonPropertyName("browser_screen_height")]
    public string? BrowserScreenHeight { get; set; }

    [JsonPropertyName("browser_screen_width")]
    public string? BrowserScreenWidth { get; set; }

    [JsonPropertyName("browser_tz")]
    public string? BrowserTz { get; set; }

    [JsonPropertyName("browser_user_agent")]
    public string? BrowserUserAgent { get; set; }

    [JsonPropertyName("sdk_transaction_id")]
    public string? SdkTransactionId { get; set; }

    [JsonPropertyName("sdk_application_id")]
    public string? SdkApplicationId { get; set; }

    [JsonPropertyName("sdk_encryption_data")]
    public string? SdkEncryptionData { get; set; }

    [JsonPropertyName("sdk_ephemeral_public_key")]
    public string? SdkEphemeralPublicKey { get; set; }

    [JsonPropertyName("sdk_max_timeout")]
    public string? SdkMaxTimeout { get; set; }

    [JsonPropertyName("sdk_reference_number")]
    public string? SdkReferenceNumber { get; set; }

    [JsonPropertyName("sdk_render_options")]
    public ThreeDsMobileSdkRenderOptions? SdkRenderOptions { get; set; }

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

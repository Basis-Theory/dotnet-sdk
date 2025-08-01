using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateThreeDsSessionResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("cardBrand")]
    public string? CardBrand { get; set; }

    [JsonPropertyName("additional_card_brands")]
    public IEnumerable<string>? AdditionalCardBrands { get; set; }

    [JsonPropertyName("method_url")]
    public string? MethodUrl { get; set; }

    [JsonPropertyName("method_notification_url")]
    public string? MethodNotificationUrl { get; set; }

    [JsonPropertyName("directory_server_id")]
    public string? DirectoryServerId { get; set; }

    [JsonPropertyName("recommended_version")]
    public string? RecommendedVersion { get; set; }

    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

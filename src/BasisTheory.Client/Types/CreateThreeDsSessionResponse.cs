using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record CreateThreeDsSessionResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsSession
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("pan_token_id")]
    public string? PanTokenId { get; set; }

    [JsonPropertyName("token_id")]
    public string? TokenId { get; set; }

    [JsonPropertyName("token_intent_id")]
    public string? TokenIntentId { get; set; }

    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; set; }

    [JsonPropertyName("expiration_date")]
    public DateTime? ExpirationDate { get; set; }

    [JsonPropertyName("created_date")]
    public DateTime? CreatedDate { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("modified_date")]
    public DateTime? ModifiedDate { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("device")]
    public string? Device { get; set; }

    [JsonPropertyName("device_info")]
    public ThreeDsDeviceInfo? DeviceInfo { get; set; }

    [JsonPropertyName("web_challenge_mode")]
    public string? WebChallengeMode { get; set; }

    [JsonPropertyName("version")]
    public ThreeDsVersion? Version { get; set; }

    [JsonPropertyName("method")]
    public ThreeDsMethod? Method { get; set; }

    [JsonPropertyName("authentication")]
    public ThreeDsAuthentication? Authentication { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

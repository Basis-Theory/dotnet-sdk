using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Threeds;

public record CreateThreeDsSessionRequest
{
    [JsonPropertyName("pan")]
    public string? Pan { get; set; }

    [JsonPropertyName("token_id")]
    public string? TokenId { get; set; }

    [JsonPropertyName("token_intent_id")]
    public string? TokenIntentId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("device")]
    public string? Device { get; set; }

    [JsonPropertyName("web_challenge_mode")]
    public string? WebChallengeMode { get; set; }

    [JsonPropertyName("device_info")]
    public ThreeDsDeviceInfo? DeviceInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.ApplePay;

[Serializable]
public record ApplePaySessionRequest
{
    [JsonPropertyName("validation_url")]
    public string? ValidationUrl { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.ApplePay;

public record ApplePaySessionRequest
{
    [JsonPropertyName("validation_url")]
    public string? ValidationUrl { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

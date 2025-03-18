using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ProxyTransform
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

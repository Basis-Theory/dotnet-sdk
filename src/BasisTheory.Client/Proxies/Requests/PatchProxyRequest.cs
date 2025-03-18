using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record PatchProxyRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("destination_url")]
    public string? DestinationUrl { get; set; }

    [JsonPropertyName("request_transform")]
    public ProxyTransform? RequestTransform { get; set; }

    [JsonPropertyName("response_transform")]
    public ProxyTransform? ResponseTransform { get; set; }

    [JsonPropertyName("application")]
    public Application? Application { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string?>? Configuration { get; set; }

    [JsonPropertyName("require_auth")]
    public bool? RequireAuth { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

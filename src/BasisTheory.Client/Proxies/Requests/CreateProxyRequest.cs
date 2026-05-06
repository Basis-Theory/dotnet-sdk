using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record CreateProxyRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("destination_url")]
    public required string DestinationUrl { get; set; }

    [JsonPropertyName("request_reactor_id")]
    public string? RequestReactorId { get; set; }

    [JsonPropertyName("response_reactor_id")]
    public string? ResponseReactorId { get; set; }

    [JsonPropertyName("request_transform")]
    public ProxyTransform? RequestTransform { get; set; }

    [JsonPropertyName("response_transform")]
    public ProxyTransform? ResponseTransform { get; set; }

    [JsonPropertyName("request_transforms")]
    public IEnumerable<ProxyTransform>? RequestTransforms { get; set; }

    [JsonPropertyName("response_transforms")]
    public IEnumerable<ProxyTransform>? ResponseTransforms { get; set; }

    [JsonPropertyName("application")]
    public Application? Application { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string?>? Configuration { get; set; }

    [JsonPropertyName("require_auth")]
    public bool? RequireAuth { get; set; }

    [JsonPropertyName("disable_detokenization")]
    public bool? DisableDetokenization { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

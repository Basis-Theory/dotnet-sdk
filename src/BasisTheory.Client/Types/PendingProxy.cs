using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record PendingProxy
{
    [JsonPropertyName("destination_url")]
    public string? DestinationUrl { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string?>? Configuration { get; set; }

    [JsonPropertyName("require_auth")]
    public bool? RequireAuth { get; set; }

    [JsonPropertyName("request_transforms")]
    public IEnumerable<ProxyTransform>? RequestTransforms { get; set; }

    [JsonPropertyName("response_transforms")]
    public IEnumerable<ProxyTransform>? ResponseTransforms { get; set; }

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

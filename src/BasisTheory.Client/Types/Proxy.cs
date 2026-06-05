using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record Proxy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("destination_url")]
    public string? DestinationUrl { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("request_reactor_id")]
    public string? RequestReactorId { get; set; }

    [JsonPropertyName("response_reactor_id")]
    public string? ResponseReactorId { get; set; }

    [JsonPropertyName("require_auth")]
    public bool? RequireAuth { get; set; }

    [JsonPropertyName("request_transform")]
    public ProxyTransform? RequestTransform { get; set; }

    [JsonPropertyName("response_transform")]
    public ProxyTransform? ResponseTransform { get; set; }

    [JsonPropertyName("request_transforms")]
    public IEnumerable<ProxyTransform>? RequestTransforms { get; set; }

    [JsonPropertyName("response_transforms")]
    public IEnumerable<ProxyTransform>? ResponseTransforms { get; set; }

    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string>? Configuration { get; set; }

    [JsonPropertyName("proxy_host")]
    public string? ProxyHost { get; set; }

    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    [JsonPropertyName("disable_detokenization")]
    public bool? DisableDetokenization { get; set; }

    [JsonPropertyName("client_certificate")]
    public string? ClientCertificate { get; set; }

    [JsonPropertyName("requested")]
    public RequestedProxy? Requested { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

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

using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsRequestorInfo
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("discover_client_id")]
    public string? DiscoverClientId { get; set; }

    [JsonPropertyName("discover_requestor_id")]
    public string? DiscoverRequestorId { get; set; }

    [JsonPropertyName("amex_requestor_type")]
    public string? AmexRequestorType { get; set; }

    [JsonPropertyName("cb_siret_number")]
    public string? CbSiretNumber { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

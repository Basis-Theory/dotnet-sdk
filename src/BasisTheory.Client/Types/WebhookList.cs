using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record WebhookList
{
    [JsonPropertyName("pagination")]
    public required WebhookListPagination Pagination { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<Webhook> Data { get; set; } = new List<Webhook>();

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

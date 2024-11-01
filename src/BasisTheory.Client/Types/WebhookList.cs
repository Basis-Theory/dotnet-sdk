using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record WebhookList
{
    [JsonPropertyName("pagination")]
    public required WebhookListPagination Pagination { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<Webhook> Data { get; set; } = new List<Webhook>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

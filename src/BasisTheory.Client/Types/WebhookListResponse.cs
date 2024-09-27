using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record WebhookListResponse
{
    [JsonPropertyName("pagination")]
    public WebhookListResponsePagination? Pagination { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<WebhookResponse>? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

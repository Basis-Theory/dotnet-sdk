using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenCursorPaginatedList
{
    [JsonPropertyName("pagination")]
    public CursorPagination? Pagination { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<Token>? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

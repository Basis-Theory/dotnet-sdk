using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CursorPagination
{
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    [JsonPropertyName("next")]
    public string? Next { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

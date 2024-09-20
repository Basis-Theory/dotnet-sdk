using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenMetrics
{
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    [JsonPropertyName("last_created_at")]
    public DateTime? LastCreatedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

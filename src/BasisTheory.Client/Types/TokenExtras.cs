using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenExtras
{
    [JsonPropertyName("deduplicated")]
    public bool? Deduplicated { get; set; }

    [JsonPropertyName("tsp_details")]
    public TokenServiceProviderDetails? TspDetails { get; set; }

    [JsonPropertyName("deduplication_behavior")]
    public string? DeduplicationBehavior { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

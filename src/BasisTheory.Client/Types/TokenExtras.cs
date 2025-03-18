using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenExtras
{
    [JsonPropertyName("deduplicated")]
    public bool? Deduplicated { get; set; }

    [JsonPropertyName("tsp_details")]
    public TokenServiceProviderDetails? TspDetails { get; set; }

    [JsonPropertyName("deduplication_behavior")]
    public string? DeduplicationBehavior { get; set; }

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

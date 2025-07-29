using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record TokenExtras
{
    [JsonPropertyName("deduplicated")]
    public bool? Deduplicated { get; set; }

    [JsonPropertyName("tsp_details")]
    public TokenServiceProviderDetails? TspDetails { get; set; }

    [JsonPropertyName("deduplication_behavior")]
    public string? DeduplicationBehavior { get; set; }

    [JsonPropertyName("network_token_ids")]
    public IEnumerable<string>? NetworkTokenIds { get; set; }

    [JsonPropertyName("decrypted_payload")]
    public bool? DecryptedPayload { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

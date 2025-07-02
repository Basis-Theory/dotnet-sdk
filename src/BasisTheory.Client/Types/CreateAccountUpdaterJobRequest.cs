using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateAccountUpdaterJobRequest
{
    /// <summary>
    /// Whether deduplication should be enabled when creating new tokens. Uses the value of the Deduplicate Tokens setting on the tenant if not set.
    /// </summary>
    [JsonPropertyName("deduplicate_tokens")]
    public bool? DeduplicateTokens { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

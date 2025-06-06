using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenIntentExtras
{
    [JsonPropertyName("tsp_details")]
    public TokenServiceProviderDetails? TspDetails { get; set; }

    [JsonPropertyName("network_token_ids")]
    public IEnumerable<string>? NetworkTokenIds { get; set; }

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

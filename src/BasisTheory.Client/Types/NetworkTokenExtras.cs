using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record NetworkTokenExtras
{
    [JsonPropertyName("deduplicated")]
    public bool? Deduplicated { get; set; }

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

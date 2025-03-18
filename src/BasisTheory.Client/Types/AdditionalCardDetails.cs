using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record AdditionalCardDetails
{
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("funding")]
    public string? Funding { get; set; }

    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }

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

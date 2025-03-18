using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenEnrichments
{
    [JsonPropertyName("bin_details")]
    public BinDetails? BinDetails { get; set; }

    [JsonPropertyName("card_details")]
    public TokenEnrichmentsCardDetails? CardDetails { get; set; }

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

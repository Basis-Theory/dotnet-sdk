using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenIntentExtras
{
    [JsonPropertyName("tsp_details")]
    public TokenServiceProviderDetails? TspDetails { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

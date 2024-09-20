using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record UpdatePrivacy
{
    [JsonPropertyName("impact_level")]
    public string? ImpactLevel { get; set; }

    [JsonPropertyName("restriction_policy")]
    public string? RestrictionPolicy { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

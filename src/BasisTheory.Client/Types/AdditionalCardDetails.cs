using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AdditionalCardDetails
{
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("funding")]
    public string? Funding { get; set; }

    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

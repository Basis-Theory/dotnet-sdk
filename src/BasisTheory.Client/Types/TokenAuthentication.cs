using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokenAuthentication
{
    [JsonPropertyName("threeds_cryptogram")]
    public string? ThreedsCryptogram { get; set; }

    [JsonPropertyName("eci_indicator")]
    public string? EciIndicator { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

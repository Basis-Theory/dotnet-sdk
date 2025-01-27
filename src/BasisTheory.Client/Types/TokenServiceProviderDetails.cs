using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenServiceProviderDetails
{
    [JsonPropertyName("tsp")]
    public string? Tsp { get; set; }

    [JsonPropertyName("auth_method")]
    public string? AuthMethod { get; set; }

    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    [JsonPropertyName("eci_indicator")]
    public string? EciIndicator { get; set; }

    [JsonPropertyName("assurance_details")]
    public AssuranceDetails? AssuranceDetails { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

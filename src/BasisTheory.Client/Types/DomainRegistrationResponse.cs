using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record DomainRegistrationResponse
{
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CardIssuerCountry
{
    [JsonPropertyName("alpha2")]
    public string? Alpha2 { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("numeric")]
    public string? Numeric { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

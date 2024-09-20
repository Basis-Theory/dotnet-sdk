using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsCardholderPhoneNumber
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

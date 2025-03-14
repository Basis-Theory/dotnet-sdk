using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsMerchantInfo
{
    [JsonPropertyName("mid")]
    public string? Mid { get; set; }

    [JsonPropertyName("acquirer_bin")]
    public string? AcquirerBin { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("category_code")]
    public string? CategoryCode { get; set; }

    [JsonPropertyName("risk_info")]
    public ThreeDsMerchantRiskInfo? RiskInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

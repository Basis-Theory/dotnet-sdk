using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsVersion
{
    [JsonPropertyName("recommended_version")]
    public string? RecommendedVersion { get; set; }

    [JsonPropertyName("available_versions")]
    public IEnumerable<string>? AvailableVersions { get; set; }

    [JsonPropertyName("earliest_acs_supported_version")]
    public string? EarliestAcsSupportedVersion { get; set; }

    [JsonPropertyName("earliest_ds_supported_version")]
    public string? EarliestDsSupportedVersion { get; set; }

    [JsonPropertyName("latest_acs_supported_version")]
    public string? LatestAcsSupportedVersion { get; set; }

    [JsonPropertyName("latest_ds_supported_version")]
    public string? LatestDsSupportedVersion { get; set; }

    [JsonPropertyName("acs_information")]
    public IEnumerable<string>? AcsInformation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

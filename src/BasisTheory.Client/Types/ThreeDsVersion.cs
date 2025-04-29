using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

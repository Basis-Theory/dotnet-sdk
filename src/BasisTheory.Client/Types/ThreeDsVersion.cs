using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record ThreeDsVersion : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

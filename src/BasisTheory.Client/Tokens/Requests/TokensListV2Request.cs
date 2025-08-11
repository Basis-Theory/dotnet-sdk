using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record TokensListV2Request
{
    [JsonIgnore]
    public string? Type { get; set; }

    [JsonIgnore]
    public string? Container { get; set; }

    [JsonIgnore]
    public string? Fingerprint { get; set; }

    [JsonIgnore]
    public Dictionary<string, string?>? Metadata { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    [JsonIgnore]
    public int? Size { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

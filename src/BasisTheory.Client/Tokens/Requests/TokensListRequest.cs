using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokensListRequest
{
    [JsonIgnore]
    public IEnumerable<string> Id { get; set; } = new List<string>();

    [JsonIgnore]
    public Dictionary<string, string?>? Metadata { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    [JsonIgnore]
    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

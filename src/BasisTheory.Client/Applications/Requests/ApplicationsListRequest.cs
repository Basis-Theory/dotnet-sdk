using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplicationsListRequest
{
    [JsonIgnore]
    public IEnumerable<string> Id { get; set; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<string> Type { get; set; } = new List<string>();

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

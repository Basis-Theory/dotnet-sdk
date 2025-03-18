using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplicationKeysListRequest
{
    [JsonIgnore]
    public IEnumerable<string> Id { get; set; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<string> Type { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

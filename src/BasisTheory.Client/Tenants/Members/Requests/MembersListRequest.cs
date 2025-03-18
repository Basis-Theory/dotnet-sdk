using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public record MembersListRequest
{
    [JsonIgnore]
    public IEnumerable<string> UserId { get; set; } = new List<string>();

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

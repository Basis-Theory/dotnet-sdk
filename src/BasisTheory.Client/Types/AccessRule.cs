using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AccessRule
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("container")]
    public string? Container { get; set; }

    [JsonPropertyName("transform")]
    public string? Transform { get; set; }

    [JsonPropertyName("conditions")]
    public IEnumerable<Condition>? Conditions { get; set; }

    [JsonPropertyName("permissions")]
    public IEnumerable<string>? Permissions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record Permission
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("application_types")]
    public IEnumerable<string>? ApplicationTypes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

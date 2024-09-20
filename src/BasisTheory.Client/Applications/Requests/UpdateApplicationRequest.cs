using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record UpdateApplicationRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("permissions")]
    public IEnumerable<string>? Permissions { get; set; }

    [JsonPropertyName("rules")]
    public IEnumerable<AccessRule>? Rules { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

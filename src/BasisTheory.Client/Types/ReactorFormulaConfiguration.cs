using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ReactorFormulaConfiguration
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

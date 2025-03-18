using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ReactorFormulaRequestParameter
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

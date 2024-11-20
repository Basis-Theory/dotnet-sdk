using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CreateReactorFormulaRequest
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("configuration")]
    public IEnumerable<ReactorFormulaConfiguration>? Configuration { get; set; }

    [JsonPropertyName("request_parameters")]
    public IEnumerable<ReactorFormulaRequestParameter>? RequestParameters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

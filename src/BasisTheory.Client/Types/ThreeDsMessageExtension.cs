using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsMessageExtension
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

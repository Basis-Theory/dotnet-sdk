using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record PatchReactorRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("application")]
    public Application? Application { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string?>? Configuration { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
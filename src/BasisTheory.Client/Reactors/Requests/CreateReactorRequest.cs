using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record CreateReactorRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("application")]
    public Application? Application { get; set; }

    [JsonPropertyName("configuration")]
    public Dictionary<string, string?>? Configuration { get; set; }

    [JsonPropertyName("dependencies")]
    public Dictionary<string, string?>? Dependencies { get; set; }

    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

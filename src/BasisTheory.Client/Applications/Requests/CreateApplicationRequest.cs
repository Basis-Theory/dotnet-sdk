using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CreateApplicationRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    [JsonPropertyName("permissions")]
    public IEnumerable<string>? Permissions { get; set; }

    [JsonPropertyName("rules")]
    public IEnumerable<AccessRule>? Rules { get; set; }

    [JsonPropertyName("create_key")]
    public bool? CreateKey { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

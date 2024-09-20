using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record StringStringKeyValuePair
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

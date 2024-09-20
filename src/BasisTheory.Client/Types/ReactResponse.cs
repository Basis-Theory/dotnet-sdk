using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ReactResponse
{
    [JsonPropertyName("tokens")]
    public object? Tokens { get; set; }

    [JsonPropertyName("raw")]
    public object? Raw { get; set; }

    [JsonPropertyName("body")]
    public object? Body { get; set; }

    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

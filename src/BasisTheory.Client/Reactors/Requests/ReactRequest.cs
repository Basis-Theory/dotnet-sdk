using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ReactRequest
{
    [JsonPropertyName("args")]
    public object? Args { get; set; }

    [JsonPropertyName("callback_url")]
    public string? CallbackUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

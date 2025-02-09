using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ReactRequestAsync
{
    [JsonPropertyName("args")]
    public object? Args { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

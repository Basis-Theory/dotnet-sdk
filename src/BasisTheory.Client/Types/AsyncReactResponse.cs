using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AsyncReactResponse
{
    [JsonPropertyName("asyncReactorRequestId")]
    public string? AsyncReactorRequestId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

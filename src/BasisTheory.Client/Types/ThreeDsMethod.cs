using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsMethod
{
    [JsonPropertyName("method_url")]
    public string? MethodUrl { get; set; }

    [JsonPropertyName("method_completion_indicator")]
    public string? MethodCompletionIndicator { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

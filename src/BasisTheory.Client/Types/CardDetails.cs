using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record CardDetails
{
    [JsonPropertyName("bin")]
    public string? Bin { get; set; }

    [JsonPropertyName("last4")]
    public string? Last4 { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

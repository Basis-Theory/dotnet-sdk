using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenExtras
{
    [JsonPropertyName("deduplicated")]
    public bool? Deduplicated { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

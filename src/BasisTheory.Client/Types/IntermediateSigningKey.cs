using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record IntermediateSigningKey
{
    [JsonPropertyName("signedKey")]
    public string? SignedKey { get; set; }

    [JsonPropertyName("signatures")]
    public IEnumerable<string>? Signatures { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

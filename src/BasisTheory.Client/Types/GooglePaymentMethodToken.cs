using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record GooglePaymentMethodToken
{
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("intermediateSigningKey")]
    public IntermediateSigningKey? IntermediateSigningKey { get; set; }

    [JsonPropertyName("signedMessage")]
    public string? SignedMessage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

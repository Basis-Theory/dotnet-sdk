using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

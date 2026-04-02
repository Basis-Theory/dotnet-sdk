using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record EncryptionJwk
{
    [JsonPropertyName("kty")]
    public string Kty { get; set; } = "RSA";

    [JsonPropertyName("kid")]
    public required string Kid { get; set; }

    [JsonPropertyName("use")]
    public string Use { get; set; } = "enc";

    [JsonPropertyName("alg")]
    public string Alg { get; set; } = "RSA-OAEP-256";

    [JsonPropertyName("n")]
    public required string N { get; set; }

    [JsonPropertyName("e")]
    public required string E { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

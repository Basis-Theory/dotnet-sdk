using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record MppChallenge
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("realm")]
    public required string Realm { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("accepted_networks")]
    public IEnumerable<string> AcceptedNetworks { get; set; } = new List<string>();

    [JsonPropertyName("merchant_name")]
    public required string MerchantName { get; set; }

    /// <summary>
    /// Mutually exclusive with jwks_uri
    /// </summary>
    [JsonPropertyName("encryption_jwk")]
    public EncryptionJwk? EncryptionJwk { get; set; }

    /// <summary>
    /// Mutually exclusive with encryption_jwk
    /// </summary>
    [JsonPropertyName("jwks_uri")]
    public string? JwksUri { get; set; }

    /// <summary>
    /// Required when jwks_uri is provided
    /// </summary>
    [JsonPropertyName("kid")]
    public string? Kid { get; set; }

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

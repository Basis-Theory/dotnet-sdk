using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record MppChallenge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

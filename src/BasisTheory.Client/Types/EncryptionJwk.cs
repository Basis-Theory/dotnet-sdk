using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record EncryptionJwk : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

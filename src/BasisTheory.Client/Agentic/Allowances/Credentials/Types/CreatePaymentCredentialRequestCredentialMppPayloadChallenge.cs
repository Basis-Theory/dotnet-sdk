using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[Serializable]
public record CreatePaymentCredentialRequestCredentialMppPayloadChallenge
    : IJsonOnDeserialized,
        IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("realm")]
    public required string Realm { get; set; }

    [JsonPropertyName("method")]
    public required CreatePaymentCredentialRequestCredentialMppPayloadChallengeMethod Method { get; set; }

    [JsonPropertyName("intent")]
    public string Intent { get; set; } = "charge";

    /// <summary>
    /// Unpadded Base64URL-encoded MPP charge request. Card requests must use JSON Canonicalization Scheme.
    /// </summary>
    [JsonPropertyName("request")]
    public required string Request { get; set; }

    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }

    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("opaque")]
    public string? Opaque { get; set; }

    [JsonIgnore]
    public AdditionalProperties AdditionalProperties { get; set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    void IJsonOnSerializing.OnSerializing() =>
        AdditionalProperties.CopyToExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

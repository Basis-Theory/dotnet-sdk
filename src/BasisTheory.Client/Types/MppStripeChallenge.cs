using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record MppStripeChallenge : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    /// <summary>
    /// Challenge identifier issued by the merchant
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Payment method of the challenge — must be `stripe`
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; } = "stripe";

    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>
    /// Challenge intent (e.g. `charge`)
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// base64url-encoded JSON request payload from the merchant's challenge
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>
    /// Challenge expiration timestamp
    /// </summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

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

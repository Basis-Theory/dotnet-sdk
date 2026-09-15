using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record AllowanceVerificationNextActionRedirect : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ceremony this redirect performs. Mastercard managed authentication and Stripe Link's consumer approval are the redirect ceremonies today.
    /// </summary>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; } = "transaction_authentication";

    [JsonPropertyName("uri")]
    public required string Uri { get; set; }

    [JsonPropertyName("uri_type")]
    public string UriType { get; set; } = "WEB_URI";

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

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

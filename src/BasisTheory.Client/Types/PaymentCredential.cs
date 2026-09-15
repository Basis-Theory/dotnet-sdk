using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record PaymentCredential : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("rail")]
    public required string Rail { get; set; }

    [JsonPropertyName("provider")]
    public required PaymentCredentialProvider Provider { get; set; }

    [JsonPropertyName("amount")]
    public required SharedPaymentAmount Amount { get; set; }

    [JsonPropertyName("credential")]
    public required PaymentCredentialCredential Credential { get; set; }

    /// <summary>
    /// Safe provider-native references for support. Never contains a spendable credential.
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public object? ProviderIds { get; set; }

    [JsonPropertyName("expires_at")]
    public required DateTime ExpiresAt { get; set; }

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

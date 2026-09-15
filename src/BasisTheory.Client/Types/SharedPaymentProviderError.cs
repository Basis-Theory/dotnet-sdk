using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record SharedPaymentProviderError : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Stable Agentic Commerce error code.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Stable Basis Theory-controlled summary suitable for display.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Sanitized Basis Theory-controlled remediation guidance suitable for display.
    /// </summary>
    [JsonPropertyName("detail")]
    public required string Detail { get; set; }

    /// <summary>
    /// Who failed. Errors recorded on a payment method or allowance name the rail provider (`vic`, `agentpay`, `stripe`, `link`); errors recorded on a source connection name the connection provider (`stripe_link`). Both appear because one wallet provider can stand behind a rail and a connection with different names.
    /// </summary>
    [JsonPropertyName("provider")]
    public required SharedPaymentProviderErrorProvider Provider { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    [JsonPropertyName("rail")]
    public string? Rail { get; set; }

    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    /// <summary>
    /// Provider-native machine-readable code when available.
    /// </summary>
    [JsonPropertyName("provider_code")]
    public string? ProviderCode { get; set; }

    /// <summary>
    /// Safe provider correlation identifier for support.
    /// </summary>
    [JsonPropertyName("provider_correlation_id")]
    public string? ProviderCorrelationId { get; set; }

    [JsonPropertyName("payment_method_id")]
    public string? PaymentMethodId { get; set; }

    [JsonPropertyName("allowance_id")]
    public string? AllowanceId { get; set; }

    /// <summary>
    /// Generated credential attempt ID; the credential resource may not exist when minting failed.
    /// </summary>
    [JsonPropertyName("payment_credential_id")]
    public string? PaymentCredentialId { get; set; }

    [JsonPropertyName("occurred_at")]
    public required DateTime OccurredAt { get; set; }

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

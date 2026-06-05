using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record ConfirmationEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("transaction_reference_id")]
    public string? TransactionReferenceId { get; set; }

    [JsonPropertyName("transaction_status")]
    public required TransactionStatus TransactionStatus { get; set; }

    [JsonPropertyName("transaction_type")]
    public required TransactionType TransactionType { get; set; }

    [JsonPropertyName("transaction_timestamp")]
    public DateTime? TransactionTimestamp { get; set; }

    [JsonPropertyName("mandates_completed")]
    public bool? MandatesCompleted { get; set; }

    /// <summary>
    /// Transaction amount for Visa confirmation
    /// </summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>
    /// ISO 4217 currency code (e.g. USD)
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

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

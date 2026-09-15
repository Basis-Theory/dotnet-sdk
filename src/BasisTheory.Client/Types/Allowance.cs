using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record Allowance : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("payment_method_id")]
    public string? PaymentMethodId { get; set; }

    /// <summary>
    /// Optional agent attribution. This is informational and is not an authorization grant.
    /// </summary>
    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

    [JsonPropertyName("status")]
    public AllowanceStatus? Status { get; set; }

    [JsonPropertyName("amount")]
    public SharedPaymentAmount? Amount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Merchant the allowance is scoped to. Absent on an open allowance, which supplies a merchant per credential request instead.
    /// </summary>
    [JsonPropertyName("merchant")]
    public SharedPaymentMerchant? Merchant { get; set; }

    [JsonPropertyName("amount_spent")]
    public SharedPaymentAmount? AmountSpent { get; set; }

    [JsonPropertyName("amount_reserved")]
    public SharedPaymentAmount? AmountReserved { get; set; }

    [JsonPropertyName("amount_available")]
    public SharedPaymentAmount? AmountAvailable { get; set; }

    [JsonPropertyName("credentials_count")]
    public int? CredentialsCount { get; set; }

    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    [JsonPropertyName("rails")]
    public IEnumerable<AllowanceRail>? Rails { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

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

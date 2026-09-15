using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record CreateAllowanceRequest
{
    /// <summary>
    /// Optional stable key for safely replaying this create request. Without it, every request creates a new allowance.
    /// </summary>
    [JsonIgnore]
    public string? BtIdempotencyKey { get; set; }

    [JsonPropertyName("payment_method_id")]
    public required string PaymentMethodId { get; set; }

    /// <summary>
    /// Optional attribution to an agent owned by the tenant. This does not authorize the caller; tenant API-key permissions remain the authorization boundary.
    /// </summary>
    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

    [JsonPropertyName("amount")]
    public required SharedPaymentAmount Amount { get; set; }

    /// <summary>
    /// Optional merchant the allowance is scoped to. Omit it to leave the allowance open and supply `merchant` on each credential request instead. Once set it cannot be changed, and a credential request for a merchant-scoped allowance must not send its own `merchant`.
    /// </summary>
    [JsonPropertyName("merchant")]
    public SharedPaymentMerchant? Merchant { get; set; }

    /// <summary>
    /// Customer-facing prompt describing what the allowance permits.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// ISO 8601 timestamp when the allowance expires. Must be in the future.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public required DateTime ExpiresAt { get; set; }

    /// <summary>
    /// Public integration metadata. The JSON-encoded value must not exceed 32 KiB.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record AllowancesUpdateRequest
{
    [JsonPropertyName("amount")]
    public SharedPaymentAmount? Amount { get; set; }

    /// <summary>
    /// Customer-facing prompt describing what the allowance permits.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// ISO 8601 timestamp when the allowance expires. Must be in the future.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

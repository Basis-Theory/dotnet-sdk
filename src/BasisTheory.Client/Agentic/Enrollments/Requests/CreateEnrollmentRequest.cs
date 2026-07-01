using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record CreateEnrollmentRequest
{
    [JsonPropertyName("token_id")]
    public required string TokenId { get; set; }

    [JsonPropertyName("consumer")]
    public required Consumer Consumer { get; set; }

    /// <summary>
    /// Single agent ID (mutually exclusive with agent_ids)
    /// </summary>
    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

    /// <summary>
    /// Multiple agent IDs (mutually exclusive with agent_id)
    /// </summary>
    [JsonPropertyName("agent_ids")]
    public IEnumerable<string>? AgentIds { get; set; }

    /// <summary>
    /// Display label shown to the cardholder during Mastercard managed-authentication challenges. Defaults to "Agent Wallet" when not provided.
    /// </summary>
    [JsonPropertyName("wallet_name")]
    public string? WalletName { get; set; }

    /// <summary>
    /// Enrollment type. `agentic` (default) enrolls the card for agent-driven payments and requires verification.
    /// `autofill` enrolls the card for direct autofill credential retrieval, skips verification, and is currently
    /// available to test tenants only.
    /// `spt` enrolls the card for shared payment tokens, requires `provider` to be set, skips verification, and
    /// activates immediately.
    /// </summary>
    [JsonPropertyName("type")]
    public CreateEnrollmentRequestType? Type { get; set; }

    /// <summary>
    /// Token provider for `spt` enrollments. Required when `type` is `spt`; not allowed otherwise.
    /// </summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

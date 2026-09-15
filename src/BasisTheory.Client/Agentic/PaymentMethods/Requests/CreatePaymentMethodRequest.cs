using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record CreatePaymentMethodRequest
{
    /// <summary>
    /// Optional stable key for safely replaying this create request.
    /// </summary>
    [JsonIgnore]
    public string? BtIdempotencyKey { get; set; }

    [JsonPropertyName("source")]
    public required object Source { get; set; }

    [JsonPropertyName("consumer")]
    public required SharedPaymentConsumer Consumer { get; set; }

    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

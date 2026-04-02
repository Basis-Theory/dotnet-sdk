using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

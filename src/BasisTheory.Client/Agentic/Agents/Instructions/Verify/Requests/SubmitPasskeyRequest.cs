using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

[Serializable]
public record SubmitPasskeyRequest
{
    /// <summary>
    /// Visa format (identifier, dfp_session_id, fido_assertion_data) or Mastercard format (flexible object)
    /// </summary>
    [JsonPropertyName("assurance_data")]
    public object AssuranceData { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("src_correlation_id")]
    public string? SrcCorrelationId { get; set; }

    [JsonPropertyName("flow_id")]
    public string? FlowId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

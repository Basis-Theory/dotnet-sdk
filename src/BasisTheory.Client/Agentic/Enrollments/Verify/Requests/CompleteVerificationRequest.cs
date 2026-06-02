using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Enrollments;

[Serializable]
public record CompleteVerificationRequest
{
    [JsonPropertyName("assurance_data")]
    public object? AssuranceData { get; set; }

    [JsonPropertyName("src_correlation_id")]
    public string? SrcCorrelationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

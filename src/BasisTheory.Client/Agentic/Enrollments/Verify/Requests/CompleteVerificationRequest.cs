using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

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

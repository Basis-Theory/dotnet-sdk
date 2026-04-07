using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents;

[Serializable]
public record CreateInstructionRequest
{
    [JsonPropertyName("enrollment_id")]
    public required string EnrollmentId { get; set; }

    [JsonPropertyName("amount")]
    public required Amount Amount { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("expires_at")]
    public required DateTime ExpiresAt { get; set; }

    [JsonPropertyName("assurance_data")]
    public object? AssuranceData { get; set; }

    [JsonPropertyName("recurring")]
    public Recurring? Recurring { get; set; }

    [JsonPropertyName("instance_details")]
    public InstanceDetails? InstanceDetails { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

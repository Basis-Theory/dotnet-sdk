using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record UpdateAgentRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("enrollment_ids")]
    public IEnumerable<string>? EnrollmentIds { get; set; }

    [JsonPropertyName("instance_details")]
    public InstanceDetails? InstanceDetails { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

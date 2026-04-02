using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record CreateAgentRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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

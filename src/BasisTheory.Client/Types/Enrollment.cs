using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record Enrollment
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Basis Theory card token ID used for enrollment
    /// </summary>
    [JsonPropertyName("token_id")]
    public string? TokenId { get; set; }

    [JsonPropertyName("provider")]
    public EnrollmentProvider? Provider { get; set; }

    [JsonPropertyName("status")]
    public EnrollmentStatus? Status { get; set; }

    [JsonPropertyName("card")]
    public AgenticCard? Card { get; set; }

    [JsonPropertyName("agent_ids")]
    public IEnumerable<string>? AgentIds { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

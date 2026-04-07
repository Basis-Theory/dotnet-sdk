using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record MppSource
{
    [JsonPropertyName("type")]
    public required MppSourceType Type { get; set; }

    /// <summary>
    /// Token ID (required for token, network_token, apple_pay, google_pay)
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Enrollment ID (VIC only, mutually exclusive with id)
    /// </summary>
    [JsonPropertyName("enrollment_id")]
    public string? EnrollmentId { get; set; }

    /// <summary>
    /// Required for VIC with token id
    /// </summary>
    [JsonPropertyName("consumer")]
    public Consumer? Consumer { get; set; }

    /// <summary>
    /// Agent ID (VIC only)
    /// </summary>
    [JsonPropertyName("agent_id")]
    public string? AgentId { get; set; }

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

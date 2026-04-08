using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents;

[Serializable]
public record UpdateInstructionRequest
{
    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

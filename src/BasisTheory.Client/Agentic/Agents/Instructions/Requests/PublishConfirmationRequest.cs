using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Agents;

[Serializable]
public record PublishConfirmationRequest
{
    [JsonPropertyName("confirmation_data")]
    public IEnumerable<ConfirmationEntry> ConfirmationData { get; set; } =
        new List<ConfirmationEntry>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

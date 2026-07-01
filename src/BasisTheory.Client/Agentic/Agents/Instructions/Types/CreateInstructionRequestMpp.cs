using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Agents;

/// <summary>
/// MPP mode — provide the merchant's MPP challenge to receive an MPP credential from the
/// credentials endpoint instead of a raw shared payment token ID. The challenge must carry
/// Stripe values (`method: stripe`). Only valid for `spt` (Stripe) enrollments.
/// </summary>
[Serializable]
public record CreateInstructionRequestMpp : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("challenge")]
    public required MppStripeChallenge Challenge { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

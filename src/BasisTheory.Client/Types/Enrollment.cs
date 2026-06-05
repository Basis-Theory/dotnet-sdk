using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record Enrollment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    /// <summary>
    /// Display label shown to the cardholder during Mastercard managed-authentication challenges.
    /// </summary>
    [JsonPropertyName("wallet_name")]
    public string? WalletName { get; set; }

    /// <summary>
    /// Enrollment type — `agentic` (default) for agent-driven payments, `autofill` for direct credential autofill.
    /// </summary>
    [JsonPropertyName("type")]
    public EnrollmentType? Type { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

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

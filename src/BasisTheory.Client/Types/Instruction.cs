using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record Instruction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("enrollment_id")]
    public string? EnrollmentId { get; set; }

    [JsonPropertyName("status")]
    public InstructionStatus? Status { get; set; }

    /// <summary>
    /// Inherited from the parent enrollment. `agentic` instructions require cardholder
    /// verification before credentials can be retrieved; `autofill` instructions are
    /// auto-approved on creation and credentials can be retrieved immediately; `spt`
    /// instructions create a shared payment token that is approved on creation.
    /// </summary>
    [JsonPropertyName("type")]
    public InstructionType? Type { get; set; }

    /// <summary>
    /// Indicates the shape the credentials endpoint returns for this instruction:
    /// `card` (Visa/Mastercard virtual card credentials), `spt` (Stripe shared payment
    /// token ID), or `mpp` (MPP credential built from the challenge provided at creation).
    /// </summary>
    [JsonPropertyName("credential_type")]
    public InstructionCredentialType? CredentialType { get; set; }

    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("recurring")]
    public Recurring? Recurring { get; set; }

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

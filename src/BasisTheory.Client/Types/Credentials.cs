using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Credential payload for the instruction. Exactly one of `card`, `spt`, or `mpp` is present:
/// `card` for Visa/Mastercard virtual card credentials, `spt` for Stripe shared payment token
/// instructions (raw mode), `mpp` for Stripe instructions created with an MPP challenge.
/// </summary>
[Serializable]
public record Credentials : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("card")]
    public CredentialsCard? Card { get; set; }

    /// <summary>
    /// Stripe shared payment token (raw mode)
    /// </summary>
    [JsonPropertyName("spt")]
    public CredentialsSpt? Spt { get; set; }

    /// <summary>
    /// MPP credential (MPP mode)
    /// </summary>
    [JsonPropertyName("mpp")]
    public CredentialsMpp? Mpp { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }

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

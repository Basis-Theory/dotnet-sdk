using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Present when status is redirect_required (Mastercard Managed Authentication). The cardholder must be redirected to `redirect.uri` to complete authentication; once they return via the hosted callback the SDK can call `/verify/complete` (enrollment) or `/verify/passkey` (instruction) to finalise.
/// </summary>
[Serializable]
public record VerificationResponseRedirect : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// URL the cardholder must be redirected to.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    [JsonPropertyName("uri_type")]
    public VerificationResponseRedirectUriType? UriType { get; set; }

    /// <summary>
    /// When the authentication session expires (ISO 8601).
    /// </summary>
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

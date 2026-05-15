using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

/// <summary>
/// Present when status is redirect_required (Mastercard Managed Authentication). The cardholder must be redirected to `redirect.uri` to complete authentication; once they return via the hosted callback the SDK can call `/verify/complete` (enrollment) or `/verify/passkey` (instruction) to finalise.
/// </summary>
[Serializable]
public record VerificationResponseRedirect
{
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

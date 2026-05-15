using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record VerificationResponse
{
    [JsonPropertyName("status")]
    public VerificationResponseStatus? Status { get; set; }

    /// <summary>
    /// Present when status is redirect_required (Mastercard Managed Authentication). The cardholder must be redirected to `redirect.uri` to complete authentication; once they return via the hosted callback the SDK can call `/verify/complete` (enrollment) or `/verify/passkey` (instruction) to finalise.
    /// </summary>
    [JsonPropertyName("redirect")]
    public VerificationResponseRedirect? Redirect { get; set; }

    [JsonPropertyName("methods")]
    public IEnumerable<VerificationResponseMethodsItem>? Methods { get; set; }

    /// <summary>
    /// Visa passkey/FIDO context for device binding or authentication
    /// </summary>
    [JsonPropertyName("passkey_context")]
    public VerificationResponsePasskeyContext? PasskeyContext { get; set; }

    /// <summary>
    /// Card network brand (present in Mastercard responses)
    /// </summary>
    [JsonPropertyName("brand")]
    public VerificationResponseBrand? Brand { get; set; }

    /// <summary>
    /// Mastercard authentication context
    /// </summary>
    [JsonPropertyName("auth_context")]
    public object? AuthContext { get; set; }

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

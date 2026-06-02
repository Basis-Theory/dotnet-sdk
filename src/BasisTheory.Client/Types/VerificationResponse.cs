using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record VerificationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

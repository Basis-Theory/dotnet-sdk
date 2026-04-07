using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record VerificationResponse
{
    [JsonPropertyName("status")]
    public VerificationResponseStatus? Status { get; set; }

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

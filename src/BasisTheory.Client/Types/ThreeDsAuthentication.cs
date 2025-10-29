using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record ThreeDsAuthentication
{
    [JsonPropertyName("pan_token_id")]
    public string? PanTokenId { get; set; }

    [JsonPropertyName("token_id")]
    public string? TokenId { get; set; }

    [JsonPropertyName("token_intent_id")]
    public string? TokenIntentId { get; set; }

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    [JsonPropertyName("threeds_version")]
    public string? ThreedsVersion { get; set; }

    [JsonPropertyName("acs_transaction_id")]
    public string? AcsTransactionId { get; set; }

    [JsonPropertyName("acs_operator_id")]
    public string? AcsOperatorId { get; set; }

    [JsonPropertyName("ds_transaction_id")]
    public string? DsTransactionId { get; set; }

    [JsonPropertyName("sdk_transaction_id")]
    public string? SdkTransactionId { get; set; }

    [JsonPropertyName("acs_reference_number")]
    public string? AcsReferenceNumber { get; set; }

    [JsonPropertyName("ds_reference_number")]
    public string? DsReferenceNumber { get; set; }

    [JsonPropertyName("liability_shifted")]
    public bool? LiabilityShifted { get; set; }

    [JsonPropertyName("authentication_value")]
    public string? AuthenticationValue { get; set; }

    [JsonPropertyName("authentication_status")]
    public string? AuthenticationStatus { get; set; }

    [JsonPropertyName("authentication_status_code")]
    public string? AuthenticationStatusCode { get; set; }

    [JsonPropertyName("directory_status_code")]
    public string? DirectoryStatusCode { get; set; }

    [JsonPropertyName("authentication_status_reason")]
    public string? AuthenticationStatusReason { get; set; }

    [JsonPropertyName("authentication_status_reason_code")]
    public string? AuthenticationStatusReasonCode { get; set; }

    [JsonPropertyName("eci")]
    public string? Eci { get; set; }

    [JsonPropertyName("acs_challenge_mandated")]
    public string? AcsChallengeMandated { get; set; }

    [JsonPropertyName("acs_decoupled_authentication")]
    public string? AcsDecoupledAuthentication { get; set; }

    [JsonPropertyName("authentication_challenge_type")]
    public string? AuthenticationChallengeType { get; set; }

    [JsonPropertyName("acs_rendering_type")]
    public ThreeDsAcsRenderingType? AcsRenderingType { get; set; }

    [JsonPropertyName("acs_signed_content")]
    public string? AcsSignedContent { get; set; }

    [JsonPropertyName("acs_challenge_url")]
    public string? AcsChallengeUrl { get; set; }

    [JsonPropertyName("challenge_preference")]
    public string? ChallengePreference { get; set; }

    [JsonPropertyName("challenge_preference_code")]
    public string? ChallengePreferenceCode { get; set; }

    [JsonPropertyName("challenge_attempts")]
    public string? ChallengeAttempts { get; set; }

    [JsonPropertyName("challenge_cancel_reason")]
    public string? ChallengeCancelReason { get; set; }

    [JsonPropertyName("challenge_cancel_reason_code")]
    public string? ChallengeCancelReasonCode { get; set; }

    [JsonPropertyName("cardholder_info")]
    public string? CardholderInfo { get; set; }

    [JsonPropertyName("whitelist_status")]
    public string? WhitelistStatus { get; set; }

    [JsonPropertyName("whitelist_status_source")]
    public string? WhitelistStatusSource { get; set; }

    [JsonPropertyName("message_extensions")]
    public IEnumerable<ThreeDsMessageExtension>? MessageExtensions { get; set; }

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

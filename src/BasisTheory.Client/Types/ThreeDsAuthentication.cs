using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsAuthentication
{
    [JsonPropertyName("pan_token_id")]
    public string? PanTokenId { get; set; }

    [JsonPropertyName("threeds_version")]
    public string? ThreedsVersion { get; set; }

    [JsonPropertyName("acs_transaction_id")]
    public string? AcsTransactionId { get; set; }

    [JsonPropertyName("ds_transaction_id")]
    public string? DsTransactionId { get; set; }

    [JsonPropertyName("sdk_transaction_id")]
    public string? SdkTransactionId { get; set; }

    [JsonPropertyName("acs_reference_number")]
    public string? AcsReferenceNumber { get; set; }

    [JsonPropertyName("ds_reference_number")]
    public string? DsReferenceNumber { get; set; }

    [JsonPropertyName("authentication_value")]
    public string? AuthenticationValue { get; set; }

    [JsonPropertyName("authentication_status")]
    public string? AuthenticationStatus { get; set; }

    [JsonPropertyName("authentication_status_code")]
    public string? AuthenticationStatusCode { get; set; }

    [JsonPropertyName("authentication_status_reason")]
    public string? AuthenticationStatusReason { get; set; }

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

    [JsonPropertyName("challenge_attempts")]
    public string? ChallengeAttempts { get; set; }

    [JsonPropertyName("challenge_cancel_reason")]
    public string? ChallengeCancelReason { get; set; }

    [JsonPropertyName("cardholder_info")]
    public string? CardholderInfo { get; set; }

    [JsonPropertyName("whitelist_status")]
    public string? WhitelistStatus { get; set; }

    [JsonPropertyName("whitelist_status_source")]
    public string? WhitelistStatusSource { get; set; }

    [JsonPropertyName("message_extensions")]
    public IEnumerable<ThreeDsMessageExtension>? MessageExtensions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

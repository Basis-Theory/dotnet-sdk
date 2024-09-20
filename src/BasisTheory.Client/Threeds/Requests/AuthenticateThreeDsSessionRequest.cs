using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AuthenticateThreeDsSessionRequest
{
    [JsonPropertyName("authentication_category")]
    public required string AuthenticationCategory { get; set; }

    [JsonPropertyName("authentication_type")]
    public required string AuthenticationType { get; set; }

    [JsonPropertyName("challenge_preference")]
    public string? ChallengePreference { get; set; }

    [JsonPropertyName("purchase_info")]
    public ThreeDsPurchaseInfo? PurchaseInfo { get; set; }

    [JsonPropertyName("merchant_info")]
    public ThreeDsMerchantInfo? MerchantInfo { get; set; }

    [JsonPropertyName("requestor_info")]
    public required ThreeDsRequestorInfo RequestorInfo { get; set; }

    [JsonPropertyName("cardholder_info")]
    public ThreeDsCardholderInfo? CardholderInfo { get; set; }

    [JsonPropertyName("broadcast_info")]
    public object? BroadcastInfo { get; set; }

    [JsonPropertyName("message_extensions")]
    public IEnumerable<ThreeDsMessageExtension>? MessageExtensions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

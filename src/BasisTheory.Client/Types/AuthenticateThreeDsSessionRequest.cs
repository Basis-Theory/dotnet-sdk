using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record AuthenticateThreeDsSessionRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("authentication_category")]
    public required string AuthenticationCategory { get; set; }

    [JsonPropertyName("authentication_type")]
    public required string AuthenticationType { get; set; }

    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; set; }

    [JsonPropertyName("challenge_preference")]
    public string? ChallengePreference { get; set; }

    [JsonPropertyName("request_decoupled_challenge")]
    public bool? RequestDecoupledChallenge { get; set; }

    [JsonPropertyName("decoupled_challenge_max_time")]
    public int? DecoupledChallengeMaxTime { get; set; }

    [JsonPropertyName("purchase_info")]
    public ThreeDsPurchaseInfo? PurchaseInfo { get; set; }

    [JsonPropertyName("merchant_info")]
    public ThreeDsMerchantInfo? MerchantInfo { get; set; }

    [JsonPropertyName("requestor_info")]
    public ThreeDsRequestorInfo? RequestorInfo { get; set; }

    [JsonPropertyName("cardholder_info")]
    public ThreeDsCardholderInfo? CardholderInfo { get; set; }

    [JsonPropertyName("broadcast_info")]
    public object? BroadcastInfo { get; set; }

    [JsonPropertyName("message_extensions")]
    public IEnumerable<ThreeDsMessageExtension>? MessageExtensions { get; set; }

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

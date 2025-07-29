using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record AuthenticationResponse
{
    [JsonPropertyName("merchant_identifier")]
    public string? MerchantIdentifier { get; set; }

    [JsonPropertyName("authentication_data")]
    public string? AuthenticationData { get; set; }

    [JsonPropertyName("transaction_amount")]
    public string? TransactionAmount { get; set; }

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

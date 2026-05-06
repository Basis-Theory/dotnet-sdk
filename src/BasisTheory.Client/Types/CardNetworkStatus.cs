using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record CardNetworkStatus
{
    [JsonPropertyName("visa")]
    public NetworkStatusDetail? Visa { get; set; }

    [JsonPropertyName("mastercard")]
    public NetworkStatusDetail? Mastercard { get; set; }

    [JsonPropertyName("amex")]
    public NetworkStatusDetail? Amex { get; set; }

    [JsonPropertyName("discover")]
    public NetworkStatusDetail? Discover { get; set; }

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

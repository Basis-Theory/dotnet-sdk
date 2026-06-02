using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Tenants;

[Serializable]
public record ServiceOnboardingRequest
{
    [JsonPropertyName("account_updater")]
    public IEnumerable<string>? AccountUpdater { get; set; }

    [JsonPropertyName("network_token")]
    public IEnumerable<string>? NetworkToken { get; set; }

    [JsonPropertyName("agentic_commerce")]
    public IEnumerable<string>? AgenticCommerce { get; set; }

    [JsonPropertyName("card_network_info")]
    public CardNetworkInfo? CardNetworkInfo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

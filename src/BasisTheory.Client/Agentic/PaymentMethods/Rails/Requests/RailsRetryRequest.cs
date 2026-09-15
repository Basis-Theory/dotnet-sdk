using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.PaymentMethods;

[Serializable]
public record RailsRetryRequest
{
    [JsonPropertyName("rail")]
    public required RailsRetryRequestRail Rail { get; set; }

    [JsonPropertyName("provider")]
    public required RailsRetryRequestProvider Provider { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

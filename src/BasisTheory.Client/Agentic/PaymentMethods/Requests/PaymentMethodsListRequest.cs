using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record PaymentMethodsListRequest
{
    [JsonIgnore]
    public int? Size { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    /// <summary>
    /// Optional consumer UUID to list payment methods for one customer.
    /// </summary>
    [JsonIgnore]
    public string? ConsumerId { get; set; }

    /// <summary>
    /// Resource status filter. Defaults to active.
    /// </summary>
    [JsonIgnore]
    public PaymentMethodsListRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

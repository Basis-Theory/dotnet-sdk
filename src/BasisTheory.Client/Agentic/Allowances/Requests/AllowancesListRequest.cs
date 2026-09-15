using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record AllowancesListRequest
{
    [JsonIgnore]
    public int? Size { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    /// <summary>
    /// Optional payment method ID to list its allowances.
    /// </summary>
    [JsonIgnore]
    public string? PaymentMethodId { get; set; }

    /// <summary>
    /// Derived resource status filter. Defaults to active.
    /// </summary>
    [JsonIgnore]
    public AllowancesListRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic.Allowances;

[Serializable]
public record CreatePaymentCredentialRequest
{
    /// <summary>
    /// Optional stable key for detecting retries. A successful bearer credential cannot be replayed.
    /// </summary>
    [JsonIgnore]
    public string? BtIdempotencyKey { get; set; }

    [JsonPropertyName("rail")]
    public required CreatePaymentCredentialRequestRail Rail { get; set; }

    [JsonPropertyName("provider")]
    public required CreatePaymentCredentialRequestProvider Provider { get; set; }

    [JsonPropertyName("amount")]
    public SharedPaymentAmount? Amount { get; set; }

    /// <summary>
    /// Merchant this credential is being minted for. Required when the allowance has no `merchant`, and rejected when it does — the allowance's merchant is the scope the cardholder verified against, so a mint can neither restate nor replace it. Required on every rail for consistency. At mint Visa (`vic`) forwards it to the network, and Stripe Link (`link`) names it on the spend request the consumer sees.
    /// </summary>
    [JsonPropertyName("merchant")]
    public SharedPaymentMerchant? Merchant { get; set; }

    [JsonPropertyName("credential")]
    public required object Credential { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

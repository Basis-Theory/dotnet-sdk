using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsPurchaseInfo
{
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("exponent")]
    public string? Exponent { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("transaction_type")]
    public string? TransactionType { get; set; }

    [JsonPropertyName("installment_count")]
    public string? InstallmentCount { get; set; }

    [JsonPropertyName("recurring_expiration")]
    public string? RecurringExpiration { get; set; }

    [JsonPropertyName("recurring_frequency")]
    public string? RecurringFrequency { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenReport
{
    [JsonPropertyName("included_monthly_active_tokens")]
    public long? IncludedMonthlyActiveTokens { get; set; }

    [JsonPropertyName("monthly_active_tokens")]
    public long? MonthlyActiveTokens { get; set; }

    [JsonPropertyName("metrics_by_type")]
    public Dictionary<string, TokenMetrics?>? MetricsByType { get; set; }

    [JsonPropertyName("total_tokens")]
    public long? TotalTokens { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

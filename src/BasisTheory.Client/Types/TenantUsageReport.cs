using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TenantUsageReport
{
    [JsonPropertyName("total_tokens")]
    public long? TotalTokens { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

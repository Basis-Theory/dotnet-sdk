using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TenantUsageReport
{
    [JsonPropertyName("token_report")]
    public TokenReport? TokenReport { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

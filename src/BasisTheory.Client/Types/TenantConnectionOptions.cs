using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TenantConnectionOptions
{
    [JsonPropertyName("domain_aliases")]
    public IEnumerable<string>? DomainAliases { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Tenants;

public record CreateTenantConnectionRequest
{
    [JsonPropertyName("strategy")]
    public required string Strategy { get; set; }

    [JsonPropertyName("options")]
    public required TenantConnectionOptions Options { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

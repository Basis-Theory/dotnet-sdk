using System.Text.Json.Serialization;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public record CreateTenantConnectionRequest
{
    [JsonPropertyName("strategy")]
    public required string Strategy { get; set; }

    [JsonPropertyName("options")]
    public required TenantConnectionOptions Options { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

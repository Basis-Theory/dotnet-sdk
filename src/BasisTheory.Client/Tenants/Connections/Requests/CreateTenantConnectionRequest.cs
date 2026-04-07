using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Tenants;

[Serializable]
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

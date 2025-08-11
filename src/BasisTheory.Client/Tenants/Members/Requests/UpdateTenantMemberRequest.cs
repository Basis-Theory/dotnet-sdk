using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

[Serializable]
public record UpdateTenantMemberRequest
{
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

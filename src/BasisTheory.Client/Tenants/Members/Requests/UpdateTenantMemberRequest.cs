using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Tenants;

public record UpdateTenantMemberRequest
{
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

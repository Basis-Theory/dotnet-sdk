using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

[Serializable]
public record CreateTenantInvitationRequest
{
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

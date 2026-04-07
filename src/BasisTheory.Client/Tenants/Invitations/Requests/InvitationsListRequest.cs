using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Tenants;

[Serializable]
public record InvitationsListRequest
{
    [JsonIgnore]
    public TenantInvitationStatus? Status { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    [JsonIgnore]
    public int? Size { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

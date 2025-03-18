using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public record InvitationsListRequest
{
    public TenantInvitationStatus? Status { get; set; }

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

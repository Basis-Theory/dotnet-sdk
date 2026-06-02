using global::BasisTheory.Client.Tenants;

namespace BasisTheory.Client;

public partial interface ITenantsClient
{
    public ISecurityContactClient SecurityContact { get; }
    public IConnectionsClient Connections { get; }
    public IInvitationsClient Invitations { get; }
    public IMembersClient Members { get; }
    public IMerchantsClient Merchants { get; }
    public IOwnerClient Owner { get; }
    public ISelfClient Self { get; }
    WithRawResponseTask<TenantMemberResponse> OwnerTransferAsync(
        TransferTenantOwnerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

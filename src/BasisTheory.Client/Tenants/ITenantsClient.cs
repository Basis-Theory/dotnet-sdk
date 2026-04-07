namespace BasisTheory.Client.Tenants;

public partial interface ITenantsClient
{
    public ISecurityContactClient SecurityContact { get; }
    public IConnectionsClient Connections { get; }
    public IInvitationsClient Invitations { get; }
    public IMembersClient Members { get; }
    public IOwnerClient Owner { get; }
    public ISelfClient Self { get; }
}

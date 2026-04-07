using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public partial class TenantsClient : ITenantsClient
{
    private readonly RawClient _client;

    internal TenantsClient(RawClient client)
    {
        _client = client;
        SecurityContact = new SecurityContactClient(_client);
        Connections = new ConnectionsClient(_client);
        Invitations = new InvitationsClient(_client);
        Members = new MembersClient(_client);
        Owner = new OwnerClient(_client);
        Self = new SelfClient(_client);
    }

    public ISecurityContactClient SecurityContact { get; }

    public IConnectionsClient Connections { get; }

    public IInvitationsClient Invitations { get; }

    public IMembersClient Members { get; }

    public IOwnerClient Owner { get; }

    public ISelfClient Self { get; }
}

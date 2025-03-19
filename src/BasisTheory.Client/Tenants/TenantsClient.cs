using BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public partial class TenantsClient
{
    private RawClient _client;

    internal TenantsClient(RawClient client)
    {
        _client = client;
        Connections = new ConnectionsClient(_client);
        Invitations = new InvitationsClient(_client);
        Members = new MembersClient(_client);
        Owner = new OwnerClient(_client);
        Self = new SelfClient(_client);
    }

    public ConnectionsClient Connections { get; }

    public InvitationsClient Invitations { get; }

    public MembersClient Members { get; }

    public OwnerClient Owner { get; }

    public SelfClient Self { get; }
}

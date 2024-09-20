using BasisTheory.Client.Core;

#nullable enable

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
        Self = new SelfClient(_client);
    }

    public ConnectionsClient Connections { get; }

    public InvitationsClient Invitations { get; }

    public MembersClient Members { get; }

    public SelfClient Self { get; }
}

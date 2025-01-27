using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Connections;

public partial class ConnectionsClient
{
    private RawClient _client;

    internal ConnectionsClient(RawClient client)
    {
        _client = client;
        Googlepay = new GooglepayClient(_client);
    }

    public GooglepayClient Googlepay { get; }
}

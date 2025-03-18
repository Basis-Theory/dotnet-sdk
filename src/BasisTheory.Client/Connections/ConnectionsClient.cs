using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Connections;

public partial class ConnectionsClient
{
    private RawClient _client;

    internal ConnectionsClient(RawClient client)
    {
        _client = client;
        ApplePay = new ApplePayClient(_client);
    }

    public ApplePayClient ApplePay { get; }
}

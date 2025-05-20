using BasisTheory.Client.Core;

namespace BasisTheory.Client.Connection;

public partial class ConnectionClient
{
    private RawClient _client;

    internal ConnectionClient(RawClient client)
    {
        _client = client;
        ApplePay = new ApplePayClient(_client);
    }

    public ApplePayClient ApplePay { get; }
}

using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Threeds;

public partial class ThreedsClient
{
    private RawClient _client;

    internal ThreedsClient(RawClient client)
    {
        _client = client;
        Sessions = new SessionsClient(_client);
    }

    public SessionsClient Sessions { get; }
}

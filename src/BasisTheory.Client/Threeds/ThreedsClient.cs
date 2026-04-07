using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Threeds;

public partial class ThreedsClient : IThreedsClient
{
    private readonly RawClient _client;

    internal ThreedsClient(RawClient client)
    {
        _client = client;
        Sessions = new SessionsClient(_client);
    }

    public ISessionsClient Sessions { get; }
}

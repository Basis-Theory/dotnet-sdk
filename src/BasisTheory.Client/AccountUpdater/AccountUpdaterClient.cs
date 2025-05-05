using BasisTheory.Client.Core;

namespace BasisTheory.Client.AccountUpdater;

public partial class AccountUpdaterClient
{
    private RawClient _client;

    internal AccountUpdaterClient(RawClient client)
    {
        _client = client;
        Jobs = new JobsClient(_client);
        RealTime = new RealTimeClient(_client);
    }

    public JobsClient Jobs { get; }

    public RealTimeClient RealTime { get; }
}

using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.AccountUpdater;

public partial class AccountUpdaterClient : IAccountUpdaterClient
{
    private readonly RawClient _client;

    internal AccountUpdaterClient(RawClient client)
    {
        _client = client;
        Jobs = new JobsClient(_client);
        RealTime = new RealTimeClient(_client);
    }

    public IJobsClient Jobs { get; }

    public IRealTimeClient RealTime { get; }
}

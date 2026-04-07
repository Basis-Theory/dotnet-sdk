namespace BasisTheory.Client.AccountUpdater;

public partial interface IAccountUpdaterClient
{
    public IJobsClient Jobs { get; }
    public IRealTimeClient RealTime { get; }
}

using global::BasisTheory.Client;

namespace BasisTheory.Client.AccountUpdater;

public partial interface IJobsClient
{
    /// <summary>
    /// Returns the account updater batch job
    /// </summary>
    WithRawResponseTask<AccountUpdaterJob> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of account updater batch jobs
    /// </summary>
    WithRawResponseTask<AccountUpdaterJobList> ListAsync(
        JobsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the created account updater batch job
    /// </summary>
    WithRawResponseTask<AccountUpdaterJob> CreateAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

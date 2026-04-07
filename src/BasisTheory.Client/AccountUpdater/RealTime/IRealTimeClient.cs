using global::BasisTheory.Client;

namespace BasisTheory.Client.AccountUpdater;

public partial interface IRealTimeClient
{
    /// <summary>
    /// Returns the update result
    /// </summary>
    WithRawResponseTask<AccountUpdaterRealTimeResponse> InvokeAsync(
        AccountUpdaterRealTimeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

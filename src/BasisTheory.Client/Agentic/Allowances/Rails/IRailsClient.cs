using global::BasisTheory.Client;

namespace BasisTheory.Client.Agentic.Allowances;

public partial interface IRailsClient
{
    /// <summary>
    /// Re-run provider setup for one failed allowance rail. Allowance creation keeps rails that failed at the provider, so a transient outage does not require rebuilding the mandate. Only rails with status `error` can be retried, and the payment method's matching rail must still be `enabled`.
    /// </summary>
    WithRawResponseTask<Allowance> RetryAsync(
        string allowanceId,
        RailsRetryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

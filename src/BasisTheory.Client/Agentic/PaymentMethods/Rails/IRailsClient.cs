using global::BasisTheory.Client;

namespace BasisTheory.Client.Agentic.PaymentMethods;

public partial interface IRailsClient
{
    /// <summary>
    /// Retry one payment method rail after pending or failed provisioning. Public and private applications may call this operation with `agentic:payment-method:create`.
    /// </summary>
    WithRawResponseTask<PaymentMethod> RetryAsync(
        string paymentMethodId,
        RailsRetryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

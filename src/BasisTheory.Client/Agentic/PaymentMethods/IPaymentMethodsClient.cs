using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial interface IPaymentMethodsClient
{
    public global::BasisTheory.Client.Agentic.PaymentMethods.IRailsClient Rails { get; }

    /// <summary>
    /// Lists shared payment methods for the current tenant. Defaults to active resources; use `status=all` for a complete Portal history. Server-side page filling prevents sparse pages when filtering by status.
    /// </summary>
    Task<Pager<PaymentMethod>> ListAsync(
        PaymentMethodsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a shared payment method from a funding source — a Basis Theory card token, or an instrument reached through a source connection — and provision the rails that source is eligible for. Public and private applications may call this operation with `agentic:payment-method:create`. Supply BT-IDEMPOTENCY-KEY to make matching retries return the same resource. Without it, every request is a new create operation.
    /// </summary>
    WithRawResponseTask<PaymentMethod> CreateAsync(
        CreatePaymentMethodRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PaymentMethod> GetAsync(
        string paymentMethodId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a payment method and revoke everything downstream - every allowance backed by it is cancelled (including network-side purchase instructions) and no further verification or credential minting is possible.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        string paymentMethodId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists sanitized provider failures for a payment method and its downstream operations. Raw provider bodies and card data are never returned.
    /// </summary>
    Task<Pager<SharedPaymentProviderError>> ErrorsAsync(
        string paymentMethodId,
        PaymentMethodsErrorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

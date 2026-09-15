using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial interface IAllowancesClient
{
    public global::BasisTheory.Client.Agentic.Allowances.IRailsClient Rails { get; }
    public global::BasisTheory.Client.Agentic.Allowances.ICredentialsClient Credentials { get; }

    /// <summary>
    /// Lists allowances for the current tenant. Defaults to active, unexpired resources; use `status=all` for a complete Portal history. Results can be scoped to one payment method, and server-side page filling prevents sparse pages when filtering by status.
    /// </summary>
    Task<Pager<Allowance>> ListAsync(
        AllowancesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a spending allowance from a payment method. Supply `merchant` to scope the mandate to one merchant, or omit it to leave the allowance open and name a merchant on each credential request instead. The payment method must have at least one enabled rail; otherwise the request returns `NO_ACTIVE_RAILS`.
    /// </summary>
    WithRawResponseTask<Allowance> CreateAsync(
        CreateAllowanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Allowance> GetAsync(
        string allowanceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel an allowance so new credentials cannot be created from it. Network-side purchase instructions held by its rails are cancelled with the provider.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        string allowanceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates one or more mutable fields by changing the provider-side mandate first, then committing the same amount, prompt, and expiry locally. Mints are blocked while the update is in flight, and an empty request body is rejected.
    /// </summary>
    WithRawResponseTask<Allowance> UpdateAsync(
        string allowanceId,
        AllowancesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists sanitized provider failures for an allowance, including failed verification and credential attempts. Raw provider bodies and card data are never returned.
    /// </summary>
    Task<Pager<SharedPaymentProviderError>> ErrorsAsync(
        string allowanceId,
        AllowancesErrorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Start or continue self-served verification for a rail that requires it. Public and private applications may call this operation with `agentic:allowance:verify`; browser clients should use a public application key. Visa verification is advanced through explicit ceremony actions. Mastercard managed authentication is finalized with `complete` after the hosted ceremony; callback delivery is only a browser signal and is not required.
    /// </summary>
    WithRawResponseTask<AllowanceVerificationResponse> VerifyAsync(
        string allowanceId,
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

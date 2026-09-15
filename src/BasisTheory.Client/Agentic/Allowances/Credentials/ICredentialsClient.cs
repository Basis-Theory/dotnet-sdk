using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Allowances;

public partial interface ICredentialsClient
{
    /// <summary>
    /// List credential metadata for an allowance. Responses contain metadata only — never card numbers, SPT values, or MPP payloads.
    /// </summary>
    Task<Pager<PaymentCredentialMetadata>> ListAsync(
        string allowanceId,
        CredentialsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a spend credential from an allowance. Supply BT-IDEMPOTENCY-KEY for retry protection. Without it, every request is a new mint and may spend the allowance again.
    /// </summary>
    WithRawResponseTask<PaymentCredential> CreateAsync(
        string allowanceId,
        CreatePaymentCredentialRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get credential metadata. The credential payload itself (card number, SPT, MPP token) is only ever returned by the create call.
    /// </summary>
    WithRawResponseTask<PaymentCredentialMetadata> GetAsync(
        string allowanceId,
        string credentialId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

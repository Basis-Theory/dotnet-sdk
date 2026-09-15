using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial interface IPaymentCredentialsClient
{
    /// <summary>
    /// Lists credential metadata across the tenant for Portal history. Spendable card, SPT, and MPP payloads are never returned.
    /// </summary>
    Task<Pager<PaymentCredentialMetadata>> ListAsync(
        PaymentCredentialsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

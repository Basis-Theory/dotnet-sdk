using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface IOwnerClient
{
    WithRawResponseTask<TenantMemberResponse> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMemberResponse> TransferAsync(
        TransferTenantOwnerRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

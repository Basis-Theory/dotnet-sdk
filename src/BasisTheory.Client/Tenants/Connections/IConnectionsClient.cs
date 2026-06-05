using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface IConnectionsClient
{
    WithRawResponseTask<CreateTenantConnectionResponse> CreateAsync(
        CreateTenantConnectionRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(RequestOptions? options = null, CancellationToken cancellationToken = default);
}

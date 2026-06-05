using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface ISelfClient
{
    WithRawResponseTask<TenantUsageReport> GetUsageReportsAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Tenant> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Tenant> UpdateAsync(
        UpdateTenantRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(RequestOptions? options = null, CancellationToken cancellationToken = default);
}

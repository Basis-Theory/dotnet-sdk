using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public partial interface IMerchantsClient
{
    Task<Pager<TenantMerchant>> ListAsync(
        string tenantId,
        MerchantsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMerchant> CreateAsync(
        string tenantId,
        TenantMerchantRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMerchant> GetAsync(
        string tenantId,
        string merchantId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMerchant> DeleteAsync(
        string tenantId,
        string merchantId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMerchant> UpdateAsync(
        string tenantId,
        string merchantId,
        TenantMerchantRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMerchant> RequestOnboardingAsync(
        string tenantId,
        string merchantId,
        ServiceOnboardingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

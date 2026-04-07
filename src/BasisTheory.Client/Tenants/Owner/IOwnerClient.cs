using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface IOwnerClient
{
    WithRawResponseTask<TenantMemberResponse> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

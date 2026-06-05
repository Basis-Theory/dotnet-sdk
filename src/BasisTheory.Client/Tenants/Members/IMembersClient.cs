using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public partial interface IMembersClient
{
    Task<Pager<TenantMemberResponse>> ListAsync(
        MembersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantMemberResponse> UpdateAsync(
        string memberId,
        UpdateTenantMemberRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string memberId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

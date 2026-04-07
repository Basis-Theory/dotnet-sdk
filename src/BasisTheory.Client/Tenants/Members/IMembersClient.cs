using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface IMembersClient
{
    WithRawResponseTask<TenantMemberResponsePaginatedList> ListAsync(
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

using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Tenants;

public partial interface IInvitationsClient
{
    Task<Pager<TenantInvitationResponse>> ListAsync(
        InvitationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantInvitationResponse> CreateAsync(
        CreateTenantInvitationRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantInvitationResponse> ResendAsync(
        string invitationId,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantInvitationResponse> GetAsync(
        string invitationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string invitationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

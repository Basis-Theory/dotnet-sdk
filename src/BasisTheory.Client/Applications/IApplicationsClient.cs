using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface IApplicationsClient
{
    Task<Pager<Application>> ListAsync(
        ApplicationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Application> CreateAsync(
        CreateApplicationRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Application> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Application> UpdateAsync(
        string id,
        UpdateApplicationRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Application> GetByKeyAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

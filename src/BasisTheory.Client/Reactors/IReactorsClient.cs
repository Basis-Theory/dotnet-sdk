using global::BasisTheory.Client.Core;
using global::BasisTheory.Client.Reactors;

namespace BasisTheory.Client;

public partial interface IReactorsClient
{
    public IResultsClient Results { get; }
    Task<Pager<Reactor>> ListAsync(
        ReactorsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Reactor> CreateAsync(
        CreateReactorRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Reactor> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Reactor> UpdateAsync(
        string id,
        UpdateReactorRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task PatchAsync(
        string id,
        PatchReactorRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReactResponse> ReactAsync(
        string id,
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AsyncReactResponse> ReactAsyncAsync(
        string id,
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

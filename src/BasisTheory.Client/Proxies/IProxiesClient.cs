using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface IProxiesClient
{
    Task<Pager<Proxy>> ListAsync(
        ProxiesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Proxy> CreateAsync(
        CreateProxyRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Proxy> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Proxy> UpdateAsync(
        string id,
        UpdateProxyRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask PatchAsync(
        string id,
        PatchProxyRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

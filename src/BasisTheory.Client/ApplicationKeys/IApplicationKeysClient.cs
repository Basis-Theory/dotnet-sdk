namespace BasisTheory.Client;

public partial interface IApplicationKeysClient
{
    WithRawResponseTask<IEnumerable<ApplicationKey>> ListAsync(
        string id,
        ApplicationKeysListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplicationKey> CreateAsync(
        string id,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplicationKey> GetAsync(
        string id,
        string keyId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        string keyId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

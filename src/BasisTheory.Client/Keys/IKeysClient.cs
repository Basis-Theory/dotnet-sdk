namespace BasisTheory.Client;

public partial interface IKeysClient
{
    WithRawResponseTask<IEnumerable<ClientEncryptionKeyMetadataResponse>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ClientEncryptionKeyResponse> CreateAsync(
        ClientEncryptionKeyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ClientEncryptionKeyMetadataResponse> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

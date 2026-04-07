namespace BasisTheory.Client;

public partial interface INetworkTokensClient
{
    WithRawResponseTask<NetworkToken> CreateAsync(
        CreateNetworkTokenRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NetworkTokenCryptogram> CryptogramAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NetworkToken> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NetworkToken> SuspendAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NetworkToken> ResumeAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

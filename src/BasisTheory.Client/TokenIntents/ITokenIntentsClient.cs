namespace BasisTheory.Client;

public partial interface ITokenIntentsClient
{
    WithRawResponseTask<TokenIntent> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreateTokenIntentResponse> CreateAsync(
        CreateTokenIntentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

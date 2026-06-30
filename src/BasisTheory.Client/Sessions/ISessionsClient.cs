namespace BasisTheory.Client;

public partial interface ISessionsClient
{
    WithRawResponseTask<CreateSessionResponse> CreateAsync(
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask AuthorizeAsync(
        AuthorizeSessionRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

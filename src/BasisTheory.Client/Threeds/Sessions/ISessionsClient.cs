using global::BasisTheory.Client;

namespace BasisTheory.Client.Threeds;

public partial interface ISessionsClient
{
    WithRawResponseTask<CreateThreeDsSessionResponse> CreateAsync(
        CreateThreeDsSessionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ThreeDsAuthentication> AuthenticateAsync(
        string sessionId,
        AuthenticateThreeDsSessionRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ThreeDsAuthentication> GetChallengeResultAsync(
        string sessionId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ThreeDsSession> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

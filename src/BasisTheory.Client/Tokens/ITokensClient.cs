using global::BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial interface ITokensClient
{
    WithRawResponseTask<object> DetokenizeAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> TokenizeAsync(
        object request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Token> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Token> UpdateAsync(
        string id,
        UpdateTokenRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Token> CreateAsync(
        CreateTokenRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<Pager<Token>> ListV2Async(
        TokensListV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<Pager<Token>> SearchV2Async(
        SearchTokensRequestV2 request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

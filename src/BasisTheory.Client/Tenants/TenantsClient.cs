using global::BasisTheory.Client.Core;
using global::BasisTheory.Client.Tenants;
using global::System.Text.Json;

namespace BasisTheory.Client;

public partial class TenantsClient : ITenantsClient
{
    private readonly RawClient _client;

    internal TenantsClient(RawClient client)
    {
        _client = client;
        SecurityContact = new SecurityContactClient(_client);
        Connections = new ConnectionsClient(_client);
        Invitations = new InvitationsClient(_client);
        Members = new MembersClient(_client);
        Merchants = new MerchantsClient(_client);
        Owner = new OwnerClient(_client);
        Self = new SelfClient(_client);
    }

    public ISecurityContactClient SecurityContact { get; }

    public IConnectionsClient Connections { get; }

    public IInvitationsClient Invitations { get; }

    public IMembersClient Members { get; }

    public IMerchantsClient Merchants { get; }

    public IOwnerClient Owner { get; }

    public ISelfClient Self { get; }

    private async Task<WithRawResponse<TenantMemberResponse>> OwnerTransferAsyncCore(
        TransferTenantOwnerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::BasisTheory.Client.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Put,
                    Path = "tenants/self/owner",
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<TenantMemberResponse>(responseBody)!;
                return new WithRawResponse<TenantMemberResponse>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new BasisTheoryApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody)
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody)
                        );
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody)
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new BasisTheoryApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.Tenants.OwnerTransferAsync(new TransferTenantOwnerRequest { MemberId = "member_id" });
    /// </code></example>
    public WithRawResponseTask<TenantMemberResponse> OwnerTransferAsync(
        TransferTenantOwnerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TenantMemberResponse>(
            OwnerTransferAsyncCore(request, options, cancellationToken)
        );
    }
}

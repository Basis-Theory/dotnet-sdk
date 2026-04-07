using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json;

namespace BasisTheory.Client.Tenants;

public partial class InvitationsClient : IInvitationsClient
{
    private readonly RawClient _client;

    internal InvitationsClient(RawClient client)
    {
        _client = client;
    }

    private WithRawResponseTask<TenantInvitationResponsePaginatedList> ListInternalAsync(
        InvitationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TenantInvitationResponsePaginatedList>(
            ListInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<
        WithRawResponse<TenantInvitationResponsePaginatedList>
    > ListInternalAsyncCore(
        InvitationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::BasisTheory.Client.Core.QueryStringBuilder.Builder(
            capacity: 4
        )
            .Add("status", request.Status)
            .Add("page", request.Page)
            .Add("start", request.Start)
            .Add("size", request.Size)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
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
                    Method = HttpMethod.Get,
                    Path = "tenants/self/invitations",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<TenantInvitationResponsePaginatedList>(
                    responseBody
                )!;
                return new WithRawResponse<TenantInvitationResponsePaginatedList>()
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

    private async Task<WithRawResponse<TenantInvitationResponse>> CreateAsyncCore(
        CreateTenantInvitationRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::BasisTheory.Client.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(((IIdempotentRequestOptions?)options)?.GetIdempotencyHeaders())
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "tenants/self/invitations",
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
                var responseData = JsonUtils.Deserialize<TenantInvitationResponse>(responseBody)!;
                return new WithRawResponse<TenantInvitationResponse>()
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
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ValidationProblemDetails>(responseBody)
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody)
                        );
                    case 403:
                        throw new ForbiddenError(
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

    private async Task<WithRawResponse<TenantInvitationResponse>> ResendAsyncCore(
        string invitationId,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::BasisTheory.Client.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(((IIdempotentRequestOptions?)options)?.GetIdempotencyHeaders())
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "tenants/self/invitations/{0}/resend",
                        ValueConvert.ToPathParameterString(invitationId)
                    ),
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<TenantInvitationResponse>(responseBody)!;
                return new WithRawResponse<TenantInvitationResponse>()
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
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ValidationProblemDetails>(responseBody)
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody)
                        );
                    case 403:
                        throw new ForbiddenError(
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

    private async Task<WithRawResponse<TenantInvitationResponse>> GetAsyncCore(
        string invitationId,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "tenants/self/invitations/{0}",
                        ValueConvert.ToPathParameterString(invitationId)
                    ),
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<TenantInvitationResponse>(responseBody)!;
                return new WithRawResponse<TenantInvitationResponse>()
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
    /// await client.Tenants.Invitations.ListAsync(
    ///     new InvitationsListRequest
    ///     {
    ///         Status = TenantInvitationStatus.Pending,
    ///         Page = 1,
    ///         Start = "start",
    ///         Size = 1,
    ///     }
    /// );
    /// </code></example>
    public async Task<Pager<TenantInvitationResponse>> ListAsync(
        InvitationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        request = request with { };
        var pager = await OffsetPager<
            InvitationsListRequest,
            RequestOptions?,
            TenantInvitationResponsePaginatedList,
            int,
            object,
            TenantInvitationResponse
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInternalAsync(request, options, cancellationToken),
                request => request.Page ?? 0,
                (request, offset) =>
                {
                    request.Page = offset;
                },
                null,
                response => response.Data?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <example><code>
    /// await client.Tenants.Invitations.CreateAsync(new CreateTenantInvitationRequest { Email = "email" });
    /// </code></example>
    public WithRawResponseTask<TenantInvitationResponse> CreateAsync(
        CreateTenantInvitationRequest request,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TenantInvitationResponse>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Tenants.Invitations.ResendAsync("invitationId");
    /// </code></example>
    public WithRawResponseTask<TenantInvitationResponse> ResendAsync(
        string invitationId,
        IdempotentRequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TenantInvitationResponse>(
            ResendAsyncCore(invitationId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Tenants.Invitations.GetAsync("invitationId");
    /// </code></example>
    public WithRawResponseTask<TenantInvitationResponse> GetAsync(
        string invitationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TenantInvitationResponse>(
            GetAsyncCore(invitationId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Tenants.Invitations.DeleteAsync("invitationId");
    /// </code></example>
    public async Task DeleteAsync(
        string invitationId,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "tenants/self/invitations/{0}",
                        ValueConvert.ToPathParameterString(invitationId)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
}

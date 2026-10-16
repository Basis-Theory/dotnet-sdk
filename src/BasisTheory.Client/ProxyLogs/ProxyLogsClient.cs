using global::BasisTheory.Client.Core;
using global::System.Text.Json;

namespace BasisTheory.Client;

public partial class ProxyLogsClient : IProxyLogsClient
{
    private readonly RawClient _client;

    internal ProxyLogsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Requires log:read. Returns individual Proxy runtime records, not event envelopes or neighboring records from the same batch. Tenant and history entitlement are checked on every request. Date bounds use occurred_at, inclusive at start and exclusive at end, and are clamped to current entitlement, now, and the 30-day maximum. Results are asynchronously visible. Responses include source (origin) and record_type (record kind); both have exact, case-sensitive string filters, with application/log and platform/lifecycle as the supported pairings. error and attributes are complete display-only objects and cannot be filtered or searched. IDs are stable logical record identities for deduplicating polling overlap. Pagination is bounded; follow next even after a short page. No cross-page uniqueness or snapshot is promised. Query parameters must be single strings; repeated, unknown, or operator parameters are 400. There are at most 36 parameters, values are at most 1,024 characters (cursor: 12,000), and combined filters are limited to 4,096 UTF-8 bytes. Word search trims/collapses whitespace and is limited to 256 normalized characters.
    /// </summary>
    private WithRawResponseTask<RuntimeLogPage> ListInternalAsync(
        string proxyId,
        ProxyLogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<RuntimeLogPage>(
            ListInternalAsyncCore(proxyId, request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<RuntimeLogPage>> ListInternalAsyncCore(
        string proxyId,
        ProxyLogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::BasisTheory.Client.Core.QueryStringBuilder.Builder(
            capacity: 13
        )
            .Add("start_date", request.StartDate)
            .Add("end_date", request.EndDate)
            .Add("start", request.Start)
            .Add("size", request.Size)
            .Add("source", request.Source)
            .Add("record_type", request.RecordType)
            .Add("trace_id", request.TraceId)
            .Add("level", request.Level)
            .Add("event", request.Event)
            .Add("outcome", request.Outcome)
            .Add("transform_type", request.TransformType)
            .Add("message", request.Message)
            .Add("message[search_words]", request.MessageSearchWords)
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
                    Path = string.Format(
                        "proxies/{0}/logs",
                        ValueConvert.ToPathParameterString(proxyId)
                    ),
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
                var responseData = JsonUtils.Deserialize<RuntimeLogPage>(responseBody)!;
                return new WithRawResponse<RuntimeLogPage>()
                {
                    Data = responseData,
                    RawResponse = new global::BasisTheory.Client.RawResponse()
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
                    e,
                    rawResponse: new global::BasisTheory.Client.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                            JsonUtils.Deserialize<ValidationProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<ProblemDetails>(responseBody),
                            rawResponse: new global::BasisTheory.Client.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
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
                responseBody,
                rawResponse: new global::BasisTheory.Client.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <summary>
    /// Requires log:read. Returns individual Proxy runtime records, not event envelopes or neighboring records from the same batch. Tenant and history entitlement are checked on every request. Date bounds use occurred_at, inclusive at start and exclusive at end, and are clamped to current entitlement, now, and the 30-day maximum. Results are asynchronously visible. Responses include source (origin) and record_type (record kind); both have exact, case-sensitive string filters, with application/log and platform/lifecycle as the supported pairings. error and attributes are complete display-only objects and cannot be filtered or searched. IDs are stable logical record identities for deduplicating polling overlap. Pagination is bounded; follow next even after a short page. No cross-page uniqueness or snapshot is promised. Query parameters must be single strings; repeated, unknown, or operator parameters are 400. There are at most 36 parameters, values are at most 1,024 characters (cursor: 12,000), and combined filters are limited to 4,096 UTF-8 bytes. Word search trims/collapses whitespace and is limited to 256 normalized characters.
    /// </summary>
    /// <example><code>
    /// await client.ProxyLogs.ListAsync(
    ///     "proxy_id",
    ///     new ProxyLogsListRequest
    ///     {
    ///         StartDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         EndDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Start = "start",
    ///         Size = 1,
    ///         Source = "source",
    ///         RecordType = "record_type",
    ///         TraceId = "trace_id",
    ///         Level = "level",
    ///         Event = "event",
    ///         Outcome = "outcome",
    ///         TransformType = "transform_type",
    ///         Message = "message",
    ///         MessageSearchWords = "message[search_words]",
    ///     }
    /// );
    /// </code></example>
    public async Task<Pager<RuntimeLog>> ListAsync(
        string proxyId,
        ProxyLogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            ProxyLogsListRequest,
            RequestOptions?,
            RuntimeLogPage,
            string?,
            RuntimeLog
        >
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInternalAsync(proxyId, request, options, cancellationToken)
                        .WithRawResponse(),
                (request, cursor) =>
                {
                    request.Start = cursor;
                },
                response => response.Pagination.Next,
                response => response.Data?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }
}

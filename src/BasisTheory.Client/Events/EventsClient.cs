using global::BasisTheory.Client.Core;
using global::System.Text.Json;

namespace BasisTheory.Client;

public partial class EventsClient : IEventsClient
{
    private readonly RawClient _client;

    internal EventsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Requires event:read. Tenant identity comes from trusted API-key authentication. History is limited by log_history_limit (24 hours by default, at most 30 days). Windows reaching outside the visible history are clamped to it rather than rejected. No secondary failover or portal JWT support. SDK callers supply data.&lt;path&gt; filters as literal keys through the SDK's per-request query-parameter options, not as a filters request field.
    /// </summary>
    private WithRawResponseTask<EventPage> ListInternalAsync(
        EventsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EventPage>(
            ListInternalAsyncCore(request, options, cancellationToken)
        );
    }

    private async Task<WithRawResponse<EventPage>> ListInternalAsyncCore(
        EventsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::BasisTheory.Client.Core.QueryStringBuilder.Builder(
            capacity: 6
        )
            .Add("start_date", request.StartDate)
            .Add("end_date", request.EndDate)
            .Add("start", request.Start)
            .Add("size", request.Size)
            .Add("type", request.Type)
            .Add("trace_id", request.TraceId)
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
                    Path = "events",
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
                var responseData = JsonUtils.Deserialize<EventPage>(responseBody)!;
                return new WithRawResponse<EventPage>()
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
    /// Requires event:read. Tenant identity comes from trusted API-key authentication. History is limited by log_history_limit (24 hours by default, at most 30 days). Windows reaching outside the visible history are clamped to it rather than rejected. No secondary failover or portal JWT support. SDK callers supply data.&lt;path&gt; filters as literal keys through the SDK's per-request query-parameter options, not as a filters request field.
    /// </summary>
    /// <example><code>
    /// await client.Events.ListAsync(
    ///     new EventsListRequest
    ///     {
    ///         StartDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         EndDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Start = "start",
    ///         Size = 1,
    ///         Type = "type",
    ///         TraceId = "trace_id",
    ///     }
    /// );
    /// </code></example>
    public async Task<Pager<Event>> ListAsync(
        EventsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<EventsListRequest, RequestOptions?, EventPage, string?, Event>
            .CreateInstanceAsync(
                request,
                options,
                async (request, options, cancellationToken) =>
                    await ListInternalAsync(request, options, cancellationToken).WithRawResponse(),
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

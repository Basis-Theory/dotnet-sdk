using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;
using global::System.Text.Json;

namespace BasisTheory.Client.Documents;

public partial class DataClient : IDataClient
{
    private readonly RawClient _client;

    internal DataClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<global::System.IO.Stream>> GetAsyncCore(
        string documentId,
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
                        "documents/{0}/data",
                        ValueConvert.ToPathParameterString(documentId)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var stream = await response.Raw.Content.ReadAsStreamAsync();
            return new WithRawResponse<global::System.IO.Stream>()
            {
                Data = stream,
                RawResponse = new RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                },
            };
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
    /// await client.Documents.Data.GetAsync("documentId");
    /// </code></example>
    public WithRawResponseTask<global::System.IO.Stream> GetAsync(
        string documentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<global::System.IO.Stream>(
            GetAsyncCore(documentId, options, cancellationToken)
        );
    }
}

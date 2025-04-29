using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.ApplePay;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public partial class ApplePayClient
{
    private RawClient _client;

    internal ApplePayClient(RawClient client)
    {
        _client = client;
        Domain = new DomainClient(_client);
        Session = new SessionClient(_client);
    }

    public DomainClient Domain { get; }

    public SessionClient Session { get; }

    /// <example><code>
    /// await client.ApplePay.TokenizeAsync(new ApplePayTokenizeRequest());
    /// </code></example>
    public async Task<ApplePayTokenizeResponse> TokenizeAsync(
        ApplePayTokenizeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "connections/apple-pay/tokenize",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ApplePayTokenizeResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new BasisTheoryException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
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
}

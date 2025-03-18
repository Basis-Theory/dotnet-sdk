using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client;
using BasisTheory.Client.Connections.ApplePay;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Connections;

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

    /// <example>
    /// <code>
    /// await client.Connections.ApplePay.TokenizeAsync(new ApplePayTokenizeRequest());
    /// </code>
    /// </example>
    public async Task<ApplePayTokenizeResponse> TokenizeAsync(
        ApplePayTokenizeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "connections/apple-pay/tokenize",
                Body = request,
                ContentType = "application/json",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ApplePayTokenizeResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new BasisTheoryException("Failed to deserialize response", e);
            }
        }

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
                    throw new ForbiddenError(JsonUtils.Deserialize<ProblemDetails>(responseBody));
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

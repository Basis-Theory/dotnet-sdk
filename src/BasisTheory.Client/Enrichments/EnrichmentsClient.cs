using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public partial class EnrichmentsClient
{
    private RawClient _client;

    internal EnrichmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Enrichments.BankaccountverifyAsync(
    ///     new BankVerificationRequest { TokenId = "token_id" }
    /// );
    /// </code>
    /// </example>
    public async Task BankaccountverifyAsync(
        BankVerificationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "enrichments/bank-account-verify",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
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
                    throw new ForbiddenError(JsonUtils.Deserialize<ProblemDetails>(responseBody));
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

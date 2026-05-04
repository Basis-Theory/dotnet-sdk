using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

public partial class CredentialsClient
{
    private RawClient _client;

    internal CredentialsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve payment credentials (card number, expiration, CVC) for a purchase instruction.
    /// </summary>
    /// <example><code>
    /// await client.Agentic.Agents.Instructions.Credentials.CreateAsync(
    ///     "agent_id",
    ///     "instruction_id",
    ///     new GetCredentialsRequest
    ///     {
    ///         Merchant = new AgenticMerchant
    ///         {
    ///             Name = "name",
    ///             Url = "url",
    ///             CountryCode = "country_code",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async Task<Credentials> CreateAsync(
        string agentId,
        string instructionId,
        GetCredentialsRequest request,
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
                    Path = string.Format(
                        "agentic/agents/{0}/instructions/{1}/credentials",
                        ValueConvert.ToPathParameterString(agentId),
                        ValueConvert.ToPathParameterString(instructionId)
                    ),
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
                return JsonUtils.Deserialize<Credentials>(responseBody)!;
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
                        throw new BadRequestError(JsonUtils.Deserialize<object>(responseBody));
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
                    case 500:
                        throw new InternalServerError(
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

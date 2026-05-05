using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents.Instructions;

public partial class VerifyClient
{
    private RawClient _client;

    internal VerifyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Initiate cardholder verification for a purchase instruction that requires it.
    /// </summary>
    /// <example><code>
    /// await client.Agentic.Agents.Instructions.Verify.StartAsync(
    ///     "agent_id",
    ///     "instruction_id",
    ///     new StartVerificationRequest
    ///     {
    ///         DeviceContext = new DeviceContext
    ///         {
    ///             ScreenHeight = 1,
    ///             ScreenWidth = 1,
    ///             UserAgentString = "user_agent_string",
    ///             LanguageCode = "language_code",
    ///             TimeZone = "time_zone",
    ///             JavaScriptEnabled = true,
    ///             ClientDeviceId = "client_device_id",
    ///             ClientReferenceId = "client_reference_id",
    ///             PlatformType = DeviceContextPlatformType.Web,
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async Task<VerificationResponse> StartAsync(
        string agentId,
        string instructionId,
        StartVerificationRequest request,
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
                        "agentic/agents/{0}/instructions/{1}/verify",
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
                return JsonUtils.Deserialize<VerificationResponse>(responseBody)!;
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

    /// <summary>
    /// Submit passkey/FIDO assertion data to complete instruction verification.
    /// </summary>
    /// <example><code>
    /// await client.Agentic.Agents.Instructions.Verify.PasskeyAsync(
    ///     "agent_id",
    ///     "instruction_id",
    ///     new SubmitPasskeyRequest
    ///     {
    ///         AssuranceData = new Dictionary&lt;string, object&gt;() { { "key", "value" } },
    ///     }
    /// );
    /// </code></example>
    public async Task<Instruction> PasskeyAsync(
        string agentId,
        string instructionId,
        SubmitPasskeyRequest request,
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
                        "agentic/agents/{0}/instructions/{1}/verify/passkey",
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
                return JsonUtils.Deserialize<Instruction>(responseBody)!;
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

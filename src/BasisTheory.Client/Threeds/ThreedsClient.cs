using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public partial class ThreedsClient
{
    private RawClient _client;

    internal ThreedsClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Threeds.CreatesessionAsync(new CreateThreeDsSessionRequest());
    /// </code>
    /// </example>
    public async Task<CreateThreeDsSessionResponse> CreatesessionAsync(
        CreateThreeDsSessionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "3ds/sessions",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CreateThreeDsSessionResponse>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.Threeds.AuthenticateSessionAsync(
    ///     "sessionId",
    ///     new AuthenticateThreeDsSessionRequest
    ///     {
    ///         AuthenticationCategory = "authentication_category",
    ///         AuthenticationType = "authentication_type",
    ///         RequestorInfo = new ThreeDsRequestorInfo(),
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ThreeDsAuthentication> AuthenticateSessionAsync(
        string sessionId,
        AuthenticateThreeDsSessionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"3ds/sessions/{sessionId}/authenticate",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ThreeDsAuthentication>(responseBody)!;
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
                case 401:
                    throw new UnauthorizedError(
                        JsonUtils.Deserialize<ProblemDetails>(responseBody)
                    );
                case 403:
                    throw new ForbiddenError(JsonUtils.Deserialize<ProblemDetails>(responseBody));
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

    /// <example>
    /// <code>
    /// await client.Threeds.GetChallengeResultAsync("sessionId");
    /// </code>
    /// </example>
    public async Task<ThreeDsAuthentication> GetChallengeResultAsync(
        string sessionId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"3ds/sessions/{sessionId}/challenge-result",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ThreeDsAuthentication>(responseBody)!;
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
                case 401:
                    throw new UnauthorizedError(
                        JsonUtils.Deserialize<ProblemDetails>(responseBody)
                    );
                case 403:
                    throw new ForbiddenError(JsonUtils.Deserialize<ProblemDetails>(responseBody));
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

    /// <example>
    /// <code>
    /// await client.Threeds.GetSessionByIdAsync("id");
    /// </code>
    /// </example>
    public async Task<ThreeDsSession> GetSessionByIdAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"3ds/sessions/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ThreeDsSession>(responseBody)!;
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
                case 401:
                    throw new UnauthorizedError(
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

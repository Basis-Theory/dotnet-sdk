using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.Core;
using BasisTheory.Client.Threeds;

#nullable enable

namespace BasisTheory.Client;

public partial class ThreedsClient
{
    private RawClient _client;

    internal ThreedsClient(RawClient client)
    {
        _client = client;
        Sessions = new SessionsClient(_client);
    }

    public SessionsClient Sessions { get; }

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
}

using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public partial class DetokenizeClient
{
    private RawClient _client;

    internal DetokenizeClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Detokenize.DetokenizeAsync(new Dictionary<object, object?>() { { "key", "value" } });
    /// </code>
    /// </example>
    public async Task DetokenizeAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "detokenize",
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
                case 409:
                    throw new ConflictError(JsonUtils.Deserialize<ProblemDetails>(responseBody));
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
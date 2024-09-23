using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public partial class LogsClient
{
    private RawClient _client;

    internal LogsClient(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Logs.ListAsync(new LogsListRequest());
    /// </code>
    /// </example>
    public async Task<LogPaginatedList> ListAsync(
        LogsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.EntityType != null)
        {
            _query["entity_type"] = request.EntityType;
        }
        if (request.EntityId != null)
        {
            _query["entity_id"] = request.EntityId;
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["end_date"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.ToString();
        }
        if (request.Start != null)
        {
            _query["start"] = request.Start;
        }
        if (request.Size != null)
        {
            _query["size"] = request.Size.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "logs",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<LogPaginatedList>(responseBody)!;
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
    /// await client.Logs.GetEntityTypesAsync();
    /// </code>
    /// </example>
    public async Task<IEnumerable<LogEntityType>> GetEntityTypesAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "logs/entity-types",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<LogEntityType>>(responseBody)!;
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

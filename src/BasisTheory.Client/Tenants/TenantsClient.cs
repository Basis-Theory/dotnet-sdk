using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.Core;
using BasisTheory.Client.Tenants;

#nullable enable

namespace BasisTheory.Client;

public partial class TenantsClient
{
    private RawClient _client;

    internal TenantsClient(RawClient client)
    {
        _client = client;
        Connections = new ConnectionsClient(_client);
        Invitations = new InvitationsClient(_client);
        Members = new MembersClient(_client);
        Self = new SelfClient(_client);
    }

    public ConnectionsClient Connections { get; }

    public InvitationsClient Invitations { get; }

    public MembersClient Members { get; }

    public SelfClient Self { get; }

    /// <example>
    /// <code>
    /// await client.Tenants.OwnerGetAsync();
    /// </code>
    /// </example>
    public async Task<TenantMemberResponse> OwnerGetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "tenants/self/owner",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TenantMemberResponse>(responseBody)!;
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
}

using System.Net.Http;
using System.Text.Json;
using System.Threading;
using BasisTheory.Client.Core;
using BasisTheory.Client.Tenants;

namespace BasisTheory.Client;

public partial class TenantsClient
{
    private RawClient _client;

    internal TenantsClient(RawClient client)
    {
        _client = client;
        SecurityContact = new SecurityContactClient(_client);
        Connections = new ConnectionsClient(_client);
        Invitations = new InvitationsClient(_client);
        Members = new MembersClient(_client);
        Owner = new OwnerClient(_client);
        Self = new SelfClient(_client);
    }

    public SecurityContactClient SecurityContact { get; }

    public ConnectionsClient Connections { get; }

    public InvitationsClient Invitations { get; }

    public MembersClient Members { get; }

    public OwnerClient Owner { get; }

    public SelfClient Self { get; }

    /// <example><code>
    /// await client.Tenants.OwnerTransferAsync(new TransferTenantOwnerRequest { MemberId = "member_id" });
    /// </code></example>
    public async Task<TenantMemberResponse> OwnerTransferAsync(
        TransferTenantOwnerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Put,
                    Path = "tenants/self/owner",
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
                return JsonUtils.Deserialize<TenantMemberResponse>(responseBody)!;
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

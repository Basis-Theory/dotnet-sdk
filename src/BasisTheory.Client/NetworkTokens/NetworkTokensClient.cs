using System.Net.Http;
using System.Threading;
using BasisTheory.Client.Core;
using global::System.Threading.Tasks;

namespace BasisTheory.Client;

public partial class NetworkTokensClient
{
    private RawClient _client;

    internal NetworkTokensClient(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.NetworkTokens.CreateAsync();
    /// </code></example>
    public async global::System.Threading.Tasks.Task CreateAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "connections/network-tokens",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new BasisTheoryApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}

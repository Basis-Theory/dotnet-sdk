using System.Net.Http;
using System.Threading;
using BasisTheory.Client;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Webhooks;

public partial class SigningKeyClient
{
    private RawClient _client;

    internal SigningKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the signing key
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Webhooks.SigningKey.GetAsync();
    /// </code>
    /// </example>
    public async Task<string> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "webhooks/signing-key",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return responseBody;
        }
        throw new BasisTheoryApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}

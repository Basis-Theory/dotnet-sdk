using global::BasisTheory.Client;

namespace BasisTheory.Client.NetworkTokens;

public partial interface IAccountClient
{
    WithRawResponseTask<NetworkTokenAccount> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

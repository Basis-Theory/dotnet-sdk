using global::BasisTheory.Client;

namespace BasisTheory.Client.ApplePay;

public partial interface ISessionClient
{
    WithRawResponseTask<string> CreateAsync(
        ApplePaySessionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

using global::BasisTheory.Client.ApplePay;

namespace BasisTheory.Client;

public partial interface IApplePayClient
{
    public global::BasisTheory.Client.ApplePay.IMerchantClient Merchant { get; }
    public IDomainClient Domain { get; }
    public ISessionClient Session { get; }
    WithRawResponseTask<ApplePayCreateResponse> CreateAsync(
        ApplePayCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplePayToken> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<string> DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

namespace BasisTheory.Client;

public partial interface IGooglePayClient
{
    public global::BasisTheory.Client.GooglePay.IMerchantClient Merchant { get; }
    WithRawResponseTask<GooglePayCreateResponse> CreateAsync(
        GooglePayCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GooglePayToken> GetAsync(
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

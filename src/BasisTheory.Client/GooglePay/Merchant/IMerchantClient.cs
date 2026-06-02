using global::BasisTheory.Client;

namespace BasisTheory.Client.GooglePay;

public partial interface IMerchantClient
{
    public global::BasisTheory.Client.GooglePay.Merchant.ICertificatesClient Certificates { get; }
    WithRawResponseTask<GooglePayMerchant> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GooglePayMerchant> CreateAsync(
        GooglePayMerchantRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

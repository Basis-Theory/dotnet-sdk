using global::BasisTheory.Client;

namespace BasisTheory.Client.GooglePay.Merchant;

public partial interface ICertificatesClient
{
    WithRawResponseTask<GooglePayMerchantCertificates> GetAsync(
        string merchantId,
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string merchantId,
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GooglePayMerchantCertificates> CreateAsync(
        string merchantId,
        GooglePayMerchantCertificatesRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

using global::BasisTheory.Client;

namespace BasisTheory.Client.ApplePay.Merchant;

public partial interface ICertificatesClient
{
    WithRawResponseTask<ApplePayMerchantCertificates> GetAsync(
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

    WithRawResponseTask<ApplePayMerchantCertificates> CreateAsync(
        string merchantId,
        ApplePayMerchantCertificatesRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

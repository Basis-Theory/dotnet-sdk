using global::BasisTheory.Client;

namespace BasisTheory.Client.ApplePay;

public partial interface IMerchantClient
{
    public global::BasisTheory.Client.ApplePay.Merchant.ICertificatesClient Certificates { get; }
    WithRawResponseTask<ApplePayMerchant> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplePayMerchant> CreateAsync(
        ApplePayMerchantRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

using global::BasisTheory.Client;

namespace BasisTheory.Client.ApplePay;

public partial interface IDomainClient
{
    Task DeregisterAsync(
        ApplePayDomainDeregistrationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplePayDomainRegistrationResponse> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplePayDomainRegistrationResponse> RegisterAsync(
        ApplePayDomainRegistrationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplePayDomainRegistrationResponse> RegisterAllAsync(
        ApplePayDomainRegistrationListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

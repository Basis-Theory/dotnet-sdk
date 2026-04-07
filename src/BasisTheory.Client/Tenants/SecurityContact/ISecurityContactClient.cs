using global::BasisTheory.Client;

namespace BasisTheory.Client.Tenants;

public partial interface ISecurityContactClient
{
    WithRawResponseTask<SecurityContactEmailResponse> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SecurityContactEmailResponse> UpdateAsync(
        SecurityContactEmailRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

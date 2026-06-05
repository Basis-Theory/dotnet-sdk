namespace BasisTheory.Client;

public partial interface IPermissionsClient
{
    WithRawResponseTask<IEnumerable<Permission>> ListAsync(
        PermissionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

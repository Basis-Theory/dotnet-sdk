namespace BasisTheory.Client;

public partial interface IRolesClient
{
    WithRawResponseTask<IEnumerable<Role>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

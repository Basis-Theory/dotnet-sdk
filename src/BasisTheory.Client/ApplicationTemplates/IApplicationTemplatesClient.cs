namespace BasisTheory.Client;

public partial interface IApplicationTemplatesClient
{
    WithRawResponseTask<IEnumerable<ApplicationTemplate>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApplicationTemplate> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

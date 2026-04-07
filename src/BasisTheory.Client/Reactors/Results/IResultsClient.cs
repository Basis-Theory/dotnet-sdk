using global::BasisTheory.Client;

namespace BasisTheory.Client.Reactors;

public partial interface IResultsClient
{
    WithRawResponseTask<object> GetAsync(
        string id,
        string requestId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

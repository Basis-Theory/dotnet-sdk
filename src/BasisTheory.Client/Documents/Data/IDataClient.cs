using global::BasisTheory.Client;

namespace BasisTheory.Client.Documents;

public partial interface IDataClient
{
    WithRawResponseTask<global::System.IO.Stream> GetAsync(
        string documentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

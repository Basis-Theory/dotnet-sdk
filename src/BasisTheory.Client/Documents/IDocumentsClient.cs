using global::BasisTheory.Client.Documents;

namespace BasisTheory.Client;

public partial interface IDocumentsClient
{
    public IDataClient Data { get; }
    WithRawResponseTask<Document> UploadAsync(
        DocumentsUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Document> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

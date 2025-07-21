using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record DocumentsUploadRequest
{
    public FileParameter? Document { get; set; }

    public CreateDocumentRequest? Request { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record DocumentUploadRequest
{
    [JsonIgnore]
    public CreateDocumentRequest? Request { get; set; }

    public FileParameter? Document { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

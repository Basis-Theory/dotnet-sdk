using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record EnrichmentsGetCardDetailsRequest
{
    [JsonIgnore]
    public required string Bin { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

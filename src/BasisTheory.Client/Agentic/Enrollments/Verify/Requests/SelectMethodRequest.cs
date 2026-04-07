using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Enrollments;

[Serializable]
public record SelectMethodRequest
{
    [JsonPropertyName("method_id")]
    public required string MethodId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

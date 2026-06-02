using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

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

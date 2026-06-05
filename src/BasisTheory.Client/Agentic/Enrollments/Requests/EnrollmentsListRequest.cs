using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record EnrollmentsListRequest
{
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Pagination cursor from a previous response
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

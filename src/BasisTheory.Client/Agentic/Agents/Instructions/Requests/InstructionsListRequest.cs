using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic.Agents;

[Serializable]
public record InstructionsListRequest
{
    /// <summary>
    /// Filter instructions by enrollment ID
    /// </summary>
    [JsonIgnore]
    public string? EnrollmentId { get; set; }

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

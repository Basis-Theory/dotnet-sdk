using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.AccountUpdater;

[Serializable]
public record JobsListRequest
{
    /// <summary>
    /// The maximum number of jobs to return
    /// </summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>
    /// Cursor for pagination
    /// </summary>
    [JsonIgnore]
    public string? Start { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

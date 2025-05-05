using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.AccountUpdater;

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

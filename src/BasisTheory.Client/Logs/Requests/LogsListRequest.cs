using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record LogsListRequest
{
    [JsonIgnore]
    public string? EntityType { get; set; }

    [JsonIgnore]
    public string? EntityId { get; set; }

    [JsonIgnore]
    public DateTime? StartDate { get; set; }

    [JsonIgnore]
    public DateTime? EndDate { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    [JsonIgnore]
    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

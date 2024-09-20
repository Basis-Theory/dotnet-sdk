using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record GetLogs
{
    [JsonPropertyName("entity_type")]
    public string? EntityType { get; set; }

    [JsonPropertyName("entity_id")]
    public string? EntityId { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

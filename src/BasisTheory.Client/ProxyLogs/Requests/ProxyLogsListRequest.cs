using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record ProxyLogsListRequest
{
    /// <summary>
    /// Inclusive occurred_at bound; defaults to 24 hours before the end bound.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Exclusive occurred_at bound; defaults to request time.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Opaque continuation bound to tenant, resource, filters, bounds, page size, and log index generation.
    /// </summary>
    [JsonIgnore]
    public string? Start { get; set; }

    /// <summary>
    /// Maximum unique records in this page; short pages may still have a next cursor.
    /// </summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>
    /// Exact, case-sensitive string equality. Supported values are application (application records) and platform (lifecycle records); values are not otherwise enum-validated.
    /// </summary>
    [JsonIgnore]
    public string? Source { get; set; }

    /// <summary>
    /// Exact, case-sensitive string equality. Supported values are log for application records and lifecycle for platform records; values are not otherwise enum-validated.
    /// </summary>
    [JsonIgnore]
    public string? RecordType { get; set; }

    /// <summary>
    /// Exact, case-sensitive equality on this record.
    /// </summary>
    [JsonIgnore]
    public string? TraceId { get; set; }

    /// <summary>
    /// Exact, case-sensitive equality on this record.
    /// </summary>
    [JsonIgnore]
    public string? Level { get; set; }

    /// <summary>
    /// Exact, case-sensitive equality on this record.
    /// </summary>
    [JsonIgnore]
    public string? Event { get; set; }

    /// <summary>
    /// Exact, case-sensitive equality on this record.
    /// </summary>
    [JsonIgnore]
    public string? Outcome { get; set; }

    /// <summary>
    /// Exact, case-sensitive equality on this Proxy transform side.
    /// </summary>
    [JsonIgnore]
    public string? TransformType { get; set; }

    /// <summary>
    /// Exact, case-sensitive message equality; the empty string is a valid exact value.
    /// </summary>
    [JsonIgnore]
    public string? Message { get; set; }

    /// <summary>
    /// Standard-analyzed, case-insensitive all-terms match in any order on this same record. Whitespace is trimmed and collapsed; punctuation-only input matches no records.
    /// </summary>
    [JsonIgnore]
    public string? MessageSearchWords { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

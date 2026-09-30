using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record EventsListRequest
{
    /// <summary>
    /// Inclusive timestamp; defaults to 24 hours before end_date, shortened to tenant entitlement. An earlier value is raised to the oldest visible instant. ISO 8601 with timezone, at most millisecond precision. Must not be after end_date.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Exclusive timestamp; defaults to request time. A future value is lowered to request time. A window with no visible history returns an empty page.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Opaque cursor from pagination.next. Bound to tenant, filters, window, page size, and configured collection/index generation.
    /// </summary>
    [JsonIgnore]
    public string? Start { get; set; }

    /// <summary>
    /// Maximum unique events returned. A short page may have a next cursor.
    /// </summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>
    /// Exact event type.
    /// </summary>
    [JsonIgnore]
    public string? Type { get; set; }

    /// <summary>
    /// Exact trace ID.
    /// </summary>
    [JsonIgnore]
    public string? TraceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

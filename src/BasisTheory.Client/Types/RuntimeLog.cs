using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record RuntimeLog : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Origin of the record, either application code or the platform.
    /// </summary>
    [JsonPropertyName("source")]
    public required RuntimeLogSource Source { get; set; }

    /// <summary>
    /// Record category paired with source (application/log or platform/lifecycle).
    /// </summary>
    [JsonPropertyName("record_type")]
    public required RuntimeLogRecordType RecordType { get; set; }

    /// <summary>
    /// Stable identifier assigned to one runtime-log record during ingestion. Repeated delivery preserves it; separate records retain different IDs even when messages and timestamps match. Treat it as an opaque deduplication key, not a resource, invocation, or event-batch ID. Filtering by id is not supported.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("occurred_at")]
    public required DateTime OccurredAt { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("trace_id")]
    public string? TraceId { get; set; }

    [JsonPropertyName("transform_type")]
    public string? TransformType { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    [JsonPropertyName("duration_ms")]
    public double? DurationMs { get; set; }

    /// <summary>
    /// Display-only diagnostic data; its properties are not searchable.
    /// </summary>
    [JsonPropertyName("error")]
    public object? Error { get; set; }

    /// <summary>
    /// Display-only diagnostic data; its properties are not searchable.
    /// </summary>
    [JsonPropertyName("attributes")]
    public object? Attributes { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record AccountUpdaterJob
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }

    /// <summary>
    /// The current status of the job
    /// </summary>
    [JsonPropertyName("status")]
    public required AccountUpdaterJobStatus Status { get; set; }

    /// <summary>
    /// Pre-signed URL for uploading job data
    /// </summary>
    [JsonPropertyName("uploadUrl")]
    public required string UploadUrl { get; set; }

    /// <summary>
    /// Application id that created the job
    /// </summary>
    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; set; }

    /// <summary>
    /// Date and time when the job was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time when the job expires if no data is uploaded
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// List of errors encountered during processing
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<string>? Errors { get; set; }

    /// <summary>
    /// Total number of requests processed
    /// </summary>
    [JsonPropertyName("requests")]
    public int? Requests { get; set; }

    /// <summary>
    /// Summary count breakdown by result code for all processed rows
    /// </summary>
    [JsonPropertyName("results")]
    public Dictionary<string, int>? Results { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

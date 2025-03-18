using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record Webhook
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("tenant_id")]
    public required string TenantId { get; set; }

    [JsonPropertyName("status")]
    public required WebhookStatus Status { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// The email address to use for management notification events. Ie: webhook disabled
    /// </summary>
    [JsonPropertyName("notify_email")]
    public string? NotifyEmail { get; set; }

    [JsonPropertyName("events")]
    public IEnumerable<string> Events { get; set; } = new List<string>();

    [JsonPropertyName("created_by")]
    public required string CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

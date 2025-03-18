using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record Tenant
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("settings")]
    public Dictionary<string, string?>? Settings { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

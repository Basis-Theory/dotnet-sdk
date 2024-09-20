using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record WebhookCreateRequest
{
    /// <summary>
    /// The name of the webhook
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The URL to which the webhook will send events
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// An array of event types that the webhook will listen for
    /// </summary>
    [JsonPropertyName("events")]
    public IEnumerable<string> Events { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

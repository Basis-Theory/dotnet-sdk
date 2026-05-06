using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record NetworkStatusDetail
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("status_reason_code")]
    public string? StatusReasonCode { get; set; }

    [JsonPropertyName("status_reason")]
    public string? StatusReason { get; set; }

    [JsonPropertyName("status_reason_label")]
    public string? StatusReasonLabel { get; set; }

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

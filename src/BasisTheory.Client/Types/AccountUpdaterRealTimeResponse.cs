using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record AccountUpdaterRealTimeResponse
{
    [JsonPropertyName("new_token")]
    public Token? NewToken { get; set; }

    /// <summary>
    /// The account updater result code
    /// </summary>
    [JsonPropertyName("result_code")]
    public string? ResultCode { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

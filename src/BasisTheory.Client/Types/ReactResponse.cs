using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ReactResponse
{
    [JsonPropertyName("tokens")]
    public object? Tokens { get; set; }

    [JsonPropertyName("raw")]
    public object? Raw { get; set; }

    [JsonPropertyName("body")]
    public object? Body { get; set; }

    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

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

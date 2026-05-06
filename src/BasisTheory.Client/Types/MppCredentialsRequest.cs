using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record MppCredentialsRequest
{
    [JsonPropertyName("challenge")]
    public required MppChallenge Challenge { get; set; }

    /// <summary>
    /// Mutually exclusive with card_id
    /// </summary>
    [JsonPropertyName("source")]
    public MppSource? Source { get; set; }

    /// <summary>
    /// Mutually exclusive with source
    /// </summary>
    [JsonPropertyName("card_id")]
    public string? CardId { get; set; }

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

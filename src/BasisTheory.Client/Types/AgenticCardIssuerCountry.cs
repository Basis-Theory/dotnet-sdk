using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

/// <summary>
/// Card issuer country details
/// </summary>
[Serializable]
public record AgenticCardIssuerCountry
{
    /// <summary>
    /// ISO 3166-1 alpha-2 country code
    /// </summary>
    [JsonPropertyName("alpha2")]
    public string? Alpha2 { get; set; }

    /// <summary>
    /// Country name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ISO 3166-1 numeric country code
    /// </summary>
    [JsonPropertyName("numeric")]
    public string? Numeric { get; set; }

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

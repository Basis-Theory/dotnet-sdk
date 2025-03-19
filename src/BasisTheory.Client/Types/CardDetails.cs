using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CardDetails
{
    [JsonPropertyName("bin")]
    public string? Bin { get; set; }

    [JsonPropertyName("last4")]
    public string? Last4 { get; set; }

    [JsonPropertyName("expiration_month")]
    public int? ExpirationMonth { get; set; }

    [JsonPropertyName("expiration_year")]
    public int? ExpirationYear { get; set; }

    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("funding")]
    public string? Funding { get; set; }

    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }

    [JsonPropertyName("issuer_country")]
    public CardIssuerCountry? IssuerCountry { get; set; }

    [JsonPropertyName("additional")]
    public IEnumerable<AdditionalCardDetails>? Additional { get; set; }

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

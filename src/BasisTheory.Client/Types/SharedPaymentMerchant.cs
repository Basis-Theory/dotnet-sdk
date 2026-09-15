using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record SharedPaymentMerchant : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Absolute HTTP or HTTPS merchant URL.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// Officially assigned ISO 3166-1 alpha-2 code. Lowercase request values are normalized.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Merchant category code used for network authentication. Mastercard defaults to 5399 when omitted; Visa forwards the value only when supplied.
    /// </summary>
    [JsonPropertyName("category_code")]
    public string? CategoryCode { get; set; }

    /// <summary>
    /// Acquirer BIN used for Mastercard authentication. Defaults to 545301 when omitted.
    /// </summary>
    [JsonPropertyName("acquirer_bin")]
    public string? AcquirerBin { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

/// <summary>
/// Browser/device data captured once on Visa `start`. Only `language_code` and `time_zone` are validated; every other property is forwarded to Visa unchanged. The API retains it for `submit_session`.
/// </summary>
[Serializable]
public record VerifyAllowanceRequestStartDeviceContext : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    /// <summary>
    /// BCP 47 language tag. Canonicalized on input (for example, `EN-us` becomes `en-US`); underscore locales such as `en_US` are rejected.
    /// </summary>
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// IANA time zone identifier, such as `America/New_York`.
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    [JsonIgnore]
    public AdditionalProperties AdditionalProperties { get; set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    void IJsonOnSerializing.OnSerializing() =>
        AdditionalProperties.CopyToExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

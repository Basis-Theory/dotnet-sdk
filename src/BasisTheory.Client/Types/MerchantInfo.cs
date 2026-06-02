using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record MerchantInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("full_legal_name")]
    public string? FullLegalName { get; set; }

    [JsonPropertyName("doing_business_as")]
    public string? DoingBusinessAs { get; set; }

    [JsonPropertyName("parent_company_name")]
    public string? ParentCompanyName { get; set; }

    [JsonPropertyName("website_url")]
    public string? WebsiteUrl { get; set; }

    [JsonPropertyName("category_code_mcc")]
    public string? CategoryCodeMcc { get; set; }

    [JsonPropertyName("descriptor")]
    public string? Descriptor { get; set; }

    [JsonPropertyName("business_description")]
    public string? BusinessDescription { get; set; }

    [JsonPropertyName("registration")]
    public MerchantRegistration? Registration { get; set; }

    [JsonPropertyName("contact")]
    public MerchantContact? Contact { get; set; }

    [JsonPropertyName("address")]
    public MerchantAddress? Address { get; set; }

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

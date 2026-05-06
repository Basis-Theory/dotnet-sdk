using System.Text.Json;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[Serializable]
public record MerchantInfo
{
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

using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace BasisTheory.Client;

[Serializable]
public record PaymentCredentialCredential : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// card, network-token, and identifier are direct API credentials. mpp is a complete base64url Machine Payments Protocol credential for an Authorization Payment header.
    /// </summary>
    [JsonPropertyName("format")]
    public required PaymentCredentialCredentialFormat Format { get; set; }

    /// <summary>
    /// Spendable credential value in the requested format. Returned once and never persisted.
    /// </summary>
    [JsonPropertyName("value")]
    public required OneOf<object, string> Value { get; set; }

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

using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.ApplePay;

[Serializable]
public record ApplePayDomainRegistrationListRequest
{
    [JsonPropertyName("domains")]
    public IEnumerable<string>? Domains { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

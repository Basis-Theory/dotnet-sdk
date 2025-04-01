using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.ApplePay;

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

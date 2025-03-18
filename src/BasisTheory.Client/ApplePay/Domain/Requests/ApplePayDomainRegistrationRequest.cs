using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.ApplePay;

public record ApplePayDomainRegistrationRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

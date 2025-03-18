using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.ApplePay;

public record ApplePayDomainDeregistrationRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

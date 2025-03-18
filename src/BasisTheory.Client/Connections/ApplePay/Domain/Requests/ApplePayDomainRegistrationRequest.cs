using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Connections.ApplePay;

public record ApplePayDomainRegistrationRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

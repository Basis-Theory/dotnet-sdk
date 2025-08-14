using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client.ApplePay;

[Serializable]
public record ApplePayDomainRegistrationRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

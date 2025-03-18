using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplePayDomainRegistrationResponse
{
    [JsonPropertyName("domains")]
    public IEnumerable<DomainRegistrationResponse>? Domains { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

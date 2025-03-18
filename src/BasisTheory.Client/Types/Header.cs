using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record Header
{
    [JsonPropertyName("publicKeyHash")]
    public string? PublicKeyHash { get; set; }

    [JsonPropertyName("ephemeralPublicKey")]
    public string? EphemeralPublicKey { get; set; }

    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; set; }

    [JsonPropertyName("applicationData")]
    public string? ApplicationData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

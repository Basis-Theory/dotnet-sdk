using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record BankVerificationResponse
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record CreateTenantConnectionResponse
{
    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

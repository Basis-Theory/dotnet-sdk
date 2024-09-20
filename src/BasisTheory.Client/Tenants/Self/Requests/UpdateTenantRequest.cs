using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Tenants;

public record UpdateTenantRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("settings")]
    public Dictionary<string, string?>? Settings { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

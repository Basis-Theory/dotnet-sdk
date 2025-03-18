using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record GetPermissions
{
    [JsonPropertyName("application_type")]
    public string? ApplicationType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record PermissionsListRequest
{
    [JsonIgnore]
    public string? ApplicationType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

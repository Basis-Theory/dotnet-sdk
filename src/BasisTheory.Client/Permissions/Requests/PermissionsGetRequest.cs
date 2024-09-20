using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record PermissionsGetRequest
{
    public string? ApplicationType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

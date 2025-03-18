using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record PermissionsListRequest
{
    public string? ApplicationType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client.Tenants;

public record MembersListRequest
{
    public IEnumerable<string> UserId { get; set; } = new List<string>();

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

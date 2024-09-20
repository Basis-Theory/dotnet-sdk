using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ApplicationsListRequest
{
    public IEnumerable<string> Id { get; set; } = new List<string>();

    public IEnumerable<string> Type { get; set; } = new List<string>();

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

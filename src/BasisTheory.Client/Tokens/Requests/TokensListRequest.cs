using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record TokensListRequest
{
    public IEnumerable<string> Id { get; set; } = new List<string>();

    public Dictionary<string, string?>? Metadata { get; set; }

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

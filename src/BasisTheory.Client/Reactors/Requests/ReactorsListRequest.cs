using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ReactorsListRequest
{
    public IEnumerable<string> Id { get; set; } = new List<string>();

    public string? Name { get; set; }

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

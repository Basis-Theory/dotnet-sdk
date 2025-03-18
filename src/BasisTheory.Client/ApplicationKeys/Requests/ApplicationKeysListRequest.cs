using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplicationKeysListRequest
{
    public IEnumerable<string> Id { get; set; } = new List<string>();

    public IEnumerable<string> Type { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

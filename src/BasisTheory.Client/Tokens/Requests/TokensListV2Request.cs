using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokensListV2Request
{
    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

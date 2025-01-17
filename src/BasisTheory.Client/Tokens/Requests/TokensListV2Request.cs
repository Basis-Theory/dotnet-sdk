using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokensListV2Request
{
    public string? Type { get; set; }

    public string? Container { get; set; }

    public string? Fingerprint { get; set; }

    public Dictionary<string, string?>? Metadata { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

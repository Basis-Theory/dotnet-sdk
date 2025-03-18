using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record LogsListRequest
{
    public string? EntityType { get; set; }

    public string? EntityId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Page { get; set; }

    public string? Start { get; set; }

    public int? Size { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

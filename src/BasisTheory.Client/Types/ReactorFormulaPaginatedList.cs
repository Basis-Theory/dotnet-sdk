using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ReactorFormulaPaginatedList
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<ReactorFormula>? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

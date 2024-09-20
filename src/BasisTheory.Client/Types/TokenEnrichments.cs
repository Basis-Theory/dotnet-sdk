using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record TokenEnrichments
{
    [JsonPropertyName("bin_details")]
    public BinDetails? BinDetails { get; set; }

    [JsonPropertyName("card_details")]
    public CardDetails? CardDetails { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

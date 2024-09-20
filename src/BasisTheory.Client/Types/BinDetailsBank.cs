using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record BinDetailsBank
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("clean_name")]
    public string? CleanName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ThreeDsAcsRenderingType
{
    [JsonPropertyName("acsInterface")]
    public string? AcsInterface { get; set; }

    [JsonPropertyName("acsUiTemplate")]
    public string? AcsUiTemplate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record ThreeDsMobileSdkRenderOptions
{
    [JsonPropertyName("sdk_interface")]
    public string? SdkInterface { get; set; }

    [JsonPropertyName("sdk_ui_type")]
    public IEnumerable<string>? SdkUiType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record VerifyAllowanceRequestStart : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rail")]
    public required VerifyAllowanceRequestStartRail Rail { get; set; }

    [JsonPropertyName("provider")]
    public required VerifyAllowanceRequestStartProvider Provider { get; set; }

    /// <summary>
    /// Application or agent name shown on network verification screens, including approval and return-to-application messages.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Browser/device data captured once on Visa `start`. Only `language_code` and `time_zone` are validated; every other property is forwarded to Visa unchanged. The API retains it for `submit_session`.
    /// </summary>
    [JsonPropertyName("device_context")]
    public VerifyAllowanceRequestStartDeviceContext? DeviceContext { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

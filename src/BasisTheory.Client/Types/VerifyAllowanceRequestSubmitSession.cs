using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record VerifyAllowanceRequestSubmitSession : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rail")]
    public string Rail { get; set; } = "agentic-token";

    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "vic";

    /// <summary>
    /// Secure session returned by Visa's hosted iframe after `passkey_session`. The original device context and display name are retained server-side.
    /// </summary>
    [JsonPropertyName("session_context")]
    public required VerifyAllowanceRequestSubmitSessionSessionContext SessionContext { get; set; }

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

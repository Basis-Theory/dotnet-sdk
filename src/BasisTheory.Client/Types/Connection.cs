using global::BasisTheory.Client.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[Serializable]
public record Connection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// How the authorization was established. A property of the grant, not of the provider — one provider may offer several.
    /// </summary>
    [JsonPropertyName("grant_method")]
    public required string GrantMethod { get; set; }

    [JsonPropertyName("principal")]
    public required ConnectionPrincipal Principal { get; set; }

    [JsonPropertyName("status")]
    public required ConnectionStatus Status { get; set; }

    [JsonPropertyName("status_details")]
    public required ConnectionStatusDetails StatusDetails { get; set; }

    [JsonPropertyName("permissions")]
    public required ConnectionPermissions Permissions { get; set; }

    /// <summary>
    /// RFC 9396 authorization details actually granted by the provider.
    /// </summary>
    [JsonPropertyName("authorization_details")]
    public IEnumerable<ConnectionAuthorizationDetailsItem>? AuthorizationDetails { get; set; }

    [JsonPropertyName("next_action")]
    public ConnectionNextAction? NextAction { get; set; }

    /// <summary>
    /// When the authority itself lapses, if the provider tells us. Absent means no scheduled end, which is the common case — most providers on this roster never expire an authorization. This is deliberately not the bearer credential's own expiry, which is internal.
    /// </summary>
    [JsonPropertyName("authorization_expires_at")]
    public DateTime? AuthorizationExpiresAt { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

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

using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Tenants;

[Serializable]
public record SecurityContactEmailRequest
{
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

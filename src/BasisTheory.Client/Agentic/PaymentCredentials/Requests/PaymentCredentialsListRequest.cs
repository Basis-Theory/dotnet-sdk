using global::BasisTheory.Client.Core;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.Agentic;

[Serializable]
public record PaymentCredentialsListRequest
{
    [JsonIgnore]
    public int? Size { get; set; }

    [JsonIgnore]
    public string? Start { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

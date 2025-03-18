using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record GooglePayTokenizeResponse
{
    [JsonPropertyName("token_intent")]
    public CreateTokenIntentResponse? TokenIntent { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

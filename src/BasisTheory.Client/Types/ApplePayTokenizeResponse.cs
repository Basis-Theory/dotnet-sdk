using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record ApplePayTokenizeResponse
{
    [JsonPropertyName("token_intent")]
    public CreateTokenIntentResponse? TokenIntent { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

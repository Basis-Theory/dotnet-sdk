using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

public record AssuranceDetails
{
    [JsonPropertyName("account_verified")]
    public bool? AccountVerified { get; set; }

    [JsonPropertyName("card_holder_authenticated")]
    public bool? CardHolderAuthenticated { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

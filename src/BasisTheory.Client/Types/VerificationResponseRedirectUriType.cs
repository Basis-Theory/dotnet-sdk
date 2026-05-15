using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<VerificationResponseRedirectUriType>))]
public enum VerificationResponseRedirectUriType
{
    [EnumMember(Value = "WEB_URI")]
    WebUri,

    [EnumMember(Value = "APP_URI")]
    AppUri,
}

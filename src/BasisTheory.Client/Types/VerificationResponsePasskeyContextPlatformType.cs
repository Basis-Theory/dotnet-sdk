using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<VerificationResponsePasskeyContextPlatformType>))]
public enum VerificationResponsePasskeyContextPlatformType
{
    [EnumMember(Value = "WEB")]
    Web,

    [EnumMember(Value = "MOBILE")]
    Mobile,

    [EnumMember(Value = "NATIVE")]
    Native,
}

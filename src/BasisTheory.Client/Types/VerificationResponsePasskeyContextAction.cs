using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<VerificationResponsePasskeyContextAction>))]
public enum VerificationResponsePasskeyContextAction
{
    [EnumMember(Value = "REGISTER")]
    Register,

    [EnumMember(Value = "AUTHENTICATE")]
    Authenticate,
}

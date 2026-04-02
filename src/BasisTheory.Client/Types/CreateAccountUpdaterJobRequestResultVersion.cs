using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<CreateAccountUpdaterJobRequestResultVersion>))]
public enum CreateAccountUpdaterJobRequestResultVersion
{
    [EnumMember(Value = "1")]
    One,

    [EnumMember(Value = "1.1")]
    One1,
}

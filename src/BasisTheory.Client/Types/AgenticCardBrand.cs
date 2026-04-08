using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<AgenticCardBrand>))]
public enum AgenticCardBrand
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,
}

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<VerificationResponseBrand>))]
public enum VerificationResponseBrand
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,
}

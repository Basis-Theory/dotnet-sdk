using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<EnrollmentProvider>))]
public enum EnrollmentProvider
{
    [EnumMember(Value = "visa")]
    Visa,

    [EnumMember(Value = "mastercard")]
    Mastercard,

    [EnumMember(Value = "visa-mock")]
    VisaMock,

    [EnumMember(Value = "mastercard-mock")]
    MastercardMock,
}

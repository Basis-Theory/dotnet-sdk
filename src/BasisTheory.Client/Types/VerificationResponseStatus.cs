using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<VerificationResponseStatus>))]
public enum VerificationResponseStatus
{
    [EnumMember(Value = "approved")]
    Approved,

    [EnumMember(Value = "challenge")]
    Challenge,

    [EnumMember(Value = "otp_sent")]
    OtpSent,

    [EnumMember(Value = "device_bound")]
    DeviceBound,

    [EnumMember(Value = "passkey_required")]
    PasskeyRequired,

    [EnumMember(Value = "verified")]
    Verified,
}

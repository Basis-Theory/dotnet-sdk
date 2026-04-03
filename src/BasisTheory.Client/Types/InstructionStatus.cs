using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<InstructionStatus>))]
public enum InstructionStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "pending_verification")]
    PendingVerification,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "expired")]
    Expired,
}

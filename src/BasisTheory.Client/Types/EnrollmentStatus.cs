using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<EnrollmentStatus>))]
public enum EnrollmentStatus
{
    [EnumMember(Value = "pending_verification")]
    PendingVerification,

    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "suspended")]
    Suspended,

    [EnumMember(Value = "deleted")]
    Deleted,

    [EnumMember(Value = "failed")]
    Failed,
}

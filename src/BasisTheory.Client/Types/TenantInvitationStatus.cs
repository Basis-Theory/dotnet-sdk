using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

#nullable enable

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<TenantInvitationStatus>))]
public enum TenantInvitationStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "EXPIRED")]
    Expired,
}

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<TransactionStatus>))]
public enum TransactionStatus
{
    [EnumMember(Value = "approved")]
    Approved,

    [EnumMember(Value = "declined")]
    Declined,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "cancelled")]
    Cancelled,
}

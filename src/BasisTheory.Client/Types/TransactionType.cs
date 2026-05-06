using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<TransactionType>))]
public enum TransactionType
{
    [EnumMember(Value = "purchase")]
    Purchase,

    [EnumMember(Value = "authorization")]
    Authorization,

    [EnumMember(Value = "capture")]
    Capture,

    [EnumMember(Value = "refund")]
    Refund,

    [EnumMember(Value = "reversal")]
    Reversal,

    [EnumMember(Value = "verification")]
    Verification,

    [EnumMember(Value = "chargeback")]
    Chargeback,

    [EnumMember(Value = "fraud")]
    Fraud,
}

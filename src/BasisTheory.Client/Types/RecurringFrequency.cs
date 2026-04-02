using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<RecurringFrequency>))]
public enum RecurringFrequency
{
    [EnumMember(Value = "weekly")]
    Weekly,

    [EnumMember(Value = "monthly")]
    Monthly,

    [EnumMember(Value = "yearly")]
    Yearly,
}

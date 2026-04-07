using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<MppSourceType>))]
public enum MppSourceType
{
    [EnumMember(Value = "token")]
    Token,

    [EnumMember(Value = "network_token")]
    NetworkToken,

    [EnumMember(Value = "apple_pay")]
    ApplePay,

    [EnumMember(Value = "google_pay")]
    GooglePay,

    [EnumMember(Value = "visa_intelligent_commerce")]
    VisaIntelligentCommerce,
}

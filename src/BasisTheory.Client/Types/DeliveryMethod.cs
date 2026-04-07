using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<DeliveryMethod>))]
public enum DeliveryMethod
{
    [EnumMember(Value = "no-delivery")]
    NoDelivery,

    [EnumMember(Value = "address-billing")]
    AddressBilling,

    [EnumMember(Value = "address-on-file")]
    AddressOnFile,

    [EnumMember(Value = "address-other")]
    AddressOther,

    [EnumMember(Value = "pickup")]
    Pickup,

    [EnumMember(Value = "electronic")]
    Electronic,
}

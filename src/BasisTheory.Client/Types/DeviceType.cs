using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnumSerializer<DeviceType>))]
public enum DeviceType
{
    [EnumMember(Value = "mobile-phone")]
    MobilePhone,

    [EnumMember(Value = "tablet")]
    Tablet,

    [EnumMember(Value = "laptop")]
    Laptop,

    [EnumMember(Value = "personal-assistant")]
    PersonalAssistant,

    [EnumMember(Value = "connected-auto")]
    ConnectedAuto,

    [EnumMember(Value = "home-appliance")]
    HomeAppliance,

    [EnumMember(Value = "wearable")]
    Wearable,

    [EnumMember(Value = "stationary-computer")]
    StationaryComputer,

    [EnumMember(Value = "e-reader")]
    EReader,

    [EnumMember(Value = "handheld-gaming-device")]
    HandheldGamingDevice,

    [EnumMember(Value = "other")]
    Other,
}

using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(DeviceTypeSerializer))]
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

internal class DeviceTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeviceType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeviceType
    > _stringToEnum = new()
    {
        { "mobile-phone", DeviceType.MobilePhone },
        { "tablet", DeviceType.Tablet },
        { "laptop", DeviceType.Laptop },
        { "personal-assistant", DeviceType.PersonalAssistant },
        { "connected-auto", DeviceType.ConnectedAuto },
        { "home-appliance", DeviceType.HomeAppliance },
        { "wearable", DeviceType.Wearable },
        { "stationary-computer", DeviceType.StationaryComputer },
        { "e-reader", DeviceType.EReader },
        { "handheld-gaming-device", DeviceType.HandheldGamingDevice },
        { "other", DeviceType.Other },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeviceType,
        string
    > _enumToString = new()
    {
        { DeviceType.MobilePhone, "mobile-phone" },
        { DeviceType.Tablet, "tablet" },
        { DeviceType.Laptop, "laptop" },
        { DeviceType.PersonalAssistant, "personal-assistant" },
        { DeviceType.ConnectedAuto, "connected-auto" },
        { DeviceType.HomeAppliance, "home-appliance" },
        { DeviceType.Wearable, "wearable" },
        { DeviceType.StationaryComputer, "stationary-computer" },
        { DeviceType.EReader, "e-reader" },
        { DeviceType.HandheldGamingDevice, "handheld-gaming-device" },
        { DeviceType.Other, "other" },
    };

    public override DeviceType Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        DeviceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeviceType ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        DeviceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

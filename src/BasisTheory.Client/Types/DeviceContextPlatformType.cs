using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(DeviceContextPlatformTypeSerializer))]
public enum DeviceContextPlatformType
{
    [EnumMember(Value = "WEB")]
    Web,

    [EnumMember(Value = "MOBILE")]
    Mobile,

    [EnumMember(Value = "NATIVE")]
    Native,
}

internal class DeviceContextPlatformTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeviceContextPlatformType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeviceContextPlatformType
    > _stringToEnum = new()
    {
        { "WEB", DeviceContextPlatformType.Web },
        { "MOBILE", DeviceContextPlatformType.Mobile },
        { "NATIVE", DeviceContextPlatformType.Native },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeviceContextPlatformType,
        string
    > _enumToString = new()
    {
        { DeviceContextPlatformType.Web, "WEB" },
        { DeviceContextPlatformType.Mobile, "MOBILE" },
        { DeviceContextPlatformType.Native, "NATIVE" },
    };

    public override DeviceContextPlatformType Read(
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
        DeviceContextPlatformType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeviceContextPlatformType ReadAsPropertyName(
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
        DeviceContextPlatformType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

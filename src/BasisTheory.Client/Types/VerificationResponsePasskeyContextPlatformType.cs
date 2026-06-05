using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerificationResponsePasskeyContextPlatformTypeSerializer))]
public enum VerificationResponsePasskeyContextPlatformType
{
    [EnumMember(Value = "WEB")]
    Web,

    [EnumMember(Value = "MOBILE")]
    Mobile,

    [EnumMember(Value = "NATIVE")]
    Native,
}

internal class VerificationResponsePasskeyContextPlatformTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerificationResponsePasskeyContextPlatformType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerificationResponsePasskeyContextPlatformType
    > _stringToEnum = new()
    {
        { "WEB", VerificationResponsePasskeyContextPlatformType.Web },
        { "MOBILE", VerificationResponsePasskeyContextPlatformType.Mobile },
        { "NATIVE", VerificationResponsePasskeyContextPlatformType.Native },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerificationResponsePasskeyContextPlatformType,
        string
    > _enumToString = new()
    {
        { VerificationResponsePasskeyContextPlatformType.Web, "WEB" },
        { VerificationResponsePasskeyContextPlatformType.Mobile, "MOBILE" },
        { VerificationResponsePasskeyContextPlatformType.Native, "NATIVE" },
    };

    public override VerificationResponsePasskeyContextPlatformType Read(
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
        VerificationResponsePasskeyContextPlatformType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerificationResponsePasskeyContextPlatformType ReadAsPropertyName(
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
        VerificationResponsePasskeyContextPlatformType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

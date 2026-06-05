using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(VerificationResponsePasskeyContextActionSerializer))]
public enum VerificationResponsePasskeyContextAction
{
    [EnumMember(Value = "REGISTER")]
    Register,

    [EnumMember(Value = "AUTHENTICATE")]
    Authenticate,
}

internal class VerificationResponsePasskeyContextActionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VerificationResponsePasskeyContextAction>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VerificationResponsePasskeyContextAction
    > _stringToEnum = new()
    {
        { "REGISTER", VerificationResponsePasskeyContextAction.Register },
        { "AUTHENTICATE", VerificationResponsePasskeyContextAction.Authenticate },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VerificationResponsePasskeyContextAction,
        string
    > _enumToString = new()
    {
        { VerificationResponsePasskeyContextAction.Register, "REGISTER" },
        { VerificationResponsePasskeyContextAction.Authenticate, "AUTHENTICATE" },
    };

    public override VerificationResponsePasskeyContextAction Read(
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
        VerificationResponsePasskeyContextAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VerificationResponsePasskeyContextAction ReadAsPropertyName(
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
        VerificationResponsePasskeyContextAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

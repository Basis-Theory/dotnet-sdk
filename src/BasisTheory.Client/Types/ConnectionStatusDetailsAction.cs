using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(ConnectionStatusDetailsActionSerializer))]
public enum ConnectionStatusDetailsAction
{
    [EnumMember(Value = "authorize")]
    Authorize,

    [EnumMember(Value = "reauthorize")]
    Reauthorize,

    [EnumMember(Value = "none")]
    None,
}

internal class ConnectionStatusDetailsActionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConnectionStatusDetailsAction>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConnectionStatusDetailsAction
    > _stringToEnum = new()
    {
        { "authorize", ConnectionStatusDetailsAction.Authorize },
        { "reauthorize", ConnectionStatusDetailsAction.Reauthorize },
        { "none", ConnectionStatusDetailsAction.None },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConnectionStatusDetailsAction,
        string
    > _enumToString = new()
    {
        { ConnectionStatusDetailsAction.Authorize, "authorize" },
        { ConnectionStatusDetailsAction.Reauthorize, "reauthorize" },
        { ConnectionStatusDetailsAction.None, "none" },
    };

    public override ConnectionStatusDetailsAction Read(
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
        ConnectionStatusDetailsAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConnectionStatusDetailsAction ReadAsPropertyName(
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
        ConnectionStatusDetailsAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

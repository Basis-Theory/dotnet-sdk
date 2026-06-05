using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client.AccountUpdater;

[JsonConverter(typeof(CreateAccountUpdaterJobRequestResultVersionSerializer))]
public enum CreateAccountUpdaterJobRequestResultVersion
{
    [EnumMember(Value = "1")]
    One,

    [EnumMember(Value = "1.1")]
    One1,

    [EnumMember(Value = "1.2")]
    One2,
}

internal class CreateAccountUpdaterJobRequestResultVersionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAccountUpdaterJobRequestResultVersion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAccountUpdaterJobRequestResultVersion
    > _stringToEnum = new()
    {
        { "1", CreateAccountUpdaterJobRequestResultVersion.One },
        { "1.1", CreateAccountUpdaterJobRequestResultVersion.One1 },
        { "1.2", CreateAccountUpdaterJobRequestResultVersion.One2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAccountUpdaterJobRequestResultVersion,
        string
    > _enumToString = new()
    {
        { CreateAccountUpdaterJobRequestResultVersion.One, "1" },
        { CreateAccountUpdaterJobRequestResultVersion.One1, "1.1" },
        { CreateAccountUpdaterJobRequestResultVersion.One2, "1.2" },
    };

    public override CreateAccountUpdaterJobRequestResultVersion Read(
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
        CreateAccountUpdaterJobRequestResultVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAccountUpdaterJobRequestResultVersion ReadAsPropertyName(
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
        CreateAccountUpdaterJobRequestResultVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

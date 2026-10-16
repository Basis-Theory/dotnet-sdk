using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(RuntimeLogSourceSerializer))]
public enum RuntimeLogSource
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "platform")]
    Platform,
}

internal class RuntimeLogSourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RuntimeLogSource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RuntimeLogSource
    > _stringToEnum = new()
    {
        { "application", RuntimeLogSource.Application },
        { "platform", RuntimeLogSource.Platform },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RuntimeLogSource,
        string
    > _enumToString = new()
    {
        { RuntimeLogSource.Application, "application" },
        { RuntimeLogSource.Platform, "platform" },
    };

    public override RuntimeLogSource Read(
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
        RuntimeLogSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RuntimeLogSource ReadAsPropertyName(
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
        RuntimeLogSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

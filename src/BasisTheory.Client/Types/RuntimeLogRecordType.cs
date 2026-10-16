using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(RuntimeLogRecordTypeSerializer))]
public enum RuntimeLogRecordType
{
    [EnumMember(Value = "log")]
    Log,

    [EnumMember(Value = "lifecycle")]
    Lifecycle,
}

internal class RuntimeLogRecordTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RuntimeLogRecordType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RuntimeLogRecordType
    > _stringToEnum = new()
    {
        { "log", RuntimeLogRecordType.Log },
        { "lifecycle", RuntimeLogRecordType.Lifecycle },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RuntimeLogRecordType,
        string
    > _enumToString = new()
    {
        { RuntimeLogRecordType.Log, "log" },
        { RuntimeLogRecordType.Lifecycle, "lifecycle" },
    };

    public override RuntimeLogRecordType Read(
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
        RuntimeLogRecordType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RuntimeLogRecordType ReadAsPropertyName(
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
        RuntimeLogRecordType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

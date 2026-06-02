using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(RecurringFrequencySerializer))]
public enum RecurringFrequency
{
    [EnumMember(Value = "weekly")]
    Weekly,

    [EnumMember(Value = "monthly")]
    Monthly,

    [EnumMember(Value = "yearly")]
    Yearly,
}

internal class RecurringFrequencySerializer
    : global::System.Text.Json.Serialization.JsonConverter<RecurringFrequency>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RecurringFrequency
    > _stringToEnum = new()
    {
        { "weekly", RecurringFrequency.Weekly },
        { "monthly", RecurringFrequency.Monthly },
        { "yearly", RecurringFrequency.Yearly },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RecurringFrequency,
        string
    > _enumToString = new()
    {
        { RecurringFrequency.Weekly, "weekly" },
        { RecurringFrequency.Monthly, "monthly" },
        { RecurringFrequency.Yearly, "yearly" },
    };

    public override RecurringFrequency Read(
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
        RecurringFrequency value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RecurringFrequency ReadAsPropertyName(
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
        RecurringFrequency value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

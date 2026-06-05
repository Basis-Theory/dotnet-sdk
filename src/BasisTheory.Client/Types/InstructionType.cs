using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(InstructionTypeSerializer))]
public enum InstructionType
{
    [EnumMember(Value = "agentic")]
    Agentic,

    [EnumMember(Value = "autofill")]
    Autofill,
}

internal class InstructionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InstructionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InstructionType
    > _stringToEnum = new()
    {
        { "agentic", InstructionType.Agentic },
        { "autofill", InstructionType.Autofill },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InstructionType,
        string
    > _enumToString = new()
    {
        { InstructionType.Agentic, "agentic" },
        { InstructionType.Autofill, "autofill" },
    };

    public override InstructionType Read(
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
        InstructionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InstructionType ReadAsPropertyName(
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
        InstructionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}

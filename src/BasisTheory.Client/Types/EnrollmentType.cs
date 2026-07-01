using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace BasisTheory.Client;

[JsonConverter(typeof(EnrollmentTypeSerializer))]
public enum EnrollmentType
{
    [EnumMember(Value = "agentic")]
    Agentic,

    [EnumMember(Value = "autofill")]
    Autofill,

    [EnumMember(Value = "spt")]
    Spt,
}

internal class EnrollmentTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EnrollmentType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EnrollmentType
    > _stringToEnum = new()
    {
        { "agentic", EnrollmentType.Agentic },
        { "autofill", EnrollmentType.Autofill },
        { "spt", EnrollmentType.Spt },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EnrollmentType,
        string
    > _enumToString = new()
    {
        { EnrollmentType.Agentic, "agentic" },
        { EnrollmentType.Autofill, "autofill" },
        { EnrollmentType.Spt, "spt" },
    };

    public override EnrollmentType Read(
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
        EnrollmentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EnrollmentType ReadAsPropertyName(
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
        EnrollmentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
